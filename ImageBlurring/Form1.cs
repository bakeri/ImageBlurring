using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;

namespace ImageBlurring
{
    public partial class Form1 : Form
    {
        private Image _tiffImage;
        private Image _tiffImage2;
        private int _currentPage= 1;
        private int _currentPageImage2 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        struct Pixel
        {
            public int Red;
            public int Blue;
            public int Green;

        }

     
        private static Bitmap Blur(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the blur rectangle
            for (Int32 xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (Int32 yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    Int32 avgR = 0, avgG = 0, avgB = 0;
                    Int32 blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (Int32 x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (Int32 y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (Int32 x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (Int32 y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }


        private static unsafe Bitmap Blur2(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // Lock the bitmap's bits
            BitmapData blurredData = blurred.LockBits(new Rectangle(0, 0, image.Width, image.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, blurred.PixelFormat);

            // Get bits per pixel for current PixelFormat
            int bitsPerPixel = Image.GetPixelFormatSize(blurred.PixelFormat);

            // Get pointer to first line
            byte* scan0 = (byte*)blurredData.Scan0.ToPointer();

            // look at every pixel in the blur rectangle
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (int x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            // Get pointer to RGB
                            byte* data = scan0 + x * blurredData.Stride + y * bitsPerPixel / 8;

                            avgB += data[0]; // Blue
                            avgG += data[1]; // Green
                            avgR += data[2]; // Red

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (int x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                    {
                        for (int y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                        {
                            // Get pointer to RGB
                            byte* data = scan0 + x * blurredData.Stride + y * bitsPerPixel / 8;

                            // Change values
                            data[0] = (byte)avgB;
                            data[1] = (byte)avgG;
                            data[2] = (byte)avgR;
                        }
                    }
                }
            }

            // Unlock the bits
            blurred.UnlockBits(blurredData);

            return blurred;
        }


        private static Bitmap LineBlur(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {

            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            for (int yy = rectangle.Y; yy < rectangle.Height; yy++)
            {

                Queue<Pixel> pixelStack = new Queue<Pixel>();

                int blurPixelCount = blurSize;
                int totalR = 0, totalG = 0, totalB = 0;
                // look at every pixel in the blur rectangle
                for (int xx = rectangle.X; xx < rectangle.Width; xx += 1)
                {
                    Pixel pixelxy;
                    if (xx == 0)
                    {
                        for (int x = xx; (x < blurSize); x++)
                        {
                            Color pixel = blurred.GetPixel(x, yy);

                            totalR += pixel.R;
                            totalG += pixel.G;
                            totalB += pixel.B;

                            pixelxy.Red = pixel.R;
                            pixelxy.Blue = pixel.B;
                            pixelxy.Green = pixel.G;

                            pixelStack.Enqueue(pixelxy);

                        }
                    }
                    else
                    {
                        int endpoint;

                        if (xx + blurSize > image.Width - 1)
                        {
                            endpoint = image.Width - 1;
                            if (blurPixelCount > 1) blurPixelCount--;

                        }
                        else
                        {
                            endpoint = xx + blurSize;
                            Color pixelEnd = blurred.GetPixel(endpoint, yy);

                            totalR += pixelEnd.R;
                            totalG += pixelEnd.G;
                            totalB += pixelEnd.B;
                            pixelxy.Red = pixelEnd.R;
                            pixelxy.Green = pixelEnd.G;
                            pixelxy.Blue = pixelEnd.B;

                            pixelStack.Enqueue(pixelxy);

                        }

                        Pixel pixelStart = pixelStack.Dequeue();

                        totalR -= pixelStart.Red;
                        totalG -= pixelStart.Green;
                        totalB -= pixelStart.Blue;

                    }

                    int avgR = totalR / blurPixelCount;
                    int avgG = totalG / blurPixelCount;
                    int avgB = totalB / blurPixelCount;

                    blurred.SetPixel(xx, yy, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }


     

        private Bitmap ReduceImageSize(Bitmap img1, int newHeight,int newwidth)
        {
            Bitmap blurred = new Bitmap(newwidth,newHeight);
          //  Bitmap img1 = new Bitmap(pictureBox1.Image);

            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(img1, new Rectangle(0, 0, newwidth, newHeight),
                    new Rectangle(0, 0, img1.Width, img1.Height), GraphicsUnit.Pixel);
            return blurred;
        }

        private void btnPageUP_Click(object sender, EventArgs e)
        {

            Guid objGuid = _tiffImage.FrameDimensionsList[0];
            //create the frame dimension 
            FrameDimension dimension = new FrameDimension(objGuid);
            //Gets the total number of frames in the .tiff file 
            int noOfPages = _tiffImage.GetFrameCount(dimension);
            if (_currentPage >= noOfPages)
                return;
            else
            {
                _currentPage += 1;
                _tiffImage.SelectActiveFrame(FrameDimension.Page, _currentPage-1);
                pictureBox1.Image = _tiffImage;
                lblCurrentPage.Text = (_currentPage).ToString();
            }

          
           

        }

        private void BtnPageDown_Click(object sender, EventArgs e)
        {
            Guid objGuid = _tiffImage.FrameDimensionsList[0];
            //create the frame dimension 
            FrameDimension dimension = new FrameDimension(objGuid);
            //Gets the total number of frames in the .tiff file 
            int noOfPages = _tiffImage.GetFrameCount(dimension);
            if (_currentPage ==1)
                return;
            else
            {
                _currentPage -= 1;
                _tiffImage.SelectActiveFrame(FrameDimension.Page, _currentPage-1);
                pictureBox1.Image = _tiffImage;
                lblCurrentPage.Text = (_currentPage).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guid objGuid = _tiffImage2.FrameDimensionsList[0];
            //create the frame dimension 
            FrameDimension dimension = new FrameDimension(objGuid);
            //Gets the total number of frames in the .tiff file 
            int noOfPages = _tiffImage2.GetFrameCount(dimension);
            if (_currentPageImage2 == 1)
                return;
            else
            {
                _currentPageImage2 -= 1;
                _tiffImage2.SelectActiveFrame(FrameDimension.Page, _currentPageImage2 - 1);
                pictureBox2.Image = _tiffImage2;
                lblImage2Currentpage.Text = (_currentPageImage2).ToString();
            }
        }

        private void btnMaxPagesImage2_Click(object sender, EventArgs e)
        {
            Guid objGuid = _tiffImage2.FrameDimensionsList[0];
            //create the frame dimension 
            FrameDimension dimension = new FrameDimension(objGuid);
            //Gets the total number of frames in the .tiff file 
            int noOfPages = _tiffImage2.GetFrameCount(dimension);
            if (_currentPageImage2 >= noOfPages)
                return;
            else  
            {
                _currentPageImage2 += 1;
                _tiffImage2.SelectActiveFrame(FrameDimension.Page, _currentPageImage2 - 1);
                pictureBox2.Image = _tiffImage2;
                lblImage2Currentpage.Text = (_currentPageImage2).ToString();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd1.ShowDialog();
            _tiffImage = new Bitmap(ofd1.FileName);
            pictureBox2.Image = null;

            _tiffImage.SelectActiveFrame(FrameDimension.Page, 0);
            pictureBox1.Image = _tiffImage;



            //get the globally unique identifier (GUID) 
            Guid objGuid = _tiffImage.FrameDimensionsList[0];
            //create the frame dimension 
            FrameDimension dimension = new FrameDimension(objGuid);
            //Gets the total number of frames in the .tiff file 
            int noOfPages = _tiffImage.GetFrameCount(dimension);

            lblMaxPage.Text = noOfPages.ToString();
            lblCurrentPage.Text = _currentPage.ToString();

        }

        private void displaysecondImage(string imagename)
        {
            _tiffImage2 =  new Bitmap(imagename);
            

            _tiffImage2.SelectActiveFrame(FrameDimension.Page, 0);
            pictureBox2.Image = _tiffImage2;



            //get the globally unique identifier (GUID) 
            Guid objGuid = _tiffImage2.FrameDimensionsList[0];
            //create the frame dimension 
            FrameDimension dimension = new FrameDimension(objGuid);
            //Gets the total number of frames in the .tiff file 
            int noOfPages = _tiffImage2.GetFrameCount(dimension);

            lblImage2MaxPages.Text = noOfPages.ToString();
            lblImage2Currentpage.Text = _currentPage.ToString();


        }

        private Bitmap ReduceAndBlur(Image img )
        {
            Bitmap img1 = new Bitmap(ReduceImageSize(new Bitmap(img), int.Parse(txtWidth.Text), int.Parse(txtHeight.Text)));

            return  LineBlur(img1, new Rectangle(0, 0, img1.Width, img1.Height), int.Parse(txtBlurSize.Text));

        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                string messageBoxText = "PLease load a file"; 
                string caption = "Error";


                MessageBox.Show(messageBoxText, caption);

                return;
            }
            lblblurtime.Text = "";
            Stopwatch watch = new Stopwatch();
            watch.Start();
            pictureBox2.Image = null;


            // pictureBox1.Image = ReduceImageSize();

          // Bitmap img1 = new Bitmap(ReduceImageSize(new Bitmap(_tiffImage), int.Parse(txtWidth.Text), int.Parse(txtHeight.Text)));

           //Image img1 = new Bitmap(ReduceImageSize(new Bitmap(_tiffImage), int.Parse(txtWidth.Text), int.Parse(txtHeight.Text)));
            _tiffImage2 = ReduceAndBlur(_tiffImage);

          //  _tiffImage2 = LineBlur(img1, new Rectangle(0, 0, img1.Width, img1.Height), int.Parse(txtBlurSize.Text));
            watch.Stop();
            lblblurtime.Text = watch.Elapsed.TotalSeconds.ToString();

            pictureBox2.Image =  AddText(new Bitmap(_tiffImage2));


            //get the globally unique identifier (GUID) 
            Guid objGuid = _tiffImage2.FrameDimensionsList[0];
            //create the frame dimension 
            FrameDimension dimension = new FrameDimension(objGuid);
            //Gets the total number of frames in the .tiff file 
            int noOfPages2 = _tiffImage2.GetFrameCount(dimension);

            lblImage2MaxPages.Text = noOfPages2.ToString();
            lblImage2Currentpage.Text = _currentPage.ToString();

        }

        private void reduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ReduceImageSize(new Bitmap(pictureBox1.Image), int.Parse(txtHeight.Text), int.Parse(txtWidth.Text));
        }




        private void SplitTiffToFile(string filelocation, Image tifftosplit)
        {
            int pages = tifftosplit.GetFrameCount(FrameDimension.Page);
            List<Bitmap> imgs = new List<Bitmap>();

            for (int index = 0; index < pages; index++)

            {
               
                int activePage = index + 1;

                 tifftosplit.SelectActiveFrame(FrameDimension.Page, index);
                Image outImage = ReduceAndBlur(tifftosplit);

                imgs.Add(new Bitmap(outImage));
               // outImage.Save(filelocation + "page " +activePage.ToString() + ".tif");

            }

            saveToSingleFile(imgs, filelocation);
        }




        private Bitmap AddText(Bitmap bitmap)
        {
            string firstText = "Policy Number  123456";
          

            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 50f);

           
           // Bitmap bitmap = (Bitmap) Image.FromFile(imageFilePath); //load the image file

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Arial", 10))
                {
                    graphics.DrawString(firstText, arialFont, Brushes.Black, firstLocation);
                 //   graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
                }
            } 

            return bitmap;
            //  bitmap.Save(imageFilePath); //save the image file
        }
         
        private void multipleFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string messageBoxText;
            string caption;
            string filename =
                "C:\\Users\\ianba\\OneDrive\\Documents\\Visual Studio 2017\\Projects\\ImageBlurring\\ImageBlurring\\bin\\Debug\\Images\\pic.tiff";



            if (pictureBox1.Image == null)
            {
               messageBoxText = "There is no file to save"; 
               caption = "Error";


                MessageBox.Show(messageBoxText, caption);

                return;
            }

            pictureBox2.Image = null;

            Stopwatch watch = new Stopwatch();
            watch.Start();
            SplitTiffToFile(filename,_tiffImage);
            messageBoxText = "Save Complete";
            caption = " Multi Page Save";
            
            watch.Stop();
            lblblurtime.Text = watch.Elapsed.TotalSeconds.ToString();
           displaysecondImage(filename);
            MessageBox.Show(messageBoxText, caption);

        }

        private void saveToSingleFile( List<Bitmap> imgs, string newFileName)
        {

            
            System.Drawing.Imaging.Encoder enc = Encoder.SaveFlag;

            ImageCodecInfo info = null;
            info = (from ie in ImageCodecInfo.GetImageEncoders()
                where ie.MimeType == "image/tiff"
                select ie).FirstOrDefault();

            EncoderParameters encoderparams = new EncoderParameters(1);

            encoderparams.Param[0] = new EncoderParameter(enc, (long) EncoderValue.MultiFrame);
            Bitmap bitmap = imgs[0];
           
           bitmap.Save(newFileName,info,encoderparams);

           encoderparams.Param[0] = new EncoderParameter(enc,(long)EncoderValue.FrameDimensionPage);

           for(int x=1;x<imgs.Count;x++)

            {
                bitmap.SaveAdd(imgs[x], encoderparams);

            }

            //close file

            encoderparams.Param[0] = new EncoderParameter(enc, (long)EncoderValue.Flush);
            bitmap.SaveAdd(encoderparams);
            bitmap.Dispose();



        }
    }
}

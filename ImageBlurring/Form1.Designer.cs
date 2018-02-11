namespace ImageBlurring
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBlurSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblblurtime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnPageUP = new System.Windows.Forms.Button();
            this.BtnPageDown = new System.Windows.Forms.Button();
            this.lblMaxPage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.lblImage2Currentpage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblImage2MaxPages = new System.Windows.Forms.Label();
            this.btnPageDownImage2 = new System.Windows.Forms.Button();
            this.btnMaxPagesImage2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.multipleFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 698);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(720, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 698);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtBlurSize
            // 
            this.txtBlurSize.Location = new System.Drawing.Point(1036, 841);
            this.txtBlurSize.Name = "txtBlurSize";
            this.txtBlurSize.Size = new System.Drawing.Size(100, 20);
            this.txtBlurSize.TabIndex = 4;
            this.txtBlurSize.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(971, 847);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Blur Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 823);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Blur Time";
            // 
            // lblblurtime
            // 
            this.lblblurtime.AutoSize = true;
            this.lblblurtime.Location = new System.Drawing.Point(758, 822);
            this.lblblurtime.Name = "lblblurtime";
            this.lblblurtime.Size = new System.Drawing.Size(58, 13);
            this.lblblurtime.TabIndex = 7;
            this.lblblurtime.Text = "lblBlurTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(971, 795);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(971, 822);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(1036, 787);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 11;
            this.txtHeight.Text = "400";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(1036, 815);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.Text = "320";
            // 
            // btnPageUP
            // 
            this.btnPageUP.Location = new System.Drawing.Point(361, 8);
            this.btnPageUP.Name = "btnPageUP";
            this.btnPageUP.Size = new System.Drawing.Size(27, 23);
            this.btnPageUP.TabIndex = 13;
            this.btnPageUP.Text = ">";
            this.btnPageUP.UseVisualStyleBackColor = true;
            this.btnPageUP.Click += new System.EventHandler(this.btnPageUP_Click);
            // 
            // BtnPageDown
            // 
            this.BtnPageDown.Location = new System.Drawing.Point(329, 8);
            this.BtnPageDown.Name = "BtnPageDown";
            this.BtnPageDown.Size = new System.Drawing.Size(26, 23);
            this.BtnPageDown.TabIndex = 14;
            this.BtnPageDown.Text = "<";
            this.BtnPageDown.UseVisualStyleBackColor = true;
            this.BtnPageDown.Click += new System.EventHandler(this.BtnPageDown_Click);
            // 
            // lblMaxPage
            // 
            this.lblMaxPage.AutoSize = true;
            this.lblMaxPage.Location = new System.Drawing.Point(275, 18);
            this.lblMaxPage.Name = "lblMaxPage";
            this.lblMaxPage.Size = new System.Drawing.Size(0, 13);
            this.lblMaxPage.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "of";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(212, 18);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentPage.TabIndex = 17;
            // 
            // lblImage2Currentpage
            // 
            this.lblImage2Currentpage.AutoSize = true;
            this.lblImage2Currentpage.Location = new System.Drawing.Point(212, 19);
            this.lblImage2Currentpage.Name = "lblImage2Currentpage";
            this.lblImage2Currentpage.Size = new System.Drawing.Size(0, 13);
            this.lblImage2Currentpage.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "of";
            // 
            // lblImage2MaxPages
            // 
            this.lblImage2MaxPages.AutoSize = true;
            this.lblImage2MaxPages.Location = new System.Drawing.Point(275, 19);
            this.lblImage2MaxPages.Name = "lblImage2MaxPages";
            this.lblImage2MaxPages.Size = new System.Drawing.Size(0, 13);
            this.lblImage2MaxPages.TabIndex = 20;
            // 
            // btnPageDownImage2
            // 
            this.btnPageDownImage2.Location = new System.Drawing.Point(329, 9);
            this.btnPageDownImage2.Name = "btnPageDownImage2";
            this.btnPageDownImage2.Size = new System.Drawing.Size(26, 23);
            this.btnPageDownImage2.TabIndex = 19;
            this.btnPageDownImage2.Text = "<";
            this.btnPageDownImage2.UseVisualStyleBackColor = true;
            this.btnPageDownImage2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMaxPagesImage2
            // 
            this.btnMaxPagesImage2.Location = new System.Drawing.Point(361, 9);
            this.btnMaxPagesImage2.Name = "btnMaxPagesImage2";
            this.btnMaxPagesImage2.Size = new System.Drawing.Size(27, 23);
            this.btnMaxPagesImage2.TabIndex = 18;
            this.btnMaxPagesImage2.Text = ">";
            this.btnMaxPagesImage2.UseVisualStyleBackColor = true;
            this.btnMaxPagesImage2.Click += new System.EventHandler(this.btnMaxPagesImage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnPageUP);
            this.groupBox1.Controls.Add(this.BtnPageDown);
            this.groupBox1.Controls.Add(this.lblMaxPage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCurrentPage);
            this.groupBox1.Location = new System.Drawing.Point(31, 722);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 38);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.TSMIProcess});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1548, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multipleFilesToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // TSMIProcess
            // 
            this.TSMIProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.reduceToolStripMenuItem});
            this.TSMIProcess.Name = "TSMIProcess";
            this.TSMIProcess.Size = new System.Drawing.Size(59, 20);
            this.TSMIProcess.Text = "Process";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // reduceToolStripMenuItem
            // 
            this.reduceToolStripMenuItem.Name = "reduceToolStripMenuItem";
            this.reduceToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.reduceToolStripMenuItem.Text = "Reduce";
            this.reduceToolStripMenuItem.Click += new System.EventHandler(this.reduceToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnMaxPagesImage2);
            this.groupBox2.Controls.Add(this.lblImage2Currentpage);
            this.groupBox2.Controls.Add(this.btnPageDownImage2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblImage2MaxPages);
            this.groupBox2.Location = new System.Drawing.Point(720, 722);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 38);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 17;
            // 
            // multipleFilesToolStripMenuItem
            // 
            this.multipleFilesToolStripMenuItem.Name = "multipleFilesToolStripMenuItem";
            this.multipleFilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.multipleFilesToolStripMenuItem.Text = "Multiple Files";
            this.multipleFilesToolStripMenuItem.Click += new System.EventHandler(this.multipleFilesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 892);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblblurtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlurSize);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing Test Area";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.TextBox txtBlurSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblblurtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnPageUP;
        private System.Windows.Forms.Button BtnPageDown;
        private System.Windows.Forms.Label lblMaxPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label lblImage2Currentpage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblImage2MaxPages;
        private System.Windows.Forms.Button btnPageDownImage2;
        private System.Windows.Forms.Button btnMaxPagesImage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIProcess;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduceToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem multipleFilesToolStripMenuItem;
    }
}


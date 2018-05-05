namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFileList = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.chkMergePDF = new System.Windows.Forms.CheckBox();
            this.etxtPDFTitle = new System.Windows.Forms.TextBox();
            this.lblPDFTitle = new System.Windows.Forms.Label();
            this.btnClearTitle = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.chkHorizontal = new System.Windows.Forms.CheckBox();
            this.chkVertical = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AllowDrop = true;
            this.Display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Location = new System.Drawing.Point(14, 65);
            this.Display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display.Size = new System.Drawing.Size(748, 385);
            this.Display.TabIndex = 0;
            this.Display.DragDrop += new System.Windows.Forms.DragEventHandler(this.Display_DragDrop);
            this.Display.DragEnter += new System.Windows.Forms.DragEventHandler(this.Display_DragEnter);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Info;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(255, 459);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(254, 51);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // lblFileList
            // 
            this.lblFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileList.AutoSize = true;
            this.lblFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileList.Location = new System.Drawing.Point(304, 12);
            this.lblFileList.Name = "lblFileList";
            this.lblFileList.Size = new System.Drawing.Size(148, 36);
            this.lblFileList.TabIndex = 2;
            this.lblFileList.Text = "이미지 정렬";
            this.lblFileList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(611, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(151, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Drag and drop images";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.SystemColors.Window;
            this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInitialize.Location = new System.Drawing.Point(526, 459);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(80, 51);
            this.btnInitialize.TabIndex = 4;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.Initialize_Click);
            // 
            // chkMergePDF
            // 
            this.chkMergePDF.AutoSize = true;
            this.chkMergePDF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMergePDF.Enabled = false;
            this.chkMergePDF.Location = new System.Drawing.Point(614, 462);
            this.chkMergePDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMergePDF.Name = "chkMergePDF";
            this.chkMergePDF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMergePDF.Size = new System.Drawing.Size(102, 19);
            this.chkMergePDF.TabIndex = 5;
            this.chkMergePDF.Text = "Merge PDF";
            this.chkMergePDF.UseVisualStyleBackColor = true;
            this.chkMergePDF.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // etxtPDFTitle
            // 
            this.etxtPDFTitle.Location = new System.Drawing.Point(94, 460);
            this.etxtPDFTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.etxtPDFTitle.Name = "etxtPDFTitle";
            this.etxtPDFTitle.Size = new System.Drawing.Size(149, 25);
            this.etxtPDFTitle.TabIndex = 6;
            this.etxtPDFTitle.Click += new System.EventHandler(this.PDFTitle_TextChanged);
            // 
            // lblPDFTitle
            // 
            this.lblPDFTitle.AutoSize = true;
            this.lblPDFTitle.Location = new System.Drawing.Point(11, 464);
            this.lblPDFTitle.Name = "lblPDFTitle";
            this.lblPDFTitle.Size = new System.Drawing.Size(76, 15);
            this.lblPDFTitle.TabIndex = 7;
            this.lblPDFTitle.Text = "PDF Title :";
            // 
            // btnClearTitle
            // 
            this.btnClearTitle.Location = new System.Drawing.Point(119, 488);
            this.btnClearTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTitle.Name = "btnClearTitle";
            this.btnClearTitle.Size = new System.Drawing.Size(123, 22);
            this.btnClearTitle.TabIndex = 8;
            this.btnClearTitle.Text = "Clear Title";
            this.btnClearTitle.UseVisualStyleBackColor = true;
            this.btnClearTitle.Click += new System.EventHandler(this.btnClearTitle_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("굴림", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLanguage.Location = new System.Drawing.Point(14, 11);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(75, 28);
            this.btnLanguage.TabIndex = 10;
            this.btnLanguage.Text = "Language";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHelp.Location = new System.Drawing.Point(94, 12);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 26);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "사용 방법";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(185, 12);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(86, 26);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "제작 정보";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // chkHorizontal
            // 
            this.chkHorizontal.AutoSize = true;
            this.chkHorizontal.Checked = true;
            this.chkHorizontal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHorizontal.Enabled = false;
            this.chkHorizontal.Location = new System.Drawing.Point(614, 489);
            this.chkHorizontal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkHorizontal.Name = "chkHorizontal";
            this.chkHorizontal.Size = new System.Drawing.Size(60, 19);
            this.chkHorizontal.TabIndex = 13;
            this.chkHorizontal.Text = "Hori.";
            this.chkHorizontal.UseVisualStyleBackColor = true;
            this.chkHorizontal.CheckedChanged += new System.EventHandler(this.chkHorizontal_CheckedChanged);
            // 
            // chkVertical
            // 
            this.chkVertical.AutoSize = true;
            this.chkVertical.Enabled = false;
            this.chkVertical.Location = new System.Drawing.Point(678, 489);
            this.chkVertical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkVertical.Name = "chkVertical";
            this.chkVertical.Size = new System.Drawing.Size(58, 19);
            this.chkVertical.TabIndex = 14;
            this.chkVertical.Text = "Vert.";
            this.chkVertical.UseVisualStyleBackColor = true;
            this.chkVertical.CheckedChanged += new System.EventHandler(this.chkVertical_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(776, 520);
            this.Controls.Add(this.chkVertical);
            this.Controls.Add(this.chkHorizontal);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.btnClearTitle);
            this.Controls.Add(this.lblPDFTitle);
            this.Controls.Add(this.etxtPDFTitle);
            this.Controls.Add(this.chkMergePDF);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFileList);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.Display);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Image Piler ver0.11";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFileList;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.CheckBox chkMergePDF;
        private System.Windows.Forms.TextBox etxtPDFTitle;
        private System.Windows.Forms.Label lblPDFTitle;
        private System.Windows.Forms.Button btnClearTitle;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.CheckBox chkHorizontal;
        private System.Windows.Forms.CheckBox chkVertical;
    }
}


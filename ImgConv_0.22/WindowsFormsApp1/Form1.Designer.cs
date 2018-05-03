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
            this.chkCreateImages = new System.Windows.Forms.CheckBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Location = new System.Drawing.Point(12, 52);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display.Size = new System.Drawing.Size(653, 309);
            this.Display.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Info;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(223, 367);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(222, 41);
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
            this.lblFileList.Location = new System.Drawing.Point(281, 9);
            this.lblFileList.Name = "lblFileList";
            this.lblFileList.Size = new System.Drawing.Size(90, 29);
            this.lblFileList.TabIndex = 2;
            this.lblFileList.Text = "File list";
            this.lblFileList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(535, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(131, 12);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Drag and drop images";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.SystemColors.Window;
            this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInitialize.Location = new System.Drawing.Point(460, 367);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(70, 41);
            this.btnInitialize.TabIndex = 4;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.Initialize_Click);
            // 
            // chkMergePDF
            // 
            this.chkMergePDF.AutoSize = true;
            this.chkMergePDF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMergePDF.Checked = true;
            this.chkMergePDF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMergePDF.Location = new System.Drawing.Point(537, 370);
            this.chkMergePDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMergePDF.Name = "chkMergePDF";
            this.chkMergePDF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMergePDF.Size = new System.Drawing.Size(87, 16);
            this.chkMergePDF.TabIndex = 5;
            this.chkMergePDF.Text = "Merge PDF";
            this.chkMergePDF.UseVisualStyleBackColor = true;
            this.chkMergePDF.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // etxtPDFTitle
            // 
            this.etxtPDFTitle.Location = new System.Drawing.Point(82, 368);
            this.etxtPDFTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.etxtPDFTitle.Name = "etxtPDFTitle";
            this.etxtPDFTitle.Size = new System.Drawing.Size(131, 21);
            this.etxtPDFTitle.TabIndex = 6;
            this.etxtPDFTitle.Click += new System.EventHandler(this.PDFTitle_TextChanged);
            // 
            // lblPDFTitle
            // 
            this.lblPDFTitle.AutoSize = true;
            this.lblPDFTitle.Location = new System.Drawing.Point(10, 371);
            this.lblPDFTitle.Name = "lblPDFTitle";
            this.lblPDFTitle.Size = new System.Drawing.Size(64, 12);
            this.lblPDFTitle.TabIndex = 7;
            this.lblPDFTitle.Text = "PDF Title :";
            // 
            // btnClearTitle
            // 
            this.btnClearTitle.Location = new System.Drawing.Point(104, 390);
            this.btnClearTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTitle.Name = "btnClearTitle";
            this.btnClearTitle.Size = new System.Drawing.Size(108, 18);
            this.btnClearTitle.TabIndex = 8;
            this.btnClearTitle.Text = "Clear Title";
            this.btnClearTitle.UseVisualStyleBackColor = true;
            this.btnClearTitle.Click += new System.EventHandler(this.btnClearTitle_Click);
            // 
            // chkCreateImages
            // 
            this.chkCreateImages.AutoSize = true;
            this.chkCreateImages.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCreateImages.Checked = true;
            this.chkCreateImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateImages.Enabled = false;
            this.chkCreateImages.Location = new System.Drawing.Point(537, 390);
            this.chkCreateImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCreateImages.Name = "chkCreateImages";
            this.chkCreateImages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCreateImages.Size = new System.Drawing.Size(107, 16);
            this.chkCreateImages.TabIndex = 9;
            this.chkCreateImages.Text = "Create Images";
            this.chkCreateImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCreateImages.UseVisualStyleBackColor = true;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("굴림", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLanguage.Location = new System.Drawing.Point(12, 9);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(66, 22);
            this.btnLanguage.TabIndex = 10;
            this.btnLanguage.Text = "Language";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHelp.Location = new System.Drawing.Point(82, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(66, 21);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "사용 방법";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(152, 10);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 21);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "제작 정보";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 416);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.chkCreateImages);
            this.Controls.Add(this.btnClearTitle);
            this.Controls.Add(this.lblPDFTitle);
            this.Controls.Add(this.etxtPDFTitle);
            this.Controls.Add(this.chkMergePDF);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFileList);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.Display);
            this.Name = "MainWindow";
            this.Text = "Image Converter ver0.23";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
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
        private System.Windows.Forms.CheckBox chkCreateImages;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnInfo;
    }
}


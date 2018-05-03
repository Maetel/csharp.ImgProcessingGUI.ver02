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
            this.Convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Initialize = new System.Windows.Forms.Button();
            this.chkMergePDF = new System.Windows.Forms.CheckBox();
            this.PDFTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearTitle = new System.Windows.Forms.Button();
            this.chkCreateImages = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Location = new System.Drawing.Point(14, 65);
            this.Display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display.Size = new System.Drawing.Size(748, 385);
            this.Display.TabIndex = 0;
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.SystemColors.Info;
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(255, 459);
            this.Convert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(254, 51);
            this.Convert.TabIndex = 1;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "File list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(611, 27);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(151, 15);
            this.Status.TabIndex = 3;
            this.Status.Text = "Drag and drop images";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Initialize
            // 
            this.Initialize.BackColor = System.Drawing.SystemColors.Window;
            this.Initialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Initialize.Location = new System.Drawing.Point(526, 459);
            this.Initialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Initialize.Name = "Initialize";
            this.Initialize.Size = new System.Drawing.Size(80, 51);
            this.Initialize.TabIndex = 4;
            this.Initialize.Text = "Initialize";
            this.Initialize.UseVisualStyleBackColor = false;
            this.Initialize.Click += new System.EventHandler(this.Initialize_Click);
            // 
            // chkMergePDF
            // 
            this.chkMergePDF.AutoSize = true;
            this.chkMergePDF.Checked = true;
            this.chkMergePDF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMergePDF.Location = new System.Drawing.Point(660, 463);
            this.chkMergePDF.Name = "chkMergePDF";
            this.chkMergePDF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMergePDF.Size = new System.Drawing.Size(102, 19);
            this.chkMergePDF.TabIndex = 5;
            this.chkMergePDF.Text = "Merge PDF";
            this.chkMergePDF.UseVisualStyleBackColor = true;
            this.chkMergePDF.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PDFTitle
            // 
            this.PDFTitle.Location = new System.Drawing.Point(94, 460);
            this.PDFTitle.Name = "PDFTitle";
            this.PDFTitle.Size = new System.Drawing.Size(149, 25);
            this.PDFTitle.TabIndex = 6;
            this.PDFTitle.TextChanged += new System.EventHandler(this.PDFTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "PDF Title :";
            // 
            // btnClearTitle
            // 
            this.btnClearTitle.Location = new System.Drawing.Point(119, 487);
            this.btnClearTitle.Name = "btnClearTitle";
            this.btnClearTitle.Size = new System.Drawing.Size(124, 23);
            this.btnClearTitle.TabIndex = 8;
            this.btnClearTitle.Text = "Clear Title";
            this.btnClearTitle.UseVisualStyleBackColor = true;
            this.btnClearTitle.Click += new System.EventHandler(this.btnClearTitle_Click);
            // 
            // chkCreateImages
            // 
            this.chkCreateImages.AutoSize = true;
            this.chkCreateImages.Checked = true;
            this.chkCreateImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateImages.Location = new System.Drawing.Point(640, 487);
            this.chkCreateImages.Name = "chkCreateImages";
            this.chkCreateImages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCreateImages.Size = new System.Drawing.Size(122, 19);
            this.chkCreateImages.TabIndex = 9;
            this.chkCreateImages.Text = "Create Images";
            this.chkCreateImages.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 520);
            this.Controls.Add(this.chkCreateImages);
            this.Controls.Add(this.btnClearTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PDFTitle);
            this.Controls.Add(this.chkMergePDF);
            this.Controls.Add(this.Initialize);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Display);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Image Converter ver0.22";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button Initialize;
        private System.Windows.Forms.CheckBox chkMergePDF;
        private System.Windows.Forms.TextBox PDFTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearTitle;
        private System.Windows.Forms.CheckBox chkCreateImages;
    }
}


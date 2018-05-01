namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Display.Size = new System.Drawing.Size(655, 309);
            this.Display.TabIndex = 0;
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.SystemColors.Info;
            this.Convert.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(223, 367);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(222, 41);
            this.Convert.TabIndex = 1;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "File list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(536, 384);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(131, 12);
            this.Status.TabIndex = 3;
            this.Status.Text = "Drag and drop images";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Initialize
            // 
            this.Initialize.BackColor = System.Drawing.SystemColors.Window;
            this.Initialize.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 9F);
            this.Initialize.Location = new System.Drawing.Point(460, 367);
            this.Initialize.Name = "Initialize";
            this.Initialize.Size = new System.Drawing.Size(70, 41);
            this.Initialize.TabIndex = 4;
            this.Initialize.Text = "Initialize";
            this.Initialize.UseVisualStyleBackColor = false;
            this.Initialize.Click += new System.EventHandler(this.Initialize_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 416);
            this.Controls.Add(this.Initialize);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "ImageConverter ver0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}


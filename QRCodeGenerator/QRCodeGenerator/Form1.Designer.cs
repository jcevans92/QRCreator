namespace QRCodeGenerator
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.generate = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.QRImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QRImage)).BeginInit();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(65, 113);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(199, 30);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(65, 370);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(199, 23);
            this.download.TabIndex = 1;
            this.download.Text = "Download Image";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // QRImage
            // 
            this.QRImage.Location = new System.Drawing.Point(65, 149);
            this.QRImage.Name = "QRImage";
            this.QRImage.Size = new System.Drawing.Size(199, 215);
            this.QRImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.QRImage.TabIndex = 2;
            this.QRImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(65, 84);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(199, 20);
            this.url.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QRImage);
            this.Controls.Add(this.download);
            this.Controls.Add(this.generate);
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.QRImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.PictureBox QRImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label2;
    }
}


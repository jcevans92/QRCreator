// Written by Jeremy Evans
// February 3, 2015
// For capstone project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRCodeGenerator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string URL = url.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(URL);

            QRImage.Image = qrcode as Image;
        }

        private void download_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "PNG|* .png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if(s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                QRImage.Image.Save(s.FileName);
            }
        }
    }
}

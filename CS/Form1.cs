using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win.Base;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsApplication7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void OnGetImageBtnClick(object sender, EventArgs e) {
            MemoryStream stream = new MemoryStream();
            gControl.ExportToImage(stream, ImageFormat.Png);
            imgEdit.Image = Image.FromStream(stream);
        }
    }
}
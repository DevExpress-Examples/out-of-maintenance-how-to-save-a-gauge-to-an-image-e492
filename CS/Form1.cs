using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win.Base;

namespace WindowsApplication7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void OnGetImageBtnClick(object sender, EventArgs e) {
            int w = gControl.Width;
            int h = gControl.Height;
            imgEdit.Image = (gControl as IGaugeContainer).GetImage(w, h);
        }
    }
}
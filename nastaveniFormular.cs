using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsExcercise2 {
    public partial class nastaveniFormular : Form {
        public int nastaveniOdpocet;
        public string obrazekCesta;
        public nastaveniFormular() {
            InitializeComponent();            
        }
        private void tbOdpocet_KeyPress(object sender, KeyPressEventArgs e) {
            int znak = (char)e.KeyChar;
            if (znak < 48 || znak > 57) {
                e.Handled = true;
            }
        }
        private void btnVybratObr_Click(object sender, EventArgs e) {
            ofdObrazek.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdObrazek.Filter = "Images|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files|*.*";
            DialogResult result = ofdObrazek.ShowDialog();
            if (result == DialogResult.OK) {
                obrazekCesta = ofdObrazek.FileName;
                pictureBox1.ImageLocation = ofdObrazek.FileName;
            }
        }
        private void btnUlozit_Click(object sender, EventArgs e) {
            if (tbOdpocet.Text.Length != 0) {
                nastaveniOdpocet = Int32.Parse(tbOdpocet.Text);
            }
            //DialogResult dr = new DialogResult();
            this.Close();
        }
        private void btnStorno_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsExcercise2 {
    public partial class Formular : Form {
        public double odpocet;
        //{
        //    get { return odpocet; } 
        //    set { odpocet = value; }
        //}
        public int cas;
        public double odpocetOriginal;
        public string cesta = "";
        //public string popisekLabel1;
        public string varianta = "";
        public int soucetCheckboxu;
        public Formular() {
            //this.progressBar1.Maximum = cas;
            InitializeComponent();
        }
        public void Label1Zmena() {
            label1.Text = comboBox1.Text + " " + trackBar1.Value.ToString() + " kg " + varianta;            
        }
        public void Label2Zmena() {
            if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0) {
                label2.Text = "";
            } else {
                label2.Text = "Soucin: " + (numericUpDown1.Value * numericUpDown2.Value).ToString();
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            progressBar1.Maximum = cas;
            if (progressBar1.Value != progressBar1.Maximum) {
                progressBar1.Value++;
                odpocet = Math.Round(odpocet - 0.1, 2);
            }
            else {
                ////timer1.Stop();
                odpocet = 0.0;
            }
            ////label9.Text = progressBar1.Value.ToString();            
            toolStripStatusLabel1.Text = "Aktualni cas: " + DateTime.Now.ToString();
            label3.Text = String.Format(odpocet % 1 == 0 ? "{0:0.0}" : "{0:0.0}", odpocet) + " sekund";
        }
        private void novyToolStripMenuItem_Click(object sender, EventArgs e) {
            progressBar1.Value = 0;
            //timer1.Start();
            //odpocet = 10;
            odpocet = odpocetOriginal;
            textBox1.Text = "";
        }
        private void otevritToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult dr = openFileDialog1.ShowDialog();
            cesta = openFileDialog1.FileName;
            if (dr == DialogResult.OK) {
                StreamReader sr = new StreamReader(cesta);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        private void ulozitToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.FileName = cesta;
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) {
                // Code to write the stream goes here.
                StreamWriter writing = new StreamWriter(saveFileDialog1.FileName);
                writing.Write(textBox1.Text);
                writing.Close();
            }
        }
        private void konecToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            Label1Zmena();
        }
        private void comboBox1_TextUpdate(object sender, EventArgs e) {
            Label1Zmena();
            if (comboBox1.Text == "") {
                varianta = "";
                radioButton1.Checked= false;
                radioButton2.Checked= false;
                radioButton3.Checked= false;
                trackBar1.Value = 0;
                label1.Text = "";
            }
        }
        private void radioButton1_Click(object sender, EventArgs e) {
            varianta = ", " + radioButton1.Text;
            Label1Zmena();
        }
        private void radioButton2_Click(object sender, EventArgs e) {
            varianta = ", " + radioButton2.Text;
            Label1Zmena();
        }
        private void radioButton3_Click(object sender, EventArgs e) {
            varianta = ", " + radioButton3.Text;
            Label1Zmena();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            Label2Zmena();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            Label2Zmena();
        }
        private void buttonSmaz_Click(object sender, EventArgs e) {
            pictureBox1.Visible = false;
        }
        private void buttonZobraz_Click(object sender, EventArgs e) {
            pictureBox1.Visible = true;
        }
        private void checkCheck() {
            double avg;
            avg = Math.Round((double)soucetCheckboxu / 7 * 100,2);
            if (soucetCheckboxu == 0) {
                toolStripStatusLabel2.Text = "";
            }
            else {
                toolStripStatusLabel2.Text = "Pocet zatrzenych CheckBoxu: " + soucetCheckboxu.ToString() + ", to je " + avg.ToString() + "%";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked) {
                soucetCheckboxu++;
            }
            else {
                soucetCheckboxu--;
            }
            checkCheck();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked) {
                soucetCheckboxu++;
            }
            else {
                soucetCheckboxu--;
            }
            checkCheck();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked) {
                soucetCheckboxu++;
            }
            else {
                soucetCheckboxu--;
            }
            checkCheck();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked) {
                soucetCheckboxu++;
            }
            else {
                soucetCheckboxu--;
            }
            checkCheck();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked) {
                soucetCheckboxu++;
            }
            else {
                soucetCheckboxu--;
            }
            checkCheck();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked) {
                soucetCheckboxu++;
            }
            else {
                soucetCheckboxu--;
            }
            checkCheck();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked) {
                soucetCheckboxu++;
            }
            else {
                soucetCheckboxu--;
            }
            checkCheck();
        }

        private void napovedaToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Toto je napoveda k tomuto programu\n...\n...", "Napoveda");
        }

        private void nastaveniToolStripMenuItem_Click(object sender, EventArgs e) {
            nastaveniFormular nastaveni = new nastaveniFormular();
            nastaveni.ShowDialog();
        }
    }
}
// status strip checkl box counter
// nastaveni - novy formular s nastavenim doby odpoctu.
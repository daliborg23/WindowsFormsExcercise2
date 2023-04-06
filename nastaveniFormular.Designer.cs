namespace WindowsFormsExcercise2 {
    partial class nastaveniFormular {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCasovyOdpocet = new System.Windows.Forms.Label();
            this.tbOdpocet = new System.Windows.Forms.TextBox();
            this.lblObrazek = new System.Windows.Forms.Label();
            this.btnVybratObr = new System.Windows.Forms.Button();
            this.btnUlozit = new System.Windows.Forms.Button();
            this.btnStorno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofdObrazek = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCasovyOdpocet
            // 
            this.lblCasovyOdpocet.AutoSize = true;
            this.lblCasovyOdpocet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCasovyOdpocet.Location = new System.Drawing.Point(12, 9);
            this.lblCasovyOdpocet.Name = "lblCasovyOdpocet";
            this.lblCasovyOdpocet.Size = new System.Drawing.Size(130, 17);
            this.lblCasovyOdpocet.TabIndex = 0;
            this.lblCasovyOdpocet.Text = "Casovy odpocet (s)";
            // 
            // tbOdpocet
            // 
            this.tbOdpocet.Location = new System.Drawing.Point(148, 8);
            this.tbOdpocet.Name = "tbOdpocet";
            this.tbOdpocet.Size = new System.Drawing.Size(116, 20);
            this.tbOdpocet.TabIndex = 1;
            this.tbOdpocet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOdpocet_KeyPress);
            // 
            // lblObrazek
            // 
            this.lblObrazek.AutoSize = true;
            this.lblObrazek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObrazek.Location = new System.Drawing.Point(12, 67);
            this.lblObrazek.Name = "lblObrazek";
            this.lblObrazek.Size = new System.Drawing.Size(62, 17);
            this.lblObrazek.TabIndex = 2;
            this.lblObrazek.Text = "Obrazek";
            // 
            // btnVybratObr
            // 
            this.btnVybratObr.Location = new System.Drawing.Point(148, 64);
            this.btnVybratObr.Name = "btnVybratObr";
            this.btnVybratObr.Size = new System.Drawing.Size(116, 23);
            this.btnVybratObr.TabIndex = 3;
            this.btnVybratObr.Text = "Vybrat jiny obrazek";
            this.btnVybratObr.UseVisualStyleBackColor = true;
            this.btnVybratObr.Click += new System.EventHandler(this.btnVybratObr_Click);
            // 
            // btnUlozit
            // 
            this.btnUlozit.Location = new System.Drawing.Point(15, 318);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(100, 23);
            this.btnUlozit.TabIndex = 4;
            this.btnUlozit.Text = "Ulozit zmeny";
            this.btnUlozit.UseVisualStyleBackColor = true;
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStorno.Location = new System.Drawing.Point(164, 318);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(100, 23);
            this.btnStorno.TabIndex = 5;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsExcercise2.Properties.Resources.kym_mackinnon_cIRoqhoOIVM_unsplash;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(80, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // nastaveniFormular
            // 
            this.AcceptButton = this.btnUlozit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStorno;
            this.ClientSize = new System.Drawing.Size(279, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.btnVybratObr);
            this.Controls.Add(this.lblObrazek);
            this.Controls.Add(this.tbOdpocet);
            this.Controls.Add(this.lblCasovyOdpocet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nastaveniFormular";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nastaveni";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCasovyOdpocet;
        private System.Windows.Forms.TextBox tbOdpocet;
        private System.Windows.Forms.Label lblObrazek;
        private System.Windows.Forms.Button btnVybratObr;
        private System.Windows.Forms.Button btnUlozit;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofdObrazek;
    }
}
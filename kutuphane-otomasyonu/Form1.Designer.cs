using System.Drawing;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            personelAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            personelSifre = new TextBox();
            personelGiris = new Button();
            SuspendLayout();
            // 
            // personelAd
            // 
            personelAd.Location = new Point(415, 99);
            personelAd.Name = "personelAd";
            personelAd.Size = new Size(192, 27);
            personelAd.TabIndex = 0;
            personelAd.TextChanged += personelAd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(177, 99);
            label1.Name = "label1";
            label1.Size = new Size(161, 35);
            label1.TabIndex = 1;
            label1.Text = "Personel Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(177, 159);
            label2.Name = "label2";
            label2.Size = new Size(175, 35);
            label2.TabIndex = 2;
            label2.Text = "Personel Şifre";
            // 
            // personelSifre
            // 
            personelSifre.Location = new Point(415, 166);
            personelSifre.Name = "personelSifre";
            personelSifre.Size = new Size(192, 27);
            personelSifre.TabIndex = 3;
            personelSifre.TextChanged += personelSifre_TextChanged;
            // 
            // personelGiris
            // 
            personelGiris.BackColor = Color.Transparent;
            personelGiris.Location = new Point(415, 237);
            personelGiris.Name = "personelGiris";
            personelGiris.Size = new Size(192, 45);
            personelGiris.TabIndex = 4;
            personelGiris.Text = "Giriş";
            personelGiris.UseVisualStyleBackColor = false;
            personelGiris.Click += personelGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(866, 423);
            Controls.Add(personelGiris);
            Controls.Add(personelSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(personelAd);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox personelAd;
        private Label label1;
        private Label label2;
        private TextBox personelSifre;
        private Button personelGiris;
    }
}
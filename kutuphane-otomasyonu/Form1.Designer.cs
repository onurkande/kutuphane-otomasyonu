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
            this.personelAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personelSifre = new System.Windows.Forms.TextBox();
            this.personelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personelAd
            // 
            this.personelAd.Location = new System.Drawing.Point(415, 79);
            this.personelAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelAd.Name = "personelAd";
            this.personelAd.Size = new System.Drawing.Size(192, 22);
            this.personelAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(177, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(177, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Şifre";
            // 
            // personelSifre
            // 
            this.personelSifre.Location = new System.Drawing.Point(415, 133);
            this.personelSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelSifre.Name = "personelSifre";
            this.personelSifre.Size = new System.Drawing.Size(192, 22);
            this.personelSifre.TabIndex = 3;
            // 
            // personelGiris
            // 
            this.personelGiris.BackColor = System.Drawing.Color.Transparent;
            this.personelGiris.Location = new System.Drawing.Point(415, 190);
            this.personelGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personelGiris.Name = "personelGiris";
            this.personelGiris.Size = new System.Drawing.Size(192, 36);
            this.personelGiris.TabIndex = 4;
            this.personelGiris.Text = "Giriş";
            this.personelGiris.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 338);
            this.Controls.Add(this.personelGiris);
            this.Controls.Add(this.personelSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelAd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox personelAd;
        private Label label1;
        private Label label2;
        private TextBox personelSifre;
        private Button personelGiris;
    }
}
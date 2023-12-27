using System.Drawing;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    partial class IslemPaneli
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.silKullanicibtn = new System.Windows.Forms.Button();
            this.guncelleKullanicibtn = new System.Windows.Forms.Button();
            this.ekleKullanicibtn = new System.Windows.Forms.Button();
            this.kullaniciBilgiPaneli = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "kullanıcılar      ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.silKullanicibtn);
            this.panel1.Controls.Add(this.guncelleKullanicibtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 471);
            this.panel1.TabIndex = 0;
            // 
            // silKullanicibtn
            // 
            this.silKullanicibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.silKullanicibtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.silKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silKullanicibtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.silKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silKullanicibtn.Location = new System.Drawing.Point(0, 170);
            this.silKullanicibtn.Margin = new System.Windows.Forms.Padding(2);
            this.silKullanicibtn.Name = "silKullanicibtn";
            this.silKullanicibtn.Size = new System.Drawing.Size(188, 59);
            this.silKullanicibtn.TabIndex = 5;
            this.silKullanicibtn.Text = "kullanıcı sil    ";
            this.silKullanicibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.silKullanicibtn.UseVisualStyleBackColor = false;
            // 
            // guncelleKullanicibtn
            // 
            this.guncelleKullanicibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guncelleKullanicibtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guncelleKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleKullanicibtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guncelleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelleKullanicibtn.Location = new System.Drawing.Point(0, 113);
            this.guncelleKullanicibtn.Margin = new System.Windows.Forms.Padding(2);
            this.guncelleKullanicibtn.Name = "guncelleKullanicibtn";
            this.guncelleKullanicibtn.Size = new System.Drawing.Size(188, 59);
            this.guncelleKullanicibtn.TabIndex = 4;
            this.guncelleKullanicibtn.Text = "kullanıcı düzenle    ";
            this.guncelleKullanicibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guncelleKullanicibtn.UseVisualStyleBackColor = false;
            // 
            // ekleKullanicibtn
            // 
            this.ekleKullanicibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ekleKullanicibtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ekleKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleKullanicibtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ekleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleKullanicibtn.Location = new System.Drawing.Point(0, 57);
            this.ekleKullanicibtn.Margin = new System.Windows.Forms.Padding(2);
            this.ekleKullanicibtn.Name = "ekleKullanicibtn";
            this.ekleKullanicibtn.Size = new System.Drawing.Size(188, 59);
            this.ekleKullanicibtn.TabIndex = 3;
            this.ekleKullanicibtn.Text = "kullanıcı ekle    ";
            this.ekleKullanicibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekleKullanicibtn.UseVisualStyleBackColor = false;
            // 
            // kullaniciBilgiPaneli
            // 
            this.kullaniciBilgiPaneli.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.kullaniciBilgiPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPaneli.Location = new System.Drawing.Point(188, 0);
            this.kullaniciBilgiPaneli.Margin = new System.Windows.Forms.Padding(2);
            this.kullaniciBilgiPaneli.Name = "kullaniciBilgiPaneli";
            this.kullaniciBilgiPaneli.Size = new System.Drawing.Size(836, 59);
            this.kullaniciBilgiPaneli.TabIndex = 1;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 471);
            this.Controls.Add(this.kullaniciBilgiPaneli);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel kullaniciBilgiPaneli;
        private Button button1;
        private Button ekleKullanicibtn;
        private Button silKullanicibtn;
        private Button guncelleKullanicibtn;
    }
}
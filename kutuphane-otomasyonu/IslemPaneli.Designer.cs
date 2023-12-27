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
            Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            kullaniciBilgiPaneli = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Dock = DockStyle.Top;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 91);
            button1.TabIndex = 2;
            button1.Text = "kullanıcılar      ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 725);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.ForeColor = SystemColors.ControlText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 261);
            button4.Name = "button4";
            button4.Size = new Size(250, 91);
            button4.TabIndex = 5;
            button4.Text = "kullanıcı sil    ";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.ForeColor = SystemColors.ControlText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 174);
            button3.Name = "button3";
            button3.Size = new Size(250, 91);
            button3.TabIndex = 4;
            button3.Text = "kullanıcı düzenle    ";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.ForeColor = SystemColors.ControlText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 87);
            button2.Name = "button2";
            button2.Size = new Size(250, 91);
            button2.TabIndex = 3;
            button2.Text = "kullanıcı ekle    ";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // kullaniciBilgiPaneli
            // 
            kullaniciBilgiPaneli.BackColor = SystemColors.MenuHighlight;
            kullaniciBilgiPaneli.Dock = DockStyle.Top;
            kullaniciBilgiPaneli.Location = new Point(250, 0);
            kullaniciBilgiPaneli.Name = "kullaniciBilgiPaneli";
            kullaniciBilgiPaneli.Size = new Size(1115, 91);
            kullaniciBilgiPaneli.TabIndex = 1;
            kullaniciBilgiPaneli.Paint += panel2_Paint;
            // 
            // IslemPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 725);
            Controls.Add(kullaniciBilgiPaneli);
            Controls.Add(panel1);
            Name = "IslemPaneli";
            Text = "IslemPaneli";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel kullaniciBilgiPaneli;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
    }
}
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EvcilHayvan
{
    partial class UserRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            panel2 = new Panel();
            txtMail = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            LinkGiris = new LinkLabel();
            label1 = new Label();
            btnKayitOl = new Button();
            txtKad = new TextBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtMail);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LinkGiris);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnKayitOl);
            panel2.Controls.Add(txtKad);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(33, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 487);
            panel2.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.LightGray;
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(453, 224);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "E-mail";
            txtMail.Size = new Size(316, 37);
            txtMail.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(453, 301);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Şifre";
            txtPass.Size = new Size(316, 37);
            txtPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(519, 84);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 6;
            label2.Text = "Kullanıcı Kayıt";
            // 
            // LinkGiris
            // 
            LinkGiris.AutoSize = true;
            LinkGiris.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LinkGiris.Location = new Point(637, 427);
            LinkGiris.Name = "LinkGiris";
            LinkGiris.Size = new Size(63, 17);
            LinkGiris.TabIndex = 5;
            LinkGiris.TabStop = true;
            LinkGiris.Text = "Giriş Yap";
            LinkGiris.LinkClicked += LinkGiris_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(485, 427);
            label1.Name = "label1";
            label1.Size = new Size(145, 17);
            label1.TabIndex = 4;
            label1.Text = "Zaten Hesabın Var mı?";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(174, 130, 98);
            btnKayitOl.FlatStyle = FlatStyle.Popup;
            btnKayitOl.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(453, 363);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(296, 46);
            btnKayitOl.TabIndex = 3;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtKad
            // 
            txtKad.BackColor = Color.LightGray;
            txtKad.BorderStyle = BorderStyle.FixedSingle;
            txtKad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKad.Location = new Point(453, 156);
            txtKad.Multiline = true;
            txtKad.Name = "txtKad";
            txtKad.PlaceholderText = "Kullanıcı Adı";
            txtKad.Size = new Size(316, 37);
            txtKad.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(917, 556);
            Controls.Add(panel2);
            Name = "UserRegister";
            Text = "Kullanıcı Kayıt";
            Load += UserRegister_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private LinkLabel LinkGiris;
        private Label label1;
        private Button btnKayitOl;
        private PictureBox pictureBox1;
        private TextBox txtMail;
        private TextBox txtPass;
        private TextBox txtKad;
    }
}

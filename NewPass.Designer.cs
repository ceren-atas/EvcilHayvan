using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EvcilHayvan
{
    partial class NewPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPass));
            panel1 = new Panel();
            LinkGeriDon = new LinkLabel();
            btnReset = new Button();
            label2 = new Label();
            txtEposta = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(LinkGeriDon);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEposta);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 405);
            panel1.TabIndex = 0;
            // 
            // LinkGeriDon
            // 
            LinkGeriDon.AutoSize = true;
            LinkGeriDon.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LinkGeriDon.Location = new Point(203, 250);
            LinkGeriDon.Name = "LinkGeriDon";
            LinkGeriDon.Size = new Size(122, 19);
            LinkGeriDon.TabIndex = 5;
            LinkGeriDon.TabStop = true;
            LinkGeriDon.Text = "Giriş Ekranına Dön";
            LinkGeriDon.LinkClicked += LinkGeriDon_LinkClicked;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(106, 216, 213);
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(91, 311);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(214, 46);
            btnReset.TabIndex = 4;
            btnReset.Text = "E-posta Gönder";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 183);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 3;
            label2.Text = "E-posta adresinizi girin";
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.LightGray;
            txtEposta.BorderStyle = BorderStyle.FixedSingle;
            txtEposta.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEposta.Location = new Point(69, 205);
            txtEposta.Multiline = true;
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(256, 35);
            txtEposta.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 79);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Şifre Yenile";
            // 
            // NewPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(499, 497);
            Controls.Add(panel1);
            Name = "NewPass";
            Text = "NewPass";
            Load += NewPass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtEposta;
        private Button btnReset;
        private LinkLabel LinkGeriDon;
    }
}
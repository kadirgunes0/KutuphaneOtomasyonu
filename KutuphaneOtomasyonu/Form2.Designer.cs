namespace KutuphaneOtomasyonu
{
    partial class loginScreen
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
            this.ad_mail = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.kullanici_label = new System.Windows.Forms.Label();
            this.parola_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ogrenciButonGiris = new System.Windows.Forms.Button();
            this.yoneticiButonGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ad_mail
            // 
            this.ad_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_mail.Location = new System.Drawing.Point(77, 218);
            this.ad_mail.Name = "ad_mail";
            this.ad_mail.Size = new System.Drawing.Size(215, 26);
            this.ad_mail.TabIndex = 0;
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola.Location = new System.Drawing.Point(77, 279);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(215, 26);
            this.parola.TabIndex = 1;
            // 
            // kullanici_label
            // 
            this.kullanici_label.AutoSize = true;
            this.kullanici_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_label.Location = new System.Drawing.Point(74, 195);
            this.kullanici_label.Name = "kullanici_label";
            this.kullanici_label.Size = new System.Drawing.Size(165, 20);
            this.kullanici_label.TabIndex = 4;
            this.kullanici_label.Text = "Kullanıcı Adı veya mail:";
            // 
            // parola_label
            // 
            this.parola_label.AutoSize = true;
            this.parola_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola_label.Location = new System.Drawing.Point(74, 256);
            this.parola_label.Name = "parola_label";
            this.parola_label.Size = new System.Drawing.Size(58, 20);
            this.parola_label.TabIndex = 5;
            this.parola_label.Text = "Parola:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(186, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifrenizi mi unuttunuz?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ogrenciButonGiris
            // 
            this.ogrenciButonGiris.Location = new System.Drawing.Point(95, 28);
            this.ogrenciButonGiris.Name = "ogrenciButonGiris";
            this.ogrenciButonGiris.Size = new System.Drawing.Size(75, 23);
            this.ogrenciButonGiris.TabIndex = 10;
            this.ogrenciButonGiris.Text = "Öğrenci Giriş";
            this.ogrenciButonGiris.UseVisualStyleBackColor = true;
            this.ogrenciButonGiris.Click += new System.EventHandler(this.ogrenciButonGiris_Click);
            // 
            // yoneticiButonGiris
            // 
            this.yoneticiButonGiris.Location = new System.Drawing.Point(189, 28);
            this.yoneticiButonGiris.Name = "yoneticiButonGiris";
            this.yoneticiButonGiris.Size = new System.Drawing.Size(79, 23);
            this.yoneticiButonGiris.TabIndex = 11;
            this.yoneticiButonGiris.Text = "Yönetici Giriş";
            this.yoneticiButonGiris.UseVisualStyleBackColor = true;
            this.yoneticiButonGiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 548);
            this.Controls.Add(this.yoneticiButonGiris);
            this.Controls.Add(this.ogrenciButonGiris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parola_label);
            this.Controls.Add(this.kullanici_label);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.ad_mail);
            this.Name = "loginScreen";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad_mail;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Label kullanici_label;
        private System.Windows.Forms.Label parola_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ogrenciButonGiris;
        private System.Windows.Forms.Button yoneticiButonGiris;
    }
}
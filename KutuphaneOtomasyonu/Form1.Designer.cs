namespace KutuphaneOtomasyonu
{
    partial class anaMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kitap_adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kitap_yazari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kitap_yayinevi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yayin_yili = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewKitaplar = new System.Windows.Forms.ListView();
            this.kitapAl = new System.Windows.Forms.Button();
            this.kitapTeslim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kitap_adi
            // 
            this.kitap_adi.Text = "Kitap Adı";
            this.kitap_adi.Width = 138;
            // 
            // kitap_yazari
            // 
            this.kitap_yazari.Text = "Yazarı";
            this.kitap_yazari.Width = 139;
            // 
            // kitap_yayinevi
            // 
            this.kitap_yayinevi.Text = "Yayınevi";
            this.kitap_yayinevi.Width = 109;
            // 
            // yayin_yili
            // 
            this.yayin_yili.Text = "Tarih";
            this.yayin_yili.Width = 102;
            // 
            // isbn
            // 
            this.isbn.Text = "ISBN";
            this.isbn.Width = 102;
            // 
            // kategori
            // 
            this.kategori.Text = "Kategori";
            this.kategori.Width = 85;
            // 
            // listViewKitaplar
            // 
            this.listViewKitaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kitap_adi,
            this.kitap_yazari,
            this.kitap_yayinevi,
            this.yayin_yili,
            this.isbn,
            this.kategori});
            this.listViewKitaplar.FullRowSelect = true;
            this.listViewKitaplar.GridLines = true;
            this.listViewKitaplar.HideSelection = false;
            this.listViewKitaplar.Location = new System.Drawing.Point(12, 51);
            this.listViewKitaplar.Name = "listViewKitaplar";
            this.listViewKitaplar.Size = new System.Drawing.Size(801, 262);
            this.listViewKitaplar.TabIndex = 1;
            this.listViewKitaplar.UseCompatibleStateImageBehavior = false;
            this.listViewKitaplar.View = System.Windows.Forms.View.Details;
            this.listViewKitaplar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ciftClick);
            // 
            // kitapAl
            // 
            this.kitapAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAl.Location = new System.Drawing.Point(846, 51);
            this.kitapAl.Name = "kitapAl";
            this.kitapAl.Size = new System.Drawing.Size(130, 78);
            this.kitapAl.TabIndex = 2;
            this.kitapAl.Text = "Kitabı al";
            this.kitapAl.UseVisualStyleBackColor = true;
            this.kitapAl.Click += new System.EventHandler(this.kitapAl_Click);
            // 
            // kitapTeslim
            // 
            this.kitapTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapTeslim.Location = new System.Drawing.Point(846, 216);
            this.kitapTeslim.Name = "kitapTeslim";
            this.kitapTeslim.Size = new System.Drawing.Size(130, 78);
            this.kitapTeslim.TabIndex = 3;
            this.kitapTeslim.Text = "Kitabı teslim et";
            this.kitapTeslim.UseVisualStyleBackColor = true;
            this.kitapTeslim.Click += new System.EventHandler(this.kitapTeslim_Click);
            // 
            // anaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 691);
            this.Controls.Add(this.kitapTeslim);
            this.Controls.Add(this.kitapAl);
            this.Controls.Add(this.listViewKitaplar);
            this.Name = "anaMenu";
            this.Text = "anaMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader kitap_adi;
        private System.Windows.Forms.ColumnHeader kitap_yazari;
        private System.Windows.Forms.ColumnHeader kitap_yayinevi;
        private System.Windows.Forms.ColumnHeader yayin_yili;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.ColumnHeader kategori;
        private System.Windows.Forms.ListView listViewKitaplar;
        private System.Windows.Forms.Button kitapAl;
        private System.Windows.Forms.Button kitapTeslim;
    }
}


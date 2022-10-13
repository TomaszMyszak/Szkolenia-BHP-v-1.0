
namespace SzkoleniaBHP
{
    partial class szkoleniaBHP
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(szkoleniaBHP));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pracownicy = new System.Windows.Forms.Button();
            this.dodajFirmę = new System.Windows.Forms.Button();
            this.szkolenia = new System.Windows.Forms.Button();
            this.cennik = new System.Windows.Forms.Button();
            this.dataGridViewPowiazana = new System.Windows.Forms.DataGridView();
            this.napisPracownicy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridSzkolenia = new System.Windows.Forms.DataGridView();
            this.addFirm = new System.Windows.Forms.Button();
            this.odswierz = new System.Windows.Forms.Button();
            this.dodajPracownika = new System.Windows.Forms.Button();
            this.dodajSzkolenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPowiazana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSzkolenia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pracownicy
            // 
            this.pracownicy.Location = new System.Drawing.Point(1176, 28);
            this.pracownicy.Name = "pracownicy";
            this.pracownicy.Size = new System.Drawing.Size(230, 44);
            this.pracownicy.TabIndex = 1;
            this.pracownicy.Text = "pracownicy (raport)";
            this.pracownicy.UseVisualStyleBackColor = true;
            this.pracownicy.Click += new System.EventHandler(this.pracownicy_Click);
            // 
            // dodajFirmę
            // 
            this.dodajFirmę.Location = new System.Drawing.Point(1176, 128);
            this.dodajFirmę.Name = "dodajFirmę";
            this.dodajFirmę.Size = new System.Drawing.Size(230, 44);
            this.dodajFirmę.TabIndex = 5;
            this.dodajFirmę.Text = "modyfikuj dane";
            this.dodajFirmę.UseVisualStyleBackColor = true;
            // 
            // szkolenia
            // 
            this.szkolenia.Location = new System.Drawing.Point(1176, 78);
            this.szkolenia.Name = "szkolenia";
            this.szkolenia.Size = new System.Drawing.Size(230, 44);
            this.szkolenia.TabIndex = 7;
            this.szkolenia.Text = "szkolenia (raport)";
            this.szkolenia.UseVisualStyleBackColor = true;
            this.szkolenia.Click += new System.EventHandler(this.szkolenia_Click);
            // 
            // cennik
            // 
            this.cennik.Location = new System.Drawing.Point(1176, 178);
            this.cennik.Name = "cennik";
            this.cennik.Size = new System.Drawing.Size(230, 44);
            this.cennik.TabIndex = 10;
            this.cennik.Text = "cennik";
            this.cennik.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPowiazana
            // 
            this.dataGridViewPowiazana.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPowiazana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPowiazana.Location = new System.Drawing.Point(12, 315);
            this.dataGridViewPowiazana.Name = "dataGridViewPowiazana";
            this.dataGridViewPowiazana.Size = new System.Drawing.Size(1140, 309);
            this.dataGridViewPowiazana.TabIndex = 13;
            this.dataGridViewPowiazana.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPowiazana_CellClick);
            // 
            // napisPracownicy
            // 
            this.napisPracownicy.AutoSize = true;
            this.napisPracownicy.Cursor = System.Windows.Forms.Cursors.Default;
            this.napisPracownicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.napisPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napisPracownicy.Location = new System.Drawing.Point(12, 292);
            this.napisPracownicy.Name = "napisPracownicy";
            this.napisPracownicy.Size = new System.Drawing.Size(88, 20);
            this.napisPracownicy.TabIndex = 14;
            this.napisPracownicy.Text = "Pracownicy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firmy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SzkoleniaBHP.Properties.Resources.Ignis_logo_v1_1;
            this.pictureBox1.Location = new System.Drawing.Point(1181, 650);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Szkolenia";
            // 
            // dataGridSzkolenia
            // 
            this.dataGridSzkolenia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridSzkolenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSzkolenia.Location = new System.Drawing.Point(12, 650);
            this.dataGridSzkolenia.Name = "dataGridSzkolenia";
            this.dataGridSzkolenia.Size = new System.Drawing.Size(1140, 242);
            this.dataGridSzkolenia.TabIndex = 16;
            // 
            // addFirm
            // 
            this.addFirm.Location = new System.Drawing.Point(1181, 315);
            this.addFirm.Name = "addFirm";
            this.addFirm.Size = new System.Drawing.Size(230, 44);
            this.addFirm.TabIndex = 18;
            this.addFirm.Text = "Dodaj Firmę";
            this.addFirm.UseVisualStyleBackColor = true;
            this.addFirm.Click += new System.EventHandler(this.addFirm_Click);
            // 
            // odswierz
            // 
            this.odswierz.Location = new System.Drawing.Point(1176, 580);
            this.odswierz.Name = "odswierz";
            this.odswierz.Size = new System.Drawing.Size(230, 44);
            this.odswierz.TabIndex = 19;
            this.odswierz.Text = "odświerz";
            this.odswierz.UseVisualStyleBackColor = true;
            this.odswierz.Click += new System.EventHandler(this.odswierz_Click);
            // 
            // dodajPracownika
            // 
            this.dodajPracownika.Location = new System.Drawing.Point(1181, 375);
            this.dodajPracownika.Name = "dodajPracownika";
            this.dodajPracownika.Size = new System.Drawing.Size(230, 44);
            this.dodajPracownika.TabIndex = 20;
            this.dodajPracownika.Text = "Dodaj Pracownika";
            this.dodajPracownika.UseVisualStyleBackColor = true;
            this.dodajPracownika.Click += new System.EventHandler(this.dodajPracownika_Click);
            // 
            // dodajSzkolenie
            // 
            this.dodajSzkolenie.Location = new System.Drawing.Point(1181, 434);
            this.dodajSzkolenie.Name = "dodajSzkolenie";
            this.dodajSzkolenie.Size = new System.Drawing.Size(230, 44);
            this.dodajSzkolenie.TabIndex = 21;
            this.dodajSzkolenie.Text = "Dodaj Szkolenie";
            this.dodajSzkolenie.UseVisualStyleBackColor = true;
            this.dodajSzkolenie.Click += new System.EventHandler(this.dodajSzkolenie_Click);
            // 
            // szkoleniaBHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 904);
            this.Controls.Add(this.dodajSzkolenie);
            this.Controls.Add(this.dodajPracownika);
            this.Controls.Add(this.odswierz);
            this.Controls.Add(this.addFirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridSzkolenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.napisPracownicy);
            this.Controls.Add(this.dataGridViewPowiazana);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cennik);
            this.Controls.Add(this.szkolenia);
            this.Controls.Add(this.dodajFirmę);
            this.Controls.Add(this.pracownicy);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "szkoleniaBHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "szkolenia BHP";
            this.Load += new System.EventHandler(this.szkoleniaBHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPowiazana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSzkolenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pracownicy;
        private System.Windows.Forms.Button dodajFirmę;
        private System.Windows.Forms.Button szkolenia;
        private System.Windows.Forms.Button cennik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPowiazana;
        private System.Windows.Forms.Label napisPracownicy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridSzkolenia;
        private System.Windows.Forms.Button addFirm;
        private System.Windows.Forms.Button odswierz;
        private System.Windows.Forms.Button dodajPracownika;
        private System.Windows.Forms.Button dodajSzkolenie;
    }
}


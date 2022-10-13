
namespace SzkoleniaBHP
{
    partial class ListaPracowników
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPracowników));
            this.dataPracownicy = new System.Windows.Forms.DataGridView();
            this.labelSzkolenia = new System.Windows.Forms.Label();
            this.labelOceny = new System.Windows.Forms.Label();
            this.dataSzkolenia = new System.Windows.Forms.DataGridView();
            this.dataOceny = new System.Windows.Forms.DataGridView();
            this.dataKomisja = new System.Windows.Forms.DataGridView();
            this.labelKomisja = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.dodajSzkolenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSzkolenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOceny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKomisja)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPracownicy
            // 
            this.dataPracownicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPracownicy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPracownicy.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPracownicy.Location = new System.Drawing.Point(12, 12);
            this.dataPracownicy.Name = "dataPracownicy";
            this.dataPracownicy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataPracownicy.Size = new System.Drawing.Size(617, 644);
            this.dataPracownicy.TabIndex = 0;
            this.dataPracownicy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPracownicy_CellClick);
            this.dataPracownicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPracownicy_CellContentClick);
            // 
            // labelSzkolenia
            // 
            this.labelSzkolenia.AutoSize = true;
            this.labelSzkolenia.Font = new System.Drawing.Font("Siemens AD Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzkolenia.Location = new System.Drawing.Point(641, 10);
            this.labelSzkolenia.Name = "labelSzkolenia";
            this.labelSzkolenia.Size = new System.Drawing.Size(60, 13);
            this.labelSzkolenia.TabIndex = 1;
            this.labelSzkolenia.Text = "Szkolenia: ";
            // 
            // labelOceny
            // 
            this.labelOceny.AutoSize = true;
            this.labelOceny.Font = new System.Drawing.Font("Siemens AD Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOceny.Location = new System.Drawing.Point(641, 217);
            this.labelOceny.Name = "labelOceny";
            this.labelOceny.Size = new System.Drawing.Size(40, 13);
            this.labelOceny.TabIndex = 2;
            this.labelOceny.Text = "Oceny:";
            // 
            // dataSzkolenia
            // 
            this.dataSzkolenia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSzkolenia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataSzkolenia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataSzkolenia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataSzkolenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSzkolenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSzkolenia.Location = new System.Drawing.Point(644, 26);
            this.dataSzkolenia.Name = "dataSzkolenia";
            this.dataSzkolenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataSzkolenia.Size = new System.Drawing.Size(321, 155);
            this.dataSzkolenia.TabIndex = 3;
            // 
            // dataOceny
            // 
            this.dataOceny.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataOceny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOceny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOceny.Location = new System.Drawing.Point(644, 233);
            this.dataOceny.Name = "dataOceny";
            this.dataOceny.Size = new System.Drawing.Size(294, 92);
            this.dataOceny.TabIndex = 4;
            // 
            // dataKomisja
            // 
            this.dataKomisja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataKomisja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataKomisja.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataKomisja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKomisja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKomisja.Location = new System.Drawing.Point(644, 417);
            this.dataKomisja.Name = "dataKomisja";
            this.dataKomisja.Size = new System.Drawing.Size(294, 92);
            this.dataKomisja.TabIndex = 5;
            // 
            // labelKomisja
            // 
            this.labelKomisja.AutoSize = true;
            this.labelKomisja.Font = new System.Drawing.Font("Siemens AD Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKomisja.Location = new System.Drawing.Point(641, 401);
            this.labelKomisja.Name = "labelKomisja";
            this.labelKomisja.Size = new System.Drawing.Size(49, 13);
            this.labelKomisja.TabIndex = 6;
            this.labelKomisja.Text = "Komisja:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dodajSzkolenie
            // 
            this.dodajSzkolenie.Location = new System.Drawing.Point(644, 599);
            this.dodajSzkolenie.Name = "dodajSzkolenie";
            this.dodajSzkolenie.Size = new System.Drawing.Size(321, 57);
            this.dodajSzkolenie.TabIndex = 7;
            this.dodajSzkolenie.Text = "button1";
            this.dodajSzkolenie.UseVisualStyleBackColor = true;
            this.dodajSzkolenie.Click += new System.EventHandler(this.dodajSzkolenie_Click);
            // 
            // ListaPracowników
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1006, 668);
            this.Controls.Add(this.dodajSzkolenie);
            this.Controls.Add(this.labelKomisja);
            this.Controls.Add(this.dataKomisja);
            this.Controls.Add(this.dataOceny);
            this.Controls.Add(this.dataSzkolenia);
            this.Controls.Add(this.labelOceny);
            this.Controls.Add(this.labelSzkolenia);
            this.Controls.Add(this.dataPracownicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaPracowników";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaPracowników";
            this.Load += new System.EventHandler(this.ListaPracowników_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSzkolenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOceny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKomisja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPracownicy;
        private System.Windows.Forms.Label labelSzkolenia;
        private System.Windows.Forms.Label labelOceny;
        private System.Windows.Forms.DataGridView dataSzkolenia;
        private System.Windows.Forms.DataGridView dataOceny;
        private System.Windows.Forms.Label labelKomisja;
        private System.Windows.Forms.DataGridView dataKomisja;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button dodajSzkolenie;
    }
}
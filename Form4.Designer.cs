
namespace SzkoleniaBHP
{
    partial class listaSzkolen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaSzkolen));
            this.dataSzkolenia = new System.Windows.Forms.DataGridView();
            this.addSzkol = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.dtDateSzkolenia = new System.Windows.Forms.DateTimePicker();
            this.dateShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSzkolenia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSzkolenia
            // 
            this.dataSzkolenia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSzkolenia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataSzkolenia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataSzkolenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSzkolenia.Location = new System.Drawing.Point(12, 49);
            this.dataSzkolenia.Name = "dataSzkolenia";
            this.dataSzkolenia.Size = new System.Drawing.Size(1045, 482);
            this.dataSzkolenia.TabIndex = 0;
            this.dataSzkolenia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataSzkolenia_CellMouseDoubleClick);
            // 
            // addSzkol
            // 
            this.addSzkol.Location = new System.Drawing.Point(12, 551);
            this.addSzkol.Name = "addSzkol";
            this.addSzkol.Size = new System.Drawing.Size(118, 91);
            this.addSzkol.TabIndex = 1;
            this.addSzkol.Text = "dodaj szkolenie";
            this.addSzkol.UseVisualStyleBackColor = true;
            this.addSzkol.Click += new System.EventHandler(this.addSzkol_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(156, 551);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(118, 91);
            this.print.TabIndex = 2;
            this.print.Text = "Drukuj";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // dtDateSzkolenia
            // 
            this.dtDateSzkolenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateSzkolenia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDateSzkolenia.Location = new System.Drawing.Point(12, 12);
            this.dtDateSzkolenia.Name = "dtDateSzkolenia";
            this.dtDateSzkolenia.Size = new System.Drawing.Size(102, 20);
            this.dtDateSzkolenia.TabIndex = 3;
            this.dtDateSzkolenia.Value = new System.DateTime(2021, 8, 20, 15, 19, 23, 0);
            // 
            // dateShow
            // 
            this.dateShow.Location = new System.Drawing.Point(120, 9);
            this.dateShow.Name = "dateShow";
            this.dateShow.Size = new System.Drawing.Size(75, 23);
            this.dateShow.TabIndex = 4;
            this.dateShow.Text = "pokaż";
            this.dateShow.UseVisualStyleBackColor = true;
            this.dateShow.Click += new System.EventHandler(this.dateShow_Click);
            // 
            // listaSzkolen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1069, 654);
            this.Controls.Add(this.dateShow);
            this.Controls.Add(this.dtDateSzkolenia);
            this.Controls.Add(this.print);
            this.Controls.Add(this.addSzkol);
            this.Controls.Add(this.dataSzkolenia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listaSzkolen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szkolenia Raport";
            ((System.ComponentModel.ISupportInitialize)(this.dataSzkolenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSzkolenia;
        private System.Windows.Forms.Button addSzkol;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.DateTimePicker dtDateSzkolenia;
        private System.Windows.Forms.Button dateShow;
    }
}
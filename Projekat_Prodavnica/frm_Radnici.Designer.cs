namespace Projekat_Prodavnica
{
    partial class frm_Radnici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Radnici));
            this.dataGrid_Radnici = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_radinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesecna_Zarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texIme_Prezime_Radnika = new System.Windows.Forms.TextBox();
            this.textJMBG = new System.Windows.Forms.TextBox();
            this.textKor_Ime = new System.Windows.Forms.TextBox();
            this.textLozinka = new System.Windows.Forms.TextBox();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.textMesecna_Zarada = new System.Windows.Forms.TextBox();
            this.cmbVrsta_Radnika = new System.Windows.Forms.ComboBox();
            this.textPretraga_JMBG = new System.Windows.Forms.TextBox();
            this.btnUcitaj_Radnika = new System.Windows.Forms.Button();
            this.btn_Pretrazi_Radnika = new System.Windows.Forms.Button();
            this.btnNovi_Radnik = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Radnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Radnici
            // 
            this.dataGrid_Radnici.AllowUserToAddRows = false;
            this.dataGrid_Radnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Radnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Radnici.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Radnici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Radnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Radnici.ColumnHeadersHeight = 50;
            this.dataGrid_Radnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Radnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.ime_prezime,
            this.JMBG,
            this.v_radinka,
            this.k_ime,
            this.lozinka,
            this.adresa,
            this.Mesecna_Zarada,
            this.Edit_Radnika,
            this.Delete_Radnika});
            this.dataGrid_Radnici.EnableHeadersVisualStyles = false;
            this.dataGrid_Radnici.Location = new System.Drawing.Point(-3, 188);
            this.dataGrid_Radnici.MultiSelect = false;
            this.dataGrid_Radnici.Name = "dataGrid_Radnici";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Radnici.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Radnici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Radnici.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Radnici.RowTemplate.Height = 25;
            this.dataGrid_Radnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Radnici.Size = new System.Drawing.Size(804, 224);
            this.dataGrid_Radnici.TabIndex = 85;
            this.dataGrid_Radnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Radnici_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ime_prezime
            // 
            this.ime_prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ime_prezime.HeaderText = "Ime i Prezime";
            this.ime_prezime.Name = "ime_prezime";
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.Width = 64;
            // 
            // v_radinka
            // 
            this.v_radinka.HeaderText = "Vrsta Radnika";
            this.v_radinka.Name = "v_radinka";
            // 
            // k_ime
            // 
            this.k_ime.HeaderText = "Kor. Ime";
            this.k_ime.Name = "k_ime";
            // 
            // lozinka
            // 
            this.lozinka.HeaderText = "Lozinka";
            this.lozinka.Name = "lozinka";
            // 
            // adresa
            // 
            this.adresa.HeaderText = "Adresa";
            this.adresa.Name = "adresa";
            // 
            // Mesecna_Zarada
            // 
            this.Mesecna_Zarada.HeaderText = "Mesecna Zarada";
            this.Mesecna_Zarada.Name = "Mesecna_Zarada";
            // 
            // Edit_Radnika
            // 
            this.Edit_Radnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit_Radnika.HeaderText = "";
            this.Edit_Radnika.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Radnika.Image")));
            this.Edit_Radnika.Name = "Edit_Radnika";
            this.Edit_Radnika.Width = 5;
            // 
            // Delete_Radnika
            // 
            this.Delete_Radnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete_Radnika.HeaderText = "";
            this.Delete_Radnika.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Radnika.Image")));
            this.Delete_Radnika.Name = "Delete_Radnika";
            this.Delete_Radnika.Width = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 86;
            this.label1.Text = "Ime i Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 87;
            this.label2.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 88;
            this.label3.Text = "Vrsta Radnika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 89;
            this.label4.Text = "Kor. Ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 90;
            this.label5.Text = "Lozinka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 91;
            this.label6.Text = "Adresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 92;
            this.label7.Text = "Mesecna Zarada";
            // 
            // texIme_Prezime_Radnika
            // 
            this.texIme_Prezime_Radnika.Location = new System.Drawing.Point(128, 18);
            this.texIme_Prezime_Radnika.Name = "texIme_Prezime_Radnika";
            this.texIme_Prezime_Radnika.Size = new System.Drawing.Size(153, 23);
            this.texIme_Prezime_Radnika.TabIndex = 93;
            // 
            // textJMBG
            // 
            this.textJMBG.Location = new System.Drawing.Point(128, 53);
            this.textJMBG.Name = "textJMBG";
            this.textJMBG.Size = new System.Drawing.Size(153, 23);
            this.textJMBG.TabIndex = 94;
            // 
            // textKor_Ime
            // 
            this.textKor_Ime.Location = new System.Drawing.Point(382, 18);
            this.textKor_Ime.Name = "textKor_Ime";
            this.textKor_Ime.Size = new System.Drawing.Size(153, 23);
            this.textKor_Ime.TabIndex = 95;
            // 
            // textLozinka
            // 
            this.textLozinka.Location = new System.Drawing.Point(382, 53);
            this.textLozinka.Name = "textLozinka";
            this.textLozinka.Size = new System.Drawing.Size(153, 23);
            this.textLozinka.TabIndex = 96;
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(382, 85);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(153, 23);
            this.textAdresa.TabIndex = 97;
            // 
            // textMesecna_Zarada
            // 
            this.textMesecna_Zarada.Location = new System.Drawing.Point(128, 118);
            this.textMesecna_Zarada.Name = "textMesecna_Zarada";
            this.textMesecna_Zarada.Size = new System.Drawing.Size(116, 23);
            this.textMesecna_Zarada.TabIndex = 98;
            // 
            // cmbVrsta_Radnika
            // 
            this.cmbVrsta_Radnika.FormattingEnabled = true;
            this.cmbVrsta_Radnika.Location = new System.Drawing.Point(128, 85);
            this.cmbVrsta_Radnika.Name = "cmbVrsta_Radnika";
            this.cmbVrsta_Radnika.Size = new System.Drawing.Size(153, 23);
            this.cmbVrsta_Radnika.TabIndex = 99;
            // 
            // textPretraga_JMBG
            // 
            this.textPretraga_JMBG.Location = new System.Drawing.Point(128, 159);
            this.textPretraga_JMBG.Name = "textPretraga_JMBG";
            this.textPretraga_JMBG.PlaceholderText = "Pretraga po JMBG";
            this.textPretraga_JMBG.Size = new System.Drawing.Size(153, 23);
            this.textPretraga_JMBG.TabIndex = 100;
            // 
            // btnUcitaj_Radnika
            // 
            this.btnUcitaj_Radnika.Location = new System.Drawing.Point(28, 159);
            this.btnUcitaj_Radnika.Name = "btnUcitaj_Radnika";
            this.btnUcitaj_Radnika.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj_Radnika.TabIndex = 101;
            this.btnUcitaj_Radnika.Text = "Ucitaj";
            this.btnUcitaj_Radnika.UseVisualStyleBackColor = true;
            this.btnUcitaj_Radnika.Click += new System.EventHandler(this.btnUcitaj_Radnika_Click);
            // 
            // btn_Pretrazi_Radnika
            // 
            this.btn_Pretrazi_Radnika.Location = new System.Drawing.Point(296, 159);
            this.btn_Pretrazi_Radnika.Name = "btn_Pretrazi_Radnika";
            this.btn_Pretrazi_Radnika.Size = new System.Drawing.Size(89, 23);
            this.btn_Pretrazi_Radnika.TabIndex = 102;
            this.btn_Pretrazi_Radnika.Text = "Pretrazi";
            this.btn_Pretrazi_Radnika.UseVisualStyleBackColor = true;
            this.btn_Pretrazi_Radnika.Click += new System.EventHandler(this.btn_Pretrazi_Radnika_Click);
            // 
            // btnNovi_Radnik
            // 
            this.btnNovi_Radnik.Location = new System.Drawing.Point(391, 159);
            this.btnNovi_Radnik.Name = "btnNovi_Radnik";
            this.btnNovi_Radnik.Size = new System.Drawing.Size(75, 23);
            this.btnNovi_Radnik.TabIndex = 103;
            this.btnNovi_Radnik.Text = "Dodaj";
            this.btnNovi_Radnik.UseVisualStyleBackColor = true;
            this.btnNovi_Radnik.Click += new System.EventHandler(this.btnNovi_Radnik_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(472, 158);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 104;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // frm_Radnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnNovi_Radnik);
            this.Controls.Add(this.btn_Pretrazi_Radnika);
            this.Controls.Add(this.btnUcitaj_Radnika);
            this.Controls.Add(this.textPretraga_JMBG);
            this.Controls.Add(this.cmbVrsta_Radnika);
            this.Controls.Add(this.textMesecna_Zarada);
            this.Controls.Add(this.textAdresa);
            this.Controls.Add(this.textLozinka);
            this.Controls.Add(this.textKor_Ime);
            this.Controls.Add(this.textJMBG);
            this.Controls.Add(this.texIme_Prezime_Radnika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Radnici);
            this.Name = "frm_Radnici";
            this.Text = "frm_Radnici";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Radnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dataGrid_Radnici;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox texIme_Prezime_Radnika;
        private TextBox textJMBG;
        private TextBox textKor_Ime;
        private TextBox textLozinka;
        private TextBox textAdresa;
        private TextBox textMesecna_Zarada;
        private ComboBox cmbVrsta_Radnika;
        private TextBox textPretraga_JMBG;
        private Button btnUcitaj_Radnika;
        private Button btn_Pretrazi_Radnika;
        private Button btnNovi_Radnik;
        private Button btnIzmeni;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ime_prezime;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn v_radinka;
        private DataGridViewTextBoxColumn k_ime;
        private DataGridViewTextBoxColumn lozinka;
        private DataGridViewTextBoxColumn adresa;
        private DataGridViewTextBoxColumn Mesecna_Zarada;
        private DataGridViewImageColumn Edit_Radnika;
        private DataGridViewImageColumn Delete_Radnika;
    }
}
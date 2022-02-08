namespace Projekat_Prodavnica
{
    partial class frm_Artikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Artikli));
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNovi_Radnik = new System.Windows.Forms.Button();
            this.btn_Pretrazi_Radnika = new System.Windows.Forms.Button();
            this.btnUcitaj_Radnika = new System.Windows.Forms.Button();
            this.textPretraga_Sifra = new System.Windows.Forms.TextBox();
            this.cmbJedinica_Mere = new System.Windows.Forms.ComboBox();
            this.textBarkod = new System.Windows.Forms.TextBox();
            this.textNaziv_Artikla = new System.Windows.Forms.TextBox();
            this.textSifra_Artikla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Artikli = new System.Windows.Forms.DataGridView();
            this.cmbVrsta_Artikla = new System.Windows.Forms.ComboBox();
            this.cmbStopa_Poreska = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv_PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_radinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Artikal = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Artikal = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Artikli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(472, 164);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 142;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNovi_Radnik
            // 
            this.btnNovi_Radnik.Location = new System.Drawing.Point(391, 165);
            this.btnNovi_Radnik.Name = "btnNovi_Radnik";
            this.btnNovi_Radnik.Size = new System.Drawing.Size(75, 23);
            this.btnNovi_Radnik.TabIndex = 141;
            this.btnNovi_Radnik.Text = "Dodaj";
            this.btnNovi_Radnik.UseVisualStyleBackColor = true;
            this.btnNovi_Radnik.Click += new System.EventHandler(this.btnNovi_Radnik_Click);
            // 
            // btn_Pretrazi_Radnika
            // 
            this.btn_Pretrazi_Radnika.Location = new System.Drawing.Point(296, 165);
            this.btn_Pretrazi_Radnika.Name = "btn_Pretrazi_Radnika";
            this.btn_Pretrazi_Radnika.Size = new System.Drawing.Size(89, 23);
            this.btn_Pretrazi_Radnika.TabIndex = 140;
            this.btn_Pretrazi_Radnika.Text = "Pretrazi";
            this.btn_Pretrazi_Radnika.UseVisualStyleBackColor = true;
            this.btn_Pretrazi_Radnika.Click += new System.EventHandler(this.btn_Pretrazi_Radnika_Click);
            // 
            // btnUcitaj_Radnika
            // 
            this.btnUcitaj_Radnika.Location = new System.Drawing.Point(28, 165);
            this.btnUcitaj_Radnika.Name = "btnUcitaj_Radnika";
            this.btnUcitaj_Radnika.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj_Radnika.TabIndex = 139;
            this.btnUcitaj_Radnika.Text = "Ucitaj";
            this.btnUcitaj_Radnika.UseVisualStyleBackColor = true;
            this.btnUcitaj_Radnika.Click += new System.EventHandler(this.btnUcitaj_Radnika_Click);
            // 
            // textPretraga_Sifra
            // 
            this.textPretraga_Sifra.Location = new System.Drawing.Point(128, 165);
            this.textPretraga_Sifra.Name = "textPretraga_Sifra";
            this.textPretraga_Sifra.PlaceholderText = "Pretraga po nazivu ili sifri";
            this.textPretraga_Sifra.Size = new System.Drawing.Size(153, 23);
            this.textPretraga_Sifra.TabIndex = 138;
            // 
            // cmbJedinica_Mere
            // 
            this.cmbJedinica_Mere.FormattingEnabled = true;
            this.cmbJedinica_Mere.Location = new System.Drawing.Point(376, 27);
            this.cmbJedinica_Mere.Name = "cmbJedinica_Mere";
            this.cmbJedinica_Mere.Size = new System.Drawing.Size(72, 23);
            this.cmbJedinica_Mere.TabIndex = 137;
            // 
            // textBarkod
            // 
            this.textBarkod.Location = new System.Drawing.Point(602, 59);
            this.textBarkod.Name = "textBarkod";
            this.textBarkod.Size = new System.Drawing.Size(153, 23);
            this.textBarkod.TabIndex = 134;
            // 
            // textNaziv_Artikla
            // 
            this.textNaziv_Artikla.Location = new System.Drawing.Point(119, 59);
            this.textNaziv_Artikla.Name = "textNaziv_Artikla";
            this.textNaziv_Artikla.Size = new System.Drawing.Size(153, 23);
            this.textNaziv_Artikla.TabIndex = 133;
            // 
            // textSifra_Artikla
            // 
            this.textSifra_Artikla.Location = new System.Drawing.Point(119, 27);
            this.textSifra_Artikla.Name = "textSifra_Artikla";
            this.textSifra_Artikla.Size = new System.Drawing.Size(153, 23);
            this.textSifra_Artikla.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 131;
            this.label6.Text = "Barkod:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 130;
            this.label5.Text = "Stopa (%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 129;
            this.label4.Text = "Vrsta Artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 128;
            this.label3.Text = "Jedinica Mere:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 127;
            this.label2.Text = "Naziv Artikla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 126;
            this.label1.Text = "Sfra Artikla:";
            // 
            // dataGrid_Artikli
            // 
            this.dataGrid_Artikli.AllowUserToAddRows = false;
            this.dataGrid_Artikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Artikli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Artikli.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Artikli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Artikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Artikli.ColumnHeadersHeight = 50;
            this.dataGrid_Artikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Artikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.Naziv_PP,
            this.JMBG,
            this.v_radinka,
            this.k_ime,
            this.lozinka,
            this.adresa,
            this.Edit_Artikal,
            this.Delete_Artikal});
            this.dataGrid_Artikli.EnableHeadersVisualStyles = false;
            this.dataGrid_Artikli.Location = new System.Drawing.Point(-3, 194);
            this.dataGrid_Artikli.MultiSelect = false;
            this.dataGrid_Artikli.Name = "dataGrid_Artikli";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Artikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Artikli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Artikli.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Artikli.RowTemplate.Height = 25;
            this.dataGrid_Artikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Artikli.Size = new System.Drawing.Size(804, 224);
            this.dataGrid_Artikli.TabIndex = 125;
            this.dataGrid_Artikli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Artikli_CellContentClick);
            // 
            // cmbVrsta_Artikla
            // 
            this.cmbVrsta_Artikla.FormattingEnabled = true;
            this.cmbVrsta_Artikla.Location = new System.Drawing.Point(376, 59);
            this.cmbVrsta_Artikla.Name = "cmbVrsta_Artikla";
            this.cmbVrsta_Artikla.Size = new System.Drawing.Size(139, 23);
            this.cmbVrsta_Artikla.TabIndex = 143;
            // 
            // cmbStopa_Poreska
            // 
            this.cmbStopa_Poreska.FormattingEnabled = true;
            this.cmbStopa_Poreska.Location = new System.Drawing.Point(602, 27);
            this.cmbStopa_Poreska.Name = "cmbStopa_Poreska";
            this.cmbStopa_Poreska.Size = new System.Drawing.Size(104, 23);
            this.cmbStopa_Poreska.TabIndex = 144;
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
            // Naziv_PP
            // 
            this.Naziv_PP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Naziv_PP.HeaderText = "Sifra Artikla";
            this.Naziv_PP.Name = "Naziv_PP";
            this.Naziv_PP.Width = 89;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JMBG.HeaderText = "Naziv Artikla";
            this.JMBG.Name = "JMBG";
            this.JMBG.Width = 95;
            // 
            // v_radinka
            // 
            this.v_radinka.HeaderText = "Jed. Mere";
            this.v_radinka.Name = "v_radinka";
            // 
            // k_ime
            // 
            this.k_ime.HeaderText = "Stopa (%)";
            this.k_ime.Name = "k_ime";
            // 
            // lozinka
            // 
            this.lozinka.HeaderText = "Vrsta Artikla";
            this.lozinka.Name = "lozinka";
            // 
            // adresa
            // 
            this.adresa.HeaderText = "Barkod";
            this.adresa.Name = "adresa";
            // 
            // Edit_Artikal
            // 
            this.Edit_Artikal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit_Artikal.HeaderText = "";
            this.Edit_Artikal.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Artikal.Image")));
            this.Edit_Artikal.Name = "Edit_Artikal";
            this.Edit_Artikal.Width = 5;
            // 
            // Delete_Artikal
            // 
            this.Delete_Artikal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete_Artikal.HeaderText = "";
            this.Delete_Artikal.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Artikal.Image")));
            this.Delete_Artikal.Name = "Delete_Artikal";
            this.Delete_Artikal.Width = 5;
            // 
            // frm_Artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.cmbStopa_Poreska);
            this.Controls.Add(this.cmbVrsta_Artikla);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnNovi_Radnik);
            this.Controls.Add(this.btn_Pretrazi_Radnika);
            this.Controls.Add(this.btnUcitaj_Radnika);
            this.Controls.Add(this.textPretraga_Sifra);
            this.Controls.Add(this.cmbJedinica_Mere);
            this.Controls.Add(this.textBarkod);
            this.Controls.Add(this.textNaziv_Artikla);
            this.Controls.Add(this.textSifra_Artikla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Artikli);
            this.Name = "frm_Artikli";
            this.Text = "frm_Artikli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Artikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIzmeni;
        private Button btnNovi_Radnik;
        private Button btn_Pretrazi_Radnika;
        private Button btnUcitaj_Radnika;
        private TextBox textPretraga_Sifra;
        private ComboBox cmbJedinica_Mere;
        private TextBox textBarkod;
        private TextBox textNaziv_Artikla;
        private TextBox textSifra_Artikla;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public DataGridView dataGrid_Artikli;
        private ComboBox cmbVrsta_Artikla;
        private ComboBox cmbStopa_Poreska;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Naziv_PP;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn v_radinka;
        private DataGridViewTextBoxColumn k_ime;
        private DataGridViewTextBoxColumn lozinka;
        private DataGridViewTextBoxColumn adresa;
        private DataGridViewImageColumn Edit_Artikal;
        private DataGridViewImageColumn Delete_Artikal;
    }
}
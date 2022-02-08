namespace Projekat_Prodavnica
{
    partial class frm_PP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PP));
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnNovi_Radnik = new System.Windows.Forms.Button();
            this.btn_Pretrazi_Radnika = new System.Windows.Forms.Button();
            this.btnUcitaj_Radnika = new System.Windows.Forms.Button();
            this.textPretraga_PIB = new System.Windows.Forms.TextBox();
            this.cmbVrsta_PP_a = new System.Windows.Forms.ComboBox();
            this.textDetalji_PP_a = new System.Windows.Forms.TextBox();
            this.textAdresa_PP_a = new System.Windows.Forms.TextBox();
            this.textMaticni_Broj_PP_a = new System.Windows.Forms.TextBox();
            this.textPIB_PP_a = new System.Windows.Forms.TextBox();
            this.texNaziv_PP_a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_PP_a = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv_PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_radinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_PP_a = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_PP_a = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PP_a)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(473, 162);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 124;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnNovi_Radnik
            // 
            this.btnNovi_Radnik.Location = new System.Drawing.Point(392, 163);
            this.btnNovi_Radnik.Name = "btnNovi_Radnik";
            this.btnNovi_Radnik.Size = new System.Drawing.Size(75, 23);
            this.btnNovi_Radnik.TabIndex = 123;
            this.btnNovi_Radnik.Text = "Dodaj";
            this.btnNovi_Radnik.UseVisualStyleBackColor = true;
            this.btnNovi_Radnik.Click += new System.EventHandler(this.btnNovi_Radnik_Click);
            // 
            // btn_Pretrazi_Radnika
            // 
            this.btn_Pretrazi_Radnika.Location = new System.Drawing.Point(297, 163);
            this.btn_Pretrazi_Radnika.Name = "btn_Pretrazi_Radnika";
            this.btn_Pretrazi_Radnika.Size = new System.Drawing.Size(89, 23);
            this.btn_Pretrazi_Radnika.TabIndex = 122;
            this.btn_Pretrazi_Radnika.Text = "Pretrazi";
            this.btn_Pretrazi_Radnika.UseVisualStyleBackColor = true;
            this.btn_Pretrazi_Radnika.Click += new System.EventHandler(this.btn_Pretrazi_Radnika_Click);
            // 
            // btnUcitaj_Radnika
            // 
            this.btnUcitaj_Radnika.Location = new System.Drawing.Point(29, 163);
            this.btnUcitaj_Radnika.Name = "btnUcitaj_Radnika";
            this.btnUcitaj_Radnika.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj_Radnika.TabIndex = 121;
            this.btnUcitaj_Radnika.Text = "Ucitaj";
            this.btnUcitaj_Radnika.UseVisualStyleBackColor = true;
            this.btnUcitaj_Radnika.Click += new System.EventHandler(this.btnUcitaj_Radnika_Click);
            // 
            // textPretraga_PIB
            // 
            this.textPretraga_PIB.Location = new System.Drawing.Point(129, 163);
            this.textPretraga_PIB.Name = "textPretraga_PIB";
            this.textPretraga_PIB.PlaceholderText = "Pretraga po PIB-u";
            this.textPretraga_PIB.Size = new System.Drawing.Size(153, 23);
            this.textPretraga_PIB.TabIndex = 120;
            // 
            // cmbVrsta_PP_a
            // 
            this.cmbVrsta_PP_a.FormattingEnabled = true;
            this.cmbVrsta_PP_a.Location = new System.Drawing.Point(203, 89);
            this.cmbVrsta_PP_a.Name = "cmbVrsta_PP_a";
            this.cmbVrsta_PP_a.Size = new System.Drawing.Size(153, 23);
            this.cmbVrsta_PP_a.TabIndex = 119;
            // 
            // textDetalji_PP_a
            // 
            this.textDetalji_PP_a.Location = new System.Drawing.Point(489, 89);
            this.textDetalji_PP_a.Name = "textDetalji_PP_a";
            this.textDetalji_PP_a.Size = new System.Drawing.Size(153, 23);
            this.textDetalji_PP_a.TabIndex = 117;
            // 
            // textAdresa_PP_a
            // 
            this.textAdresa_PP_a.Location = new System.Drawing.Point(489, 57);
            this.textAdresa_PP_a.Name = "textAdresa_PP_a";
            this.textAdresa_PP_a.Size = new System.Drawing.Size(153, 23);
            this.textAdresa_PP_a.TabIndex = 116;
            // 
            // textMaticni_Broj_PP_a
            // 
            this.textMaticni_Broj_PP_a.Location = new System.Drawing.Point(489, 22);
            this.textMaticni_Broj_PP_a.Name = "textMaticni_Broj_PP_a";
            this.textMaticni_Broj_PP_a.Size = new System.Drawing.Size(153, 23);
            this.textMaticni_Broj_PP_a.TabIndex = 115;
            // 
            // textPIB_PP_a
            // 
            this.textPIB_PP_a.Location = new System.Drawing.Point(203, 57);
            this.textPIB_PP_a.Name = "textPIB_PP_a";
            this.textPIB_PP_a.Size = new System.Drawing.Size(153, 23);
            this.textPIB_PP_a.TabIndex = 114;
            // 
            // texNaziv_PP_a
            // 
            this.texNaziv_PP_a.Location = new System.Drawing.Point(203, 22);
            this.texNaziv_PP_a.Name = "texNaziv_PP_a";
            this.texNaziv_PP_a.Size = new System.Drawing.Size(153, 23);
            this.texNaziv_PP_a.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 111;
            this.label6.Text = "Detalji P. Partnera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 110;
            this.label5.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 109;
            this.label4.Text = "Maticni Broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 108;
            this.label3.Text = "Vrsta Poslovnog Partnera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 107;
            this.label2.Text = "PIB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 106;
            this.label1.Text = "Naziv Poslovnog Partnera:";
            // 
            // dataGrid_PP_a
            // 
            this.dataGrid_PP_a.AllowUserToAddRows = false;
            this.dataGrid_PP_a.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_PP_a.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_PP_a.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_PP_a.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_PP_a.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_PP_a.ColumnHeadersHeight = 50;
            this.dataGrid_PP_a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_PP_a.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.Naziv_PP,
            this.JMBG,
            this.v_radinka,
            this.k_ime,
            this.lozinka,
            this.adresa,
            this.Edit_PP_a,
            this.Delete_PP_a});
            this.dataGrid_PP_a.EnableHeadersVisualStyles = false;
            this.dataGrid_PP_a.Location = new System.Drawing.Point(-2, 192);
            this.dataGrid_PP_a.MultiSelect = false;
            this.dataGrid_PP_a.Name = "dataGrid_PP_a";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_PP_a.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_PP_a.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_PP_a.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_PP_a.RowTemplate.Height = 25;
            this.dataGrid_PP_a.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_PP_a.Size = new System.Drawing.Size(804, 224);
            this.dataGrid_PP_a.TabIndex = 105;
            this.dataGrid_PP_a.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_PP_a_CellContentClick);
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
            this.Naziv_PP.HeaderText = "Naziv Poslovnog Partnera";
            this.Naziv_PP.Name = "Naziv_PP";
            this.Naziv_PP.Width = 165;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JMBG.HeaderText = "PIB";
            this.JMBG.Name = "JMBG";
            this.JMBG.Width = 48;
            // 
            // v_radinka
            // 
            this.v_radinka.HeaderText = "Maticni Broj";
            this.v_radinka.Name = "v_radinka";
            // 
            // k_ime
            // 
            this.k_ime.HeaderText = "Adresa";
            this.k_ime.Name = "k_ime";
            // 
            // lozinka
            // 
            this.lozinka.HeaderText = "Vrsta Poslovnog Partnera";
            this.lozinka.Name = "lozinka";
            // 
            // adresa
            // 
            this.adresa.HeaderText = "Detalji Poslovnog Partnera";
            this.adresa.Name = "adresa";
            // 
            // Edit_PP_a
            // 
            this.Edit_PP_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit_PP_a.HeaderText = "";
            this.Edit_PP_a.Image = ((System.Drawing.Image)(resources.GetObject("Edit_PP_a.Image")));
            this.Edit_PP_a.Name = "Edit_PP_a";
            this.Edit_PP_a.Width = 5;
            // 
            // Delete_PP_a
            // 
            this.Delete_PP_a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete_PP_a.HeaderText = "";
            this.Delete_PP_a.Image = ((System.Drawing.Image)(resources.GetObject("Delete_PP_a.Image")));
            this.Delete_PP_a.Name = "Delete_PP_a";
            this.Delete_PP_a.Width = 5;
            // 
            // frm_PP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnNovi_Radnik);
            this.Controls.Add(this.btn_Pretrazi_Radnika);
            this.Controls.Add(this.btnUcitaj_Radnika);
            this.Controls.Add(this.textPretraga_PIB);
            this.Controls.Add(this.cmbVrsta_PP_a);
            this.Controls.Add(this.textDetalji_PP_a);
            this.Controls.Add(this.textAdresa_PP_a);
            this.Controls.Add(this.textMaticni_Broj_PP_a);
            this.Controls.Add(this.textPIB_PP_a);
            this.Controls.Add(this.texNaziv_PP_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_PP_a);
            this.Name = "frm_PP";
            this.Text = "frm_PP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PP_a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIzmeni;
        private Button btnNovi_Radnik;
        private Button btn_Pretrazi_Radnika;
        private Button btnUcitaj_Radnika;
        private TextBox textPretraga_PIB;
        private ComboBox cmbVrsta_PP_a;
        private TextBox textDetalji_PP_a;
        private TextBox textAdresa_PP_a;
        private TextBox textMaticni_Broj_PP_a;
        private TextBox textPIB_PP_a;
        private TextBox texNaziv_PP_a;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public DataGridView dataGrid_PP_a;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Naziv_PP;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn v_radinka;
        private DataGridViewTextBoxColumn k_ime;
        private DataGridViewTextBoxColumn lozinka;
        private DataGridViewTextBoxColumn adresa;
        private DataGridViewImageColumn Edit_PP_a;
        private DataGridViewImageColumn Delete_PP_a;
    }
}
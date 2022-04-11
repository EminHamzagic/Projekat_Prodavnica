namespace Projekat_Prodavnica
{
    partial class Zarade_Radnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zarade_Radnika));
            this.dataGrid_ZaradeRadnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRadnik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textZarada = new System.Windows.Forms.TextBox();
            this.dtPeriodOd = new System.Windows.Forms.DateTimePicker();
            this.dtPeriodDo = new System.Windows.Forms.DateTimePicker();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_radinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ZaradeRadnika)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_ZaradeRadnika
            // 
            this.dataGrid_ZaradeRadnika.AllowUserToAddRows = false;
            this.dataGrid_ZaradeRadnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_ZaradeRadnika.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_ZaradeRadnika.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_ZaradeRadnika.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_ZaradeRadnika.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_ZaradeRadnika.ColumnHeadersHeight = 50;
            this.dataGrid_ZaradeRadnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_ZaradeRadnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.ime_prezime,
            this.JMBG,
            this.v_radinka,
            this.k_ime,
            this.Edit_Radnika,
            this.Delete_Radnika});
            this.dataGrid_ZaradeRadnika.EnableHeadersVisualStyles = false;
            this.dataGrid_ZaradeRadnika.Location = new System.Drawing.Point(-1, 153);
            this.dataGrid_ZaradeRadnika.MultiSelect = false;
            this.dataGrid_ZaradeRadnika.Name = "dataGrid_ZaradeRadnika";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_ZaradeRadnika.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_ZaradeRadnika.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_ZaradeRadnika.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_ZaradeRadnika.RowTemplate.Height = 25;
            this.dataGrid_ZaradeRadnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_ZaradeRadnika.Size = new System.Drawing.Size(519, 224);
            this.dataGrid_ZaradeRadnika.TabIndex = 86;
            this.dataGrid_ZaradeRadnika.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_ZaradeRadnika_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 87;
            this.label1.Text = "Radnik:";
            // 
            // cmbRadnik
            // 
            this.cmbRadnik.FormattingEnabled = true;
            this.cmbRadnik.Location = new System.Drawing.Point(121, 26);
            this.cmbRadnik.Name = "cmbRadnik";
            this.cmbRadnik.Size = new System.Drawing.Size(121, 23);
            this.cmbRadnik.TabIndex = 88;
            this.cmbRadnik.SelectionChangeCommitted += new System.EventHandler(this.cmbRadnik_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 89;
            this.label2.Text = "Period Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 90;
            this.label3.Text = "Iznos Zarade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Period Do:";
            // 
            // textZarada
            // 
            this.textZarada.Location = new System.Drawing.Point(121, 63);
            this.textZarada.Name = "textZarada";
            this.textZarada.Size = new System.Drawing.Size(121, 23);
            this.textZarada.TabIndex = 92;
            // 
            // dtPeriodOd
            // 
            this.dtPeriodOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodOd.Location = new System.Drawing.Point(338, 26);
            this.dtPeriodOd.Name = "dtPeriodOd";
            this.dtPeriodOd.Size = new System.Drawing.Size(121, 23);
            this.dtPeriodOd.TabIndex = 160;
            // 
            // dtPeriodDo
            // 
            this.dtPeriodDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodDo.Location = new System.Drawing.Point(338, 63);
            this.dtPeriodDo.Name = "dtPeriodDo";
            this.dtPeriodDo.Size = new System.Drawing.Size(121, 23);
            this.dtPeriodDo.TabIndex = 161;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(26, 111);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj.TabIndex = 162;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(118, 111);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 163;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(208, 111);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 164;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
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
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            this.JMBG.HeaderText = "Period od";
            this.JMBG.Name = "JMBG";
            this.JMBG.Width = 82;
            // 
            // v_radinka
            // 
            this.v_radinka.HeaderText = "Period do";
            this.v_radinka.Name = "v_radinka";
            // 
            // k_ime
            // 
            this.k_ime.HeaderText = "Iznos Zarade";
            this.k_ime.Name = "k_ime";
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
            // Zarade_Radnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 371);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.dtPeriodDo);
            this.Controls.Add(this.dtPeriodOd);
            this.Controls.Add(this.textZarada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRadnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_ZaradeRadnika);
            this.Name = "Zarade_Radnika";
            this.Text = "Zarade_Radnika";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ZaradeRadnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dataGrid_ZaradeRadnika;
        private Label label1;
        private ComboBox cmbRadnik;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textZarada;
        private DateTimePicker dtPeriodOd;
        private DateTimePicker dtPeriodDo;
        private Button btnUcitaj;
        private Button btnDodaj;
        private Button btnIzmeni;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ime_prezime;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn v_radinka;
        private DataGridViewTextBoxColumn k_ime;
        private DataGridViewImageColumn Edit_Radnika;
        private DataGridViewImageColumn Delete_Radnika;
    }
}
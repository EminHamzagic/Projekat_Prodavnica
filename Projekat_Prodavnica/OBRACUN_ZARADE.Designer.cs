namespace Projekat_Prodavnica
{
    partial class OBRACUN_ZARADE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OBRACUN_ZARADE));
            this.dataGrid_Obracun_Zarada_Radnika = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_radinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupnaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdsadsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbIme_Prezime_Radnika = new System.Windows.Forms.ComboBox();
            this.cmbVrsta_Zarade = new System.Windows.Forms.ComboBox();
            this.datePeriodDo = new System.Windows.Forms.DateTimePicker();
            this.datePeriodOd = new System.Windows.Forms.DateTimePicker();
            this.textPretrazi = new System.Windows.Forms.TextBox();
            this.textUkupna_Zarada = new System.Windows.Forms.TextBox();
            this.textDestimulacija = new System.Windows.Forms.TextBox();
            this.textStmulacija = new System.Windows.Forms.TextBox();
            this.textUgovorena_Mesecna_Zarada = new System.Windows.Forms.TextBox();
            this.textNapomena_Zarada = new System.Windows.Forms.RichTextBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.BtnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Obracun_Zarada_Radnika)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Obracun_Zarada_Radnika
            // 
            this.dataGrid_Obracun_Zarada_Radnika.AllowUserToAddRows = false;
            this.dataGrid_Obracun_Zarada_Radnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Obracun_Zarada_Radnika.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Obracun_Zarada_Radnika.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Obracun_Zarada_Radnika.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Obracun_Zarada_Radnika.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Obracun_Zarada_Radnika.ColumnHeadersHeight = 50;
            this.dataGrid_Obracun_Zarada_Radnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Obracun_Zarada_Radnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.ime_prezime,
            this.k_ime,
            this.dsd,
            this.JMBG,
            this.v_radinka,
            this.Ukupnaz,
            this.sdsadsa,
            this.Edit_Radnika,
            this.Delete_Radnika});
            this.dataGrid_Obracun_Zarada_Radnika.EnableHeadersVisualStyles = false;
            this.dataGrid_Obracun_Zarada_Radnika.Location = new System.Drawing.Point(-3, 194);
            this.dataGrid_Obracun_Zarada_Radnika.MultiSelect = false;
            this.dataGrid_Obracun_Zarada_Radnika.Name = "dataGrid_Obracun_Zarada_Radnika";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Obracun_Zarada_Radnika.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_Obracun_Zarada_Radnika.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Obracun_Zarada_Radnika.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_Obracun_Zarada_Radnika.RowTemplate.Height = 25;
            this.dataGrid_Obracun_Zarada_Radnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Obracun_Zarada_Radnika.Size = new System.Drawing.Size(911, 224);
            this.dataGrid_Obracun_Zarada_Radnika.TabIndex = 87;
            this.dataGrid_Obracun_Zarada_Radnika.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Obracun_Zarada_Radnika_CellContentClick);
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
            // k_ime
            // 
            this.k_ime.HeaderText = "JMBG";
            this.k_ime.Name = "k_ime";
            // 
            // dsd
            // 
            this.dsd.HeaderText = "Vrsta Zarade";
            this.dsd.Name = "dsd";
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
            // Ukupnaz
            // 
            this.Ukupnaz.HeaderText = "Ukupna Zarada";
            this.Ukupnaz.Name = "Ukupnaz";
            // 
            // sdsadsa
            // 
            this.sdsadsa.HeaderText = "Napomena Zarade";
            this.sdsadsa.Name = "sdsadsa";
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
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 88;
            this.label1.Text = "Ime i Prezime Radnika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 89;
            this.label2.Text = "Vrsta Zarade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 90;
            this.label3.Text = "Period Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Period Do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 92;
            this.label5.Text = "Ugovorena Mesecna Zarada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 93;
            this.label6.Text = "Stimulacija:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 94;
            this.label7.Text = "Destimulacija:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 95;
            this.label8.Text = "Ukupna Zarada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 96;
            this.label9.Text = "Napomena:";
            // 
            // cmbIme_Prezime_Radnika
            // 
            this.cmbIme_Prezime_Radnika.FormattingEnabled = true;
            this.cmbIme_Prezime_Radnika.Location = new System.Drawing.Point(155, 19);
            this.cmbIme_Prezime_Radnika.Name = "cmbIme_Prezime_Radnika";
            this.cmbIme_Prezime_Radnika.Size = new System.Drawing.Size(170, 23);
            this.cmbIme_Prezime_Radnika.TabIndex = 97;
            this.cmbIme_Prezime_Radnika.SelectionChangeCommitted += new System.EventHandler(this.cmbIme_Prezime_Radnika_SelectionChangeCommitted);
            // 
            // cmbVrsta_Zarade
            // 
            this.cmbVrsta_Zarade.FormattingEnabled = true;
            this.cmbVrsta_Zarade.Location = new System.Drawing.Point(155, 48);
            this.cmbVrsta_Zarade.Name = "cmbVrsta_Zarade";
            this.cmbVrsta_Zarade.Size = new System.Drawing.Size(170, 23);
            this.cmbVrsta_Zarade.TabIndex = 98;
            this.cmbVrsta_Zarade.SelectionChangeCommitted += new System.EventHandler(this.cmbVrsta_Zarade_SelectionChangeCommitted);
            // 
            // datePeriodDo
            // 
            this.datePeriodDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePeriodDo.Location = new System.Drawing.Point(155, 111);
            this.datePeriodDo.Name = "datePeriodDo";
            this.datePeriodDo.Size = new System.Drawing.Size(170, 23);
            this.datePeriodDo.TabIndex = 159;
            // 
            // datePeriodOd
            // 
            this.datePeriodOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePeriodOd.Location = new System.Drawing.Point(155, 78);
            this.datePeriodOd.Name = "datePeriodOd";
            this.datePeriodOd.Size = new System.Drawing.Size(170, 23);
            this.datePeriodOd.TabIndex = 160;
            // 
            // textPretrazi
            // 
            this.textPretrazi.Location = new System.Drawing.Point(155, 156);
            this.textPretrazi.Name = "textPretrazi";
            this.textPretrazi.Size = new System.Drawing.Size(170, 23);
            this.textPretrazi.TabIndex = 161;
            // 
            // textUkupna_Zarada
            // 
            this.textUkupna_Zarada.Location = new System.Drawing.Point(512, 114);
            this.textUkupna_Zarada.Name = "textUkupna_Zarada";
            this.textUkupna_Zarada.Size = new System.Drawing.Size(156, 23);
            this.textUkupna_Zarada.TabIndex = 162;
            // 
            // textDestimulacija
            // 
            this.textDestimulacija.Location = new System.Drawing.Point(512, 78);
            this.textDestimulacija.Name = "textDestimulacija";
            this.textDestimulacija.Size = new System.Drawing.Size(156, 23);
            this.textDestimulacija.TabIndex = 163;
            this.textDestimulacija.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDestimulacija_KeyDown);
            // 
            // textStmulacija
            // 
            this.textStmulacija.Location = new System.Drawing.Point(512, 48);
            this.textStmulacija.Name = "textStmulacija";
            this.textStmulacija.Size = new System.Drawing.Size(156, 23);
            this.textStmulacija.TabIndex = 164;
            // 
            // textUgovorena_Mesecna_Zarada
            // 
            this.textUgovorena_Mesecna_Zarada.Location = new System.Drawing.Point(512, 19);
            this.textUgovorena_Mesecna_Zarada.Name = "textUgovorena_Mesecna_Zarada";
            this.textUgovorena_Mesecna_Zarada.Size = new System.Drawing.Size(156, 23);
            this.textUgovorena_Mesecna_Zarada.TabIndex = 165;
            // 
            // textNapomena_Zarada
            // 
            this.textNapomena_Zarada.Location = new System.Drawing.Point(689, 48);
            this.textNapomena_Zarada.Name = "textNapomena_Zarada";
            this.textNapomena_Zarada.Size = new System.Drawing.Size(204, 89);
            this.textNapomena_Zarada.TabIndex = 166;
            this.textNapomena_Zarada.Text = "";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(76, 155);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 24);
            this.btnUcitaj.TabIndex = 167;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnIzmeni
            // 
            this.BtnIzmeni.Location = new System.Drawing.Point(579, 156);
            this.BtnIzmeni.Name = "BtnIzmeni";
            this.BtnIzmeni.Size = new System.Drawing.Size(100, 24);
            this.BtnIzmeni.TabIndex = 168;
            this.BtnIzmeni.Text = "Izmeni";
            this.BtnIzmeni.UseVisualStyleBackColor = true;
            this.BtnIzmeni.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(462, 156);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 24);
            this.btnDodaj.TabIndex = 169;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(349, 156);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(95, 24);
            this.btnPretrazi.TabIndex = 170;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.button4_Click);
            // 
            // OBRACUN_ZARADE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 391);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.BtnIzmeni);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.textNapomena_Zarada);
            this.Controls.Add(this.textUgovorena_Mesecna_Zarada);
            this.Controls.Add(this.textStmulacija);
            this.Controls.Add(this.textDestimulacija);
            this.Controls.Add(this.textUkupna_Zarada);
            this.Controls.Add(this.textPretrazi);
            this.Controls.Add(this.datePeriodOd);
            this.Controls.Add(this.datePeriodDo);
            this.Controls.Add(this.cmbVrsta_Zarade);
            this.Controls.Add(this.cmbIme_Prezime_Radnika);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Obracun_Zarada_Radnika);
            this.Name = "OBRACUN_ZARADE";
            this.Text = "OBRACUN_ZARADE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Obracun_Zarada_Radnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dataGrid_Obracun_Zarada_Radnika;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ime_prezime;
        private DataGridViewTextBoxColumn k_ime;
        private DataGridViewTextBoxColumn dsd;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn v_radinka;
        private DataGridViewTextBoxColumn Ukupnaz;
        private DataGridViewTextBoxColumn sdsadsa;
        private DataGridViewImageColumn Edit_Radnika;
        private DataGridViewImageColumn Delete_Radnika;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbIme_Prezime_Radnika;
        private ComboBox cmbVrsta_Zarade;
        private DateTimePicker datePeriodDo;
        private DateTimePicker datePeriodOd;
        private TextBox textPretrazi;
        private TextBox textUkupna_Zarada;
        private TextBox textDestimulacija;
        private TextBox textStmulacija;
        private TextBox textUgovorena_Mesecna_Zarada;
        private RichTextBox textNapomena_Zarada;
        private Button btnUcitaj;
        private Button BtnIzmeni;
        private Button btnDodaj;
        private Button btnPretrazi;
    }
}
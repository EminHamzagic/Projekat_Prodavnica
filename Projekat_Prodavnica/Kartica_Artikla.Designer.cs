namespace Projekat_Prodavnica
{
    partial class Kartica_Artikla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kartica_Artikla));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPretraga_Artikala = new System.Windows.Forms.Button();
            this.dataGrid_Kartica_Artikla = new System.Windows.Forms.DataGridView();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.cmbNazivArtikla_Kartica = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_radinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kartica_Artikla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPretraga_Artikala);
            this.groupBox1.Controls.Add(this.dataGrid_Kartica_Artikla);
            this.groupBox1.Controls.Add(this.dtDo);
            this.groupBox1.Controls.Add(this.dtOd);
            this.groupBox1.Controls.Add(this.cmbNazivArtikla_Kartica);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kartica Artikla";
            // 
            // btnPretraga_Artikala
            // 
            this.btnPretraga_Artikala.Location = new System.Drawing.Point(88, 128);
            this.btnPretraga_Artikala.Name = "btnPretraga_Artikala";
            this.btnPretraga_Artikala.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga_Artikala.TabIndex = 163;
            this.btnPretraga_Artikala.Text = "Pretrazi";
            this.btnPretraga_Artikala.UseVisualStyleBackColor = true;
            this.btnPretraga_Artikala.Click += new System.EventHandler(this.btnPretraga_Artikala_Click);
            // 
            // dataGrid_Kartica_Artikla
            // 
            this.dataGrid_Kartica_Artikla.AllowUserToAddRows = false;
            this.dataGrid_Kartica_Artikla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Kartica_Artikla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Kartica_Artikla.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Kartica_Artikla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Kartica_Artikla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Kartica_Artikla.ColumnHeadersHeight = 50;
            this.dataGrid_Kartica_Artikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Kartica_Artikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.ime_prezime,
            this.JMBG,
            this.v_radinka,
            this.k_ime,
            this.Edit_Radnika,
            this.Delete_Radnika});
            this.dataGrid_Kartica_Artikla.EnableHeadersVisualStyles = false;
            this.dataGrid_Kartica_Artikla.Location = new System.Drawing.Point(0, 167);
            this.dataGrid_Kartica_Artikla.MultiSelect = false;
            this.dataGrid_Kartica_Artikla.Name = "dataGrid_Kartica_Artikla";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Kartica_Artikla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Kartica_Artikla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Kartica_Artikla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Kartica_Artikla.RowTemplate.Height = 25;
            this.dataGrid_Kartica_Artikla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Kartica_Artikla.Size = new System.Drawing.Size(590, 302);
            this.dataGrid_Kartica_Artikla.TabIndex = 162;
            // 
            // dtDo
            // 
            this.dtDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDo.Location = new System.Drawing.Point(88, 93);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(121, 23);
            this.dtDo.TabIndex = 161;
            // 
            // dtOd
            // 
            this.dtOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOd.Location = new System.Drawing.Point(88, 64);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(121, 23);
            this.dtOd.TabIndex = 160;
            // 
            // cmbNazivArtikla_Kartica
            // 
            this.cmbNazivArtikla_Kartica.FormattingEnabled = true;
            this.cmbNazivArtikla_Kartica.Location = new System.Drawing.Point(88, 32);
            this.cmbNazivArtikla_Kartica.Name = "cmbNazivArtikla_Kartica";
            this.cmbNazivArtikla_Kartica.Size = new System.Drawing.Size(121, 23);
            this.cmbNazivArtikla_Kartica.TabIndex = 3;
            this.cmbNazivArtikla_Kartica.SelectionChangeCommitted += new System.EventHandler(this.cmbNazivArtikla_Kartica_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Period Od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Artikla:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Broj Dokumenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ime_prezime
            // 
            this.ime_prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ime_prezime.HeaderText = "Datum Dokumenta";
            this.ime_prezime.Name = "ime_prezime";
            this.ime_prezime.Width = 127;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JMBG.HeaderText = "Ulaz";
            this.JMBG.Name = "JMBG";
            this.JMBG.Width = 56;
            // 
            // v_radinka
            // 
            this.v_radinka.HeaderText = "Izlaz";
            this.v_radinka.Name = "v_radinka";
            // 
            // k_ime
            // 
            this.k_ime.HeaderText = "Stanje";
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
            // Kartica_Artikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 493);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kartica_Artikla";
            this.Text = "Kartica_Artikla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kartica_Artikla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtDo;
        private ComboBox cmbNazivArtikla_Kartica;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtOd;
        public DataGridView dataGrid_Kartica_Artikla;
        private Button btnPretraga_Artikala;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ime_prezime;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn v_radinka;
        private DataGridViewTextBoxColumn k_ime;
        private DataGridViewImageColumn Edit_Radnika;
        private DataGridViewImageColumn Delete_Radnika;
    }
}
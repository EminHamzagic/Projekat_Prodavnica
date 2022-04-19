namespace Projekat_Prodavnica
{
    partial class EvidencijaProdajeTroskova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtPeriodOd = new System.Windows.Forms.DateTimePicker();
            this.dtPeriodDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dataGrid_EvidencijaTroskova = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_radinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EvidencijaTroskova)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPeriodOd
            // 
            this.dtPeriodOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodOd.Location = new System.Drawing.Point(81, 12);
            this.dtPeriodOd.Name = "dtPeriodOd";
            this.dtPeriodOd.Size = new System.Drawing.Size(121, 23);
            this.dtPeriodOd.TabIndex = 161;
            // 
            // dtPeriodDo
            // 
            this.dtPeriodDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriodDo.Location = new System.Drawing.Point(81, 45);
            this.dtPeriodDo.Name = "dtPeriodDo";
            this.dtPeriodDo.Size = new System.Drawing.Size(121, 23);
            this.dtPeriodDo.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 163;
            this.label1.Text = "Period Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 164;
            this.label2.Text = "Period Do:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(13, 86);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(189, 40);
            this.btnPrikazi.TabIndex = 165;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dataGrid_EvidencijaTroskova
            // 
            this.dataGrid_EvidencijaTroskova.AllowUserToAddRows = false;
            this.dataGrid_EvidencijaTroskova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_EvidencijaTroskova.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_EvidencijaTroskova.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_EvidencijaTroskova.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_EvidencijaTroskova.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_EvidencijaTroskova.ColumnHeadersHeight = 50;
            this.dataGrid_EvidencijaTroskova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_EvidencijaTroskova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ime_prezime,
            this.JMBG,
            this.v_radinka,
            this.k_ime});
            this.dataGrid_EvidencijaTroskova.EnableHeadersVisualStyles = false;
            this.dataGrid_EvidencijaTroskova.Location = new System.Drawing.Point(-7, 153);
            this.dataGrid_EvidencijaTroskova.MultiSelect = false;
            this.dataGrid_EvidencijaTroskova.Name = "dataGrid_EvidencijaTroskova";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_EvidencijaTroskova.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_EvidencijaTroskova.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_EvidencijaTroskova.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid_EvidencijaTroskova.RowTemplate.Height = 25;
            this.dataGrid_EvidencijaTroskova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_EvidencijaTroskova.Size = new System.Drawing.Size(519, 224);
            this.dataGrid_EvidencijaTroskova.TabIndex = 166;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 39;
            // 
            // ime_prezime
            // 
            this.ime_prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ime_prezime.HeaderText = "Iznos Troska";
            this.ime_prezime.Name = "ime_prezime";
            this.ime_prezime.Width = 95;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JMBG.HeaderText = "Iznos Troska Plata Radnika";
            this.JMBG.Name = "JMBG";
            this.JMBG.Width = 128;
            // 
            // v_radinka
            // 
            this.v_radinka.HeaderText = "Dobitak";
            this.v_radinka.Name = "v_radinka";
            // 
            // k_ime
            // 
            this.k_ime.HeaderText = "Poslovanje";
            this.k_ime.Name = "k_ime";
            // 
            // EvidencijaProdajeTroskova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 374);
            this.Controls.Add(this.dataGrid_EvidencijaTroskova);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPeriodDo);
            this.Controls.Add(this.dtPeriodOd);
            this.Name = "EvidencijaProdajeTroskova";
            this.Text = "EvidencijaProdajeTroskova";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EvidencijaTroskova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtPeriodOd;
        private DateTimePicker dtPeriodDo;
        private Label label1;
        private Label label2;
        private Button btnPrikazi;
        public DataGridView dataGrid_EvidencijaTroskova;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ime_prezime;
        private DataGridViewTextBoxColumn JMBG;
        private DataGridViewTextBoxColumn v_radinka;
        private DataGridViewTextBoxColumn k_ime;
    }
}
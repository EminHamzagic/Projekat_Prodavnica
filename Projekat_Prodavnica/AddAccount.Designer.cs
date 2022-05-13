namespace Projekat_Prodavnica
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.dataGridAccounts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_Radnika = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.btn_Ucitaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(90, 6);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(120, 23);
            this.textUsername.TabIndex = 1;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(90, 86);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(120, 23);
            this.cmbTip.TabIndex = 2;
            this.cmbTip.Text = "-Select-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(90, 44);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(120, 23);
            this.textPassword.TabIndex = 5;
            // 
            // dataGridAccounts
            // 
            this.dataGridAccounts.AllowUserToAddRows = false;
            this.dataGridAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAccounts.ColumnHeadersHeight = 50;
            this.dataGridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.Username,
            this.k_ime,
            this.dsd,
            this.Delete_Radnika});
            this.dataGridAccounts.EnableHeadersVisualStyles = false;
            this.dataGridAccounts.Location = new System.Drawing.Point(-10, 129);
            this.dataGridAccounts.MultiSelect = false;
            this.dataGridAccounts.Name = "dataGridAccounts";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridAccounts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAccounts.RowTemplate.Height = 25;
            this.dataGridAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAccounts.Size = new System.Drawing.Size(467, 224);
            this.dataGridAccounts.TabIndex = 88;
            this.dataGridAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAccounts_CellContentClick);
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
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 90;
            // 
            // k_ime
            // 
            this.k_ime.HeaderText = "Password";
            this.k_ime.Name = "k_ime";
            // 
            // dsd
            // 
            this.dsd.HeaderText = "Type";
            this.dsd.Name = "dsd";
            // 
            // Delete_Radnika
            // 
            this.Delete_Radnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete_Radnika.HeaderText = "";
            this.Delete_Radnika.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Radnika.Image")));
            this.Delete_Radnika.Name = "Delete_Radnika";
            this.Delete_Radnika.Width = 5;
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.Location = new System.Drawing.Point(233, 85);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_Dodaj.TabIndex = 89;
            this.btn_Dodaj.Text = "Dodaj";
            this.btn_Dodaj.UseVisualStyleBackColor = true;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // btn_Ucitaj
            // 
            this.btn_Ucitaj.Location = new System.Drawing.Point(327, 85);
            this.btn_Ucitaj.Name = "btn_Ucitaj";
            this.btn_Ucitaj.Size = new System.Drawing.Size(75, 23);
            this.btn_Ucitaj.TabIndex = 90;
            this.btn_Ucitaj.Text = "Ucitaj";
            this.btn_Ucitaj.UseVisualStyleBackColor = true;
            this.btn_Ucitaj.Click += new System.EventHandler(this.btn_Ucitaj_Click);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 352);
            this.Controls.Add(this.btn_Ucitaj);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.dataGridAccounts);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label1);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textUsername;
        private ComboBox cmbTip;
        private Label label2;
        private Label label3;
        private TextBox textPassword;
        public DataGridView dataGridAccounts;
        private Button btn_Dodaj;
        private Button btn_Ucitaj;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn k_ime;
        private DataGridViewTextBoxColumn dsd;
        private DataGridViewImageColumn Delete_Radnika;
    }
}
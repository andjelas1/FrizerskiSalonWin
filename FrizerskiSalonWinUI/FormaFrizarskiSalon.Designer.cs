namespace FrizerskiSalonWinUI
{
    partial class FormaFrizarskiSalon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabcontrollGlavni = new TabControl();
            tabPageRadnici = new TabPage();
            btnRadnikRaspored = new Button();
            dTimeIzborDatuma = new DateTimePicker();
            dGridRadnikKaledar = new DataGridView();
            monday = new DataGridViewTextBoxColumn();
            thuesday = new DataGridViewTextBoxColumn();
            wednsday = new DataGridViewTextBoxColumn();
            thursday = new DataGridViewTextBoxColumn();
            friday = new DataGridViewTextBoxColumn();
            saturday = new DataGridViewTextBoxColumn();
            btnDodajRadnika = new Button();
            dGridRadnici = new DataGridView();
            tabPageUsluge = new TabPage();
            btnUslugaRadniciSacuvaj = new Button();
            chListRadnici = new CheckedListBox();
            btnDodajUsluga = new Button();
            dGridUsluge = new DataGridView();
            tabPageZakazivanje = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            mockButton = new Button();
            tabcontrollGlavni.SuspendLayout();
            tabPageRadnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGridRadnikKaledar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridRadnici).BeginInit();
            tabPageUsluge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGridUsluge).BeginInit();
            tabPageZakazivanje.SuspendLayout();
            SuspendLayout();
            // 
            // tabcontrollGlavni
            // 
            tabcontrollGlavni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabcontrollGlavni.Controls.Add(tabPageRadnici);
            tabcontrollGlavni.Controls.Add(tabPageUsluge);
            tabcontrollGlavni.Controls.Add(tabPageZakazivanje);
            tabcontrollGlavni.Location = new Point(12, 12);
            tabcontrollGlavni.Name = "tabcontrollGlavni";
            tabcontrollGlavni.SelectedIndex = 0;
            tabcontrollGlavni.Size = new Size(1297, 615);
            tabcontrollGlavni.TabIndex = 0;
            // 
            // tabPageRadnici
            // 
            tabPageRadnici.Controls.Add(btnRadnikRaspored);
            tabPageRadnici.Controls.Add(dTimeIzborDatuma);
            tabPageRadnici.Controls.Add(dGridRadnikKaledar);
            tabPageRadnici.Controls.Add(btnDodajRadnika);
            tabPageRadnici.Controls.Add(dGridRadnici);
            tabPageRadnici.Location = new Point(4, 24);
            tabPageRadnici.Name = "tabPageRadnici";
            tabPageRadnici.Padding = new Padding(3);
            tabPageRadnici.Size = new Size(1289, 587);
            tabPageRadnici.TabIndex = 0;
            tabPageRadnici.Text = "Raspored: ZAPOSLENI";
            tabPageRadnici.UseVisualStyleBackColor = true;
            // 
            // btnRadnikRaspored
            // 
            btnRadnikRaspored.Location = new Point(475, 6);
            btnRadnikRaspored.Name = "btnRadnikRaspored";
            btnRadnikRaspored.Size = new Size(98, 23);
            btnRadnikRaspored.TabIndex = 5;
            btnRadnikRaspored.Text = "Raspored";
            btnRadnikRaspored.UseVisualStyleBackColor = true;
            btnRadnikRaspored.Click += btnRadnikRaspored_Click;
            // 
            // dTimeIzborDatuma
            // 
            dTimeIzborDatuma.Location = new Point(269, 6);
            dTimeIzborDatuma.Name = "dTimeIzborDatuma";
            dTimeIzborDatuma.Size = new Size(200, 23);
            dTimeIzborDatuma.TabIndex = 4;
            // 
            // dGridRadnikKaledar
            // 
            dGridRadnikKaledar.AllowUserToAddRows = false;
            dGridRadnikKaledar.AllowUserToDeleteRows = false;
            dGridRadnikKaledar.AllowUserToResizeColumns = false;
            dGridRadnikKaledar.AllowUserToResizeRows = false;
            dGridRadnikKaledar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGridRadnikKaledar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridRadnikKaledar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridRadnikKaledar.Columns.AddRange(new DataGridViewColumn[] { monday, thuesday, wednsday, thursday, friday, saturday });
            dGridRadnikKaledar.Location = new Point(269, 31);
            dGridRadnikKaledar.Name = "dGridRadnikKaledar";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGridRadnikKaledar.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridRadnikKaledar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dGridRadnikKaledar.RowTemplate.Height = 12;
            dGridRadnikKaledar.Size = new Size(562, 546);
            dGridRadnikKaledar.TabIndex = 2;
            // 
            // monday
            // 
            monday.FillWeight = 72.25042F;
            monday.HeaderText = "Pon";
            monday.Name = "monday";
            monday.ReadOnly = true;
            // 
            // thuesday
            // 
            thuesday.FillWeight = 72.25042F;
            thuesday.HeaderText = "Utorak";
            thuesday.Name = "thuesday";
            thuesday.ReadOnly = true;
            // 
            // wednsday
            // 
            wednsday.FillWeight = 72.25042F;
            wednsday.HeaderText = "Sreda";
            wednsday.Name = "wednsday";
            wednsday.ReadOnly = true;
            // 
            // thursday
            // 
            thursday.FillWeight = 72.25042F;
            thursday.HeaderText = "Cetvrtak";
            thursday.Name = "thursday";
            // 
            // friday
            // 
            friday.FillWeight = 72.25042F;
            friday.HeaderText = "Petak";
            friday.Name = "friday";
            // 
            // saturday
            // 
            saturday.FillWeight = 72.25042F;
            saturday.HeaderText = "Subota";
            saturday.Name = "saturday";
            // 
            // btnDodajRadnika
            // 
            btnDodajRadnika.Location = new Point(9, 6);
            btnDodajRadnika.Name = "btnDodajRadnika";
            btnDodajRadnika.Size = new Size(97, 23);
            btnDodajRadnika.TabIndex = 1;
            btnDodajRadnika.Text = "Novi radnik";
            btnDodajRadnika.UseVisualStyleBackColor = true;
            btnDodajRadnika.Click += btnDodajRadnika_Click;
            // 
            // dGridRadnici
            // 
            dGridRadnici.AllowUserToAddRows = false;
            dGridRadnici.AllowUserToDeleteRows = false;
            dGridRadnici.AllowUserToResizeRows = false;
            dGridRadnici.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dGridRadnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridRadnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridRadnici.Location = new Point(9, 31);
            dGridRadnici.MultiSelect = false;
            dGridRadnici.Name = "dGridRadnici";
            dGridRadnici.ReadOnly = true;
            dGridRadnici.RowHeadersVisible = false;
            dGridRadnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridRadnici.Size = new Size(239, 550);
            dGridRadnici.TabIndex = 0;
            // 
            // tabPageUsluge
            // 
            tabPageUsluge.Controls.Add(btnUslugaRadniciSacuvaj);
            tabPageUsluge.Controls.Add(chListRadnici);
            tabPageUsluge.Controls.Add(btnDodajUsluga);
            tabPageUsluge.Controls.Add(dGridUsluge);
            tabPageUsluge.Location = new Point(4, 24);
            tabPageUsluge.Name = "tabPageUsluge";
            tabPageUsluge.Size = new Size(1289, 587);
            tabPageUsluge.TabIndex = 2;
            tabPageUsluge.Text = "USLUGE I TRETMANI";
            tabPageUsluge.UseVisualStyleBackColor = true;
            // 
            // btnUslugaRadniciSacuvaj
            // 
            btnUslugaRadniciSacuvaj.Location = new Point(823, 534);
            btnUslugaRadniciSacuvaj.Name = "btnUslugaRadniciSacuvaj";
            btnUslugaRadniciSacuvaj.Size = new Size(75, 23);
            btnUslugaRadniciSacuvaj.TabIndex = 3;
            btnUslugaRadniciSacuvaj.Text = "Sacuvaj";
            btnUslugaRadniciSacuvaj.UseVisualStyleBackColor = true;
            btnUslugaRadniciSacuvaj.Click += btnUslugaRadniciSacuvaj_Click;
            // 
            // chListRadnici
            // 
            chListRadnici.CheckOnClick = true;
            chListRadnici.FormattingEnabled = true;
            chListRadnici.Location = new Point(594, 50);
            chListRadnici.Name = "chListRadnici";
            chListRadnici.Size = new Size(301, 472);
            chListRadnici.Sorted = true;
            chListRadnici.TabIndex = 2;
            // 
            // btnDodajUsluga
            // 
            btnDodajUsluga.Location = new Point(3, 12);
            btnDodajUsluga.Name = "btnDodajUsluga";
            btnDodajUsluga.Size = new Size(133, 23);
            btnDodajUsluga.TabIndex = 1;
            btnDodajUsluga.Text = "Nova usluga";
            btnDodajUsluga.UseVisualStyleBackColor = true;
            btnDodajUsluga.Click += btnDodajUsluga_Click;
            // 
            // dGridUsluge
            // 
            dGridUsluge.AllowUserToAddRows = false;
            dGridUsluge.AllowUserToDeleteRows = false;
            dGridUsluge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridUsluge.Location = new Point(3, 41);
            dGridUsluge.Name = "dGridUsluge";
            dGridUsluge.ReadOnly = true;
            dGridUsluge.RowHeadersVisible = false;
            dGridUsluge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridUsluge.Size = new Size(520, 515);
            dGridUsluge.TabIndex = 0;
            // 
            // tabPageZakazivanje
            // 
            tabPageZakazivanje.Controls.Add(mockButton);
            tabPageZakazivanje.Controls.Add(dateTimePicker1);
            tabPageZakazivanje.Location = new Point(4, 24);
            tabPageZakazivanje.Name = "tabPageZakazivanje";
            tabPageZakazivanje.Padding = new Padding(3);
            tabPageZakazivanje.Size = new Size(1289, 587);
            tabPageZakazivanje.TabIndex = 1;
            tabPageZakazivanje.Text = "Zakazivanje";
            tabPageZakazivanje.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // mockButton
            // 
            mockButton.Location = new Point(287, 273);
            mockButton.Name = "mockButton";
            mockButton.Size = new Size(75, 23);
            mockButton.TabIndex = 6;
            mockButton.Text = "button1";
            mockButton.UseVisualStyleBackColor = true;
            mockButton.Click += mockButton_Click;
            // 
            // FormaFrizarskiSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 639);
            Controls.Add(tabcontrollGlavni);
            Name = "FormaFrizarskiSalon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frizerski salon";
            WindowState = FormWindowState.Maximized;
            tabcontrollGlavni.ResumeLayout(false);
            tabPageRadnici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGridRadnikKaledar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridRadnici).EndInit();
            tabPageUsluge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGridUsluge).EndInit();
            tabPageZakazivanje.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrollGlavni;
        private TabPage tabPageRadnici;
        private TabPage tabPageZakazivanje;
        private DataGridView dGridRadnici;
        private Button btnDodajRadnika;
        private DataGridView dGridRadnikKaledar;
        private TabPage tabPageUsluge;
        private DateTimePicker dTimeIzborDatuma;
        private DataGridViewTextBoxColumn monday;
        private DataGridViewTextBoxColumn thuesday;
        private DataGridViewTextBoxColumn wednsday;
        private DataGridViewTextBoxColumn thursday;
        private DataGridViewTextBoxColumn friday;
        private DataGridViewTextBoxColumn saturday;
        private DataGridView dGridUsluge;
        private Button btnDodajUsluga;
        private Button btnRadnikRaspored;
        private CheckedListBox chListRadnici;
        private Button btnUslugaRadniciSacuvaj;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewCheckBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private Button mockButton;
    }
}

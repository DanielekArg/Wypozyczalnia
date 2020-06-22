namespace Shop
{
    partial class rejestracjaProduktu
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
            this.txtdostepnosc = new System.Windows.Forms.ComboBox();
            this.txtkategoria = new System.Windows.Forms.TextBox();
            this.txtnazwa = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostępnosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edytuj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdostepnosc
            // 
            this.txtdostepnosc.FormattingEnabled = true;
            this.txtdostepnosc.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.txtdostepnosc.Location = new System.Drawing.Point(100, 200);
            this.txtdostepnosc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdostepnosc.Name = "txtdostepnosc";
            this.txtdostepnosc.Size = new System.Drawing.Size(116, 21);
            this.txtdostepnosc.TabIndex = 7;
            // 
            // txtkategoria
            // 
            this.txtkategoria.Location = new System.Drawing.Point(100, 138);
            this.txtkategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtkategoria.Name = "txtkategoria";
            this.txtkategoria.Size = new System.Drawing.Size(116, 20);
            this.txtkategoria.TabIndex = 6;
            // 
            // txtnazwa
            // 
            this.txtnazwa.Location = new System.Drawing.Point(100, 82);
            this.txtnazwa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnazwa.Name = "txtnazwa";
            this.txtnazwa.Size = new System.Drawing.Size(116, 20);
            this.txtnazwa.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 20);
            this.txtId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dostępność";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Produktu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(100, 283);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "Wyjdż";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nazwa,
            this.Kategoria,
            this.Dostępnosc,
            this.Edytuj,
            this.Usun});
            this.dataGridView1.Location = new System.Drawing.Point(232, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 248);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.MinimumWidth = 6;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Width = 125;
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.MinimumWidth = 6;
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.Width = 125;
            // 
            // Dostępnosc
            // 
            this.Dostępnosc.HeaderText = "Dostępnosc";
            this.Dostępnosc.MinimumWidth = 6;
            this.Dostępnosc.Name = "Dostępnosc";
            this.Dostępnosc.Width = 125;
            // 
            // Edytuj
            // 
            this.Edytuj.HeaderText = "Edytuj";
            this.Edytuj.MinimumWidth = 6;
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edytuj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseColumnTextForButtonValue = true;
            this.Edytuj.Width = 125;
            // 
            // Usun
            // 
            this.Usun.HeaderText = "Usun";
            this.Usun.MinimumWidth = 6;
            this.Usun.Name = "Usun";
            this.Usun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Usun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Usun.Text = "Usun";
            this.Usun.UseColumnTextForButtonValue = true;
            this.Usun.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Odśwież";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rejestracjaProduktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shop.Properties.Resources.odpowiedzialna_turystyka_podróże_1024x683;
            this.ClientSize = new System.Drawing.Size(1085, 606);
            this.Controls.Add(this.txtdostepnosc);
            this.Controls.Add(this.txtkategoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtnazwa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "rejestracjaProduktu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RejestracjaProduktu";
            this.Load += new System.EventHandler(this.rejestracjaProduktu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtdostepnosc;
        private System.Windows.Forms.TextBox txtkategoria;
        private System.Windows.Forms.TextBox txtnazwa;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostępnosc;
        private System.Windows.Forms.DataGridViewButtonColumn Edytuj;
        private System.Windows.Forms.DataGridViewButtonColumn Usun;
        private System.Windows.Forms.Button button2;
    }
}
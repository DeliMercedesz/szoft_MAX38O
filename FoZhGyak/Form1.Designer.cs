namespace FoZhGyak
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            LoadButton = new Button();
            dataGridView1 = new DataGridView();
            versenyzoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyPercDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            futokBindingSource = new BindingSource(components);
            SaveButton = new Button();
            textBox1 = new TextBox();
            DeleteButton = new Button();
            AddButton = new Button();
            SzamitButton = new Button();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(632, 23);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(147, 37);
            LoadButton.TabIndex = 0;
            LoadButton.Text = "Betöltés";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { versenyzoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn, eredmenyPercDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = futokBindingSource;
            dataGridView1.Location = new Point(13, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(771, 265);
            dataGridView1.TabIndex = 1;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            versenyzoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 6;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 125;
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.MinimumWidth = 6;
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            nemzetisegDataGridViewTextBoxColumn.Width = 125;
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.MinimumWidth = 6;
            eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            eredmenyPercDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // futokBindingSource
            // 
            futokBindingSource.DataSource = typeof(Futok);
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(632, 73);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(147, 36);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Mentés";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futokBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(13, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 3;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(635, 119);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(143, 33);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Törlés";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(489, 23);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(127, 39);
            AddButton.TabIndex = 5;
            AddButton.Text = "Hozzáad";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SzamitButton
            // 
            SzamitButton.Location = new Point(489, 77);
            SzamitButton.Name = "SzamitButton";
            SzamitButton.Size = new Size(122, 28);
            SzamitButton.TabIndex = 6;
            SzamitButton.Text = "Számítások";
            SzamitButton.UseVisualStyleBackColor = true;
            SzamitButton.Click += SzamitButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(491, 119);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(120, 25);
            EditButton.TabIndex = 7;
            EditButton.Text = "Szerkesztés";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(EditButton);
            Controls.Add(SzamitButton);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(textBox1);
            Controls.Add(SaveButton);
            Controls.Add(dataGridView1);
            Controls.Add(LoadButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoadButton;
        private DataGridView dataGridView1;
        private Button SaveButton;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource futokBindingSource;
        private TextBox textBox1;
        private Button DeleteButton;
        private Button AddButton;
        private Button SzamitButton;
        private Button EditButton;
    }
}

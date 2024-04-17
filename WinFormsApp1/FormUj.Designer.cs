namespace WinFormsApp1
{
    partial class FormUj
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            futoBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)futoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futoBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(18, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 0;
            // 
            // futoBindingSource
            // 
            futoBindingSource.DataSource = typeof(Futo);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", futoBindingSource, "Nev", true));
            textBox2.Location = new Point(27, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", futoBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(14, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", futoBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(13, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(275, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", futoBindingSource, "Kategoria", true));
            textBox5.Location = new Point(17, 234);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(272, 27);
            textBox5.TabIndex = 4;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(242, 404);
            okButton.Name = "okButton";
            okButton.Size = new Size(45, 30);
            okButton.TabIndex = 5;
            okButton.Text = "&Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(163, 405);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(62, 33);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Mégse";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormUj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 450);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormUj";
            Text = "FormUj";
            Load += FormUj_Load;
            ((System.ComponentModel.ISupportInitialize)futoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button okButton;
        private Button cancelButton;
        private BindingSource futoBindingSource;
    }
}
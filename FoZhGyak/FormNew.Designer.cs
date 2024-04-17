namespace FoZhGyak
{
    partial class FormNew
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            futokBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(251, 404);
            button1.Name = "button1";
            button1.Size = new Size(70, 34);
            button1.TabIndex = 0;
            button1.Text = "&Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(173, 405);
            button2.Name = "button2";
            button2.Size = new Size(70, 29);
            button2.TabIndex = 1;
            button2.Text = "&Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futokBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(31, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 2;
            // 
            // futokBindingSource
            // 
            futokBindingSource.DataSource = typeof(Futok);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", futokBindingSource, "Nev", true));
            textBox2.Location = new Point(31, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", futokBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(29, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", futokBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(28, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", futokBindingSource, "Kategoria", true));
            textBox5.Location = new Point(30, 204);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(277, 27);
            textBox5.TabIndex = 6;
            // 
            // FormNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormNew";
            Text = "FormNew";
            Load += FormNew_Load;
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private BindingSource futokBindingSource;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormUj : Form
    {
        public Futo ujFuto = new Futo();
        public FormUj()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUj_Load(object sender, EventArgs e)
        {
            futoBindingSource.DataSource = ujFuto;
        }
    }
}

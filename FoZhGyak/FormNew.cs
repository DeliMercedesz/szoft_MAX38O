using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoZhGyak
{
    public partial class FormNew : Form
    {
        //Nyolcadik lépés
        public Futok ujFuto = new Futok(); //Osztály új példánya
        public FormNew()
        {
            InitializeComponent();
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            //Kilencedik lépés
            futokBindingSource.DataSource = ujFuto;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

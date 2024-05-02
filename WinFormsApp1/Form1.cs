using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<Futo> futokListaja = new BindingList<Futo>();
        public Form1()
        {
            InitializeComponent();
            futoBindingSource.DataSource = futokListaja;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Futo>();

                foreach (var item in tömb)
                {
                    futokListaja.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(save.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futokListaja);
                    sw.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (futoBindingSource.Current == null) return;
            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futoBindingSource.RemoveCurrent();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FormUj formUj = new FormUj();
            if (formUj.ShowDialog() == DialogResult.OK)
            {
                futoBindingSource.Add(formUj.ujFuto);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (futoBindingSource.Current == null) return;
            FormUj formuj_ketto = new FormUj();
            formuj_ketto.ujFuto = futoBindingSource.Current as Futo;
            formuj_ketto.Show();
        }
    }
}

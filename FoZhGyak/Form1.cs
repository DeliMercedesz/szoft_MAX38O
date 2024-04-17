using CsvHelper;
using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace FoZhGyak
{
    public partial class Form1 : Form
    {
        BindingList<Futok> futok = new BindingList<Futok>();  //Els� l�p�s, lista l�trehoz�sa oszt�ly szinten
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = futok; //M�sodik l�p�s, k�s�bb ez v�ltozni fog!
            futokBindingSource.DataSource = futok; //�t�dik l�p�s, ki kell cser�lni a fels�vel

            //textbox,checkbox k�t�s
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //Harmadik l�p�s, f�jl beolvas�sa

            try
            {
                StreamReader sr = new StreamReader("futottakmeg.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Futok>();

                foreach (var item in t�mb)
                {
                    futok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Hiba�zenet
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Negyedik l�p�s, f�jl ment�s
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(save.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futok);
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
            //Hatodik l�p�s, sor t�rl�s
            if (futokBindingSource.Current == null) return;
            if (MessageBox.Show("T�nyleg t�r�lni szeretn�d a sort?", "Sor t�rl�se!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futokBindingSource.RemoveCurrent();
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Hetedik l�p�s, �j sor hozz�ad�sa

            FormNew formujfuto = new FormNew();

            if (formujfuto.ShowDialog() == DialogResult.OK)  //Ok-kal t�r vissza az �j form akkor megy v�gbe az if-en bel�li r�sz
            {
                //Tizedik l�p�s
                futokBindingSource.Add(formujfuto.ujFuto);
            }
        }

        private void SzamitButton_Click(object sender, EventArgs e)
        {
            //Tizenegyedik l�p�s
            //�tlagsz�m�t�s
            double osszeg = 0;
            int darab = 0;

            foreach (var item in futok)
            {
                if (item.Nemzetiseg == "USA")
                {
                    osszeg += item.EredmenyPerc;
                    darab++;
                }
            }

            //double atlag = osszeg / futok.Count(); - Ha mindegyik benne van
            double atlag = osszeg / darab;

            //Tizenkettedik
            //Leglassabb fut�

            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in futok)
            {
                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;

                }
            }

            MessageBox.Show($"Leggyorsabb futo {leggyorsabb},{minimum} percet futott");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (futokBindingSource.Current == null) return;
            FormNew formNew = new FormNew();
            formNew.ujFuto = futokBindingSource.Current as Futok;
            formNew.Show();

        }
    }
}

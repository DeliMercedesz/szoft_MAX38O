using CsvHelper;
using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace FoZhGyak
{
    public partial class Form1 : Form
    {
        BindingList<Futok> futok = new BindingList<Futok>();  //Elsõ lépés, lista létrehozása osztály szinten
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = futok; //Második lépés, késõbb ez változni fog!
            futokBindingSource.DataSource = futok; //Ötödik lépés, ki kell cserélni a felsõvel

            //textbox,checkbox kötés
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //Harmadik lépés, fájl beolvasása

            try
            {
                StreamReader sr = new StreamReader("futottakmeg.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Futok>();

                foreach (var item in tömb)
                {
                    futok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Hibaüzenet
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Negyedik lépés, fájl mentés
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
            //Hatodik lépés, sor törlés
            if (futokBindingSource.Current == null) return;
            if (MessageBox.Show("Tényleg törölni szeretnéd a sort?", "Sor törlése!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futokBindingSource.RemoveCurrent();
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Hetedik lépés, új sor hozzáadása

            FormNew formujfuto = new FormNew();

            if (formujfuto.ShowDialog() == DialogResult.OK)  //Ok-kal tér vissza az új form akkor megy végbe az if-en belüli rész
            {
                //Tizedik lépés
                futokBindingSource.Add(formujfuto.ujFuto);
            }
        }

        private void SzamitButton_Click(object sender, EventArgs e)
        {
            //Tizenegyedik lépés
            //Átlagszámítás
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
            //Leglassabb futó

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

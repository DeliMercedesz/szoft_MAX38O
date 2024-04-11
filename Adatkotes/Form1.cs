using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatkotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
            
            countryDataBindingSource.DataSource = countryList;
            //dataGridView1.DataSource = countryList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<CountryData>();
            foreach (var item in tomb)
            {
                countryList.Add(item);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCountryData cD = new FormCountryData();
            cD.countryData = countryDataBindingSource.Current as CountryData;
            cD.Show();
        }
    }
}
using CsvHelper;
using System.Globalization;

namespace ZH_Gyakorlas
{
    public partial class Form1 : Form
    {
        Bind
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<VizsgaKérdés>();

                foreach (var items in tömb)
                {

                }


            }
        }
    }
}

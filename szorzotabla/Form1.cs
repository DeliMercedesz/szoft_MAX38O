namespace szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Button b = new Button();
                    //var b1 = new Button();
                    //Button b2 = new();

                    b.Text = (i * j).ToString();
                    b.Left = 100 * i;
                    b.Top = 188 * j;

                    Controls.Add(b);
                }
            }
        }
    }
}
namespace Gyakorlo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            for (int i = 1; i < 11; i++)
            {
                for(int j = 1; j < 11; j++)
                {
                    SzamoloGomb KÓDBÓL = new SzamoloGomb();

                    //KÓDBÓL.Height = 50;
                    //KÓDBÓL.Width = 50;

                    KÓDBÓL.Top = i *110;
                    KÓDBÓL.Left = j * 55;

                    //KÓDBÓL.Text = (j*i).ToString();  

                    Controls.Add(KÓDBÓL);
                }
            }
            */

            /*
            for (int i = 0; i < 100; i++)
            {
                Button uj = new Button();
                Random rnd = new Random();

                int szam1 = rnd.Next(0,255);
                int szam2 = rnd.Next(0,255);

                int szam3 = rnd.Next(0, 255);
                int szam4 = rnd.Next(0, 255);


                uj.Height = szam1;
                uj.Width = szam2;

                uj.Top = szam3;
                uj.Left = szam4;

                uj.BackColor = Color.FromArgb(szam1,szam2,szam3);

                Controls.Add(uj);

            }
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)

                {
                    Button uj = new Button();
                    if (i > j) 
                    {
                        uj.Height = 20;
                        uj.Width = 20;

                        uj.Top = i*20;
                        uj.Left = j * 20;

                        Controls.Add(uj);
                    }
                }
            }
            */
            /*
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j  < 10; j ++)
                {
                    int temp = i;
                    
                    while (i != 0)
                    {
                        Button uj = new Button();
                        uj.Height = 20;
                        uj.Width = 20;
                    }
                }
            }

            */
            
        }
    }
}
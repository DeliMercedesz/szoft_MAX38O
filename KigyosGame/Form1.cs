namespace KigyosGame
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irany_x = 1;
        int irany_y = 0;
        int lepesszam;
        int hossz = 4 ;
        int szamolo;

        List<KigyoElem> kigyo = new List<KigyoElem>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyDown += Form1_KeyDown;
         
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                irany_y = -1;
                irany_x = 0;
            }

            if(e.KeyCode == Keys.Down)
            {
                irany_y = 1;
                irany_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irany_y = 0;
                irany_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                irany_y = 0;
                irany_x = 1;
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lepesszam++;
            
            Random rnd = new Random();
            int randomszam = 200;
            int randomszam2 = 200;

            fej_x += irany_x * KigyoElem.Meret;
            fej_y += irany_y * KigyoElem.Meret;
            
           
            foreach (object item in Controls)  //m�r tudom hova akarom letenni, de m�g nem tettem le
            {
                if(item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;
                    
                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
                
            }


            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kigyo.Add(ke);
            Controls.Add(ke);
            if (kigyo.Count > hossz)  //a controls-on l�v� elemeket sz�molja �s ha el�r a k�v�nt hosszhoz, lev�gja az utols�t mindig
            {
                KigyoElem levagando = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levagando);
            }

            if (lepesszam % 2 == 0) ke.BackColor = Color.Yellow;
            
            if (lepesszam % 3 == 0 && szamolo < 2)
            {
                Alma alma = new Alma();
                alma.Top = randomszam;
                alma.Left = randomszam2;
                Controls.Add (alma);
                szamolo++;

                if (ke.Top == alma.Top && ke.Left == alma.Left)
                {
                    hossz++;
                }

            }
           
        }
    }
}
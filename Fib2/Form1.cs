using System.Runtime.InteropServices;

namespace Fib2
{
    public partial class Form1 : Form
    {
        public Form1()


        { 
            InitializeComponent();

            List<Elem> list = new List<Elem>();

            for (int i = 1; i < 10; i++)
            {
                Button B = new Button();
                B.Top = i * 30;
                B.Text = Fibonacci(i).ToString();
                Controls.Add(B);

                Elem elem = new Elem();
                elem.Sorszam = i;
                elem.Ertek = Fibonacci(i);

                list.Add(elem);

            }

            dataGridView1.DataSource = list;
        }

        class Elem
        {
            public int Sorszam { get; set; }
            public long Ertek { get; set; }



        }

    

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

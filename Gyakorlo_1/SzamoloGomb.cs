using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo_1
{
    internal class SzamoloGomb : Button
    {
        int szam = 0;
        public SzamoloGomb()
        {
            Height = 20;
            Width = 20;

            Click += SzamoloGomb_Click;
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            if (szam == 5)
            { 
                szam = 0;
            }
            else
            {
                szam += 1;
                Text = szam.ToString();
            }
            
        }

        

    }
}

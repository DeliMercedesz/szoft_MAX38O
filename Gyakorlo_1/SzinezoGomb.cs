using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo_1
{
    internal class SzinezoGomb : Button
    {
        public SzinezoGomb()
        {
            Height = 20;
            Width = 20;

            Click += SzinezoGomb_Click;
        }

        private void SzinezoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}

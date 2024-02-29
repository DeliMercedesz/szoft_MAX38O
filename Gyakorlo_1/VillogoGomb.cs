﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo_1
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;

        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void OnMouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Beige;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Programacionlll.Helpers
{
    internal class ButtonsStyles
    {
        public static void ApplyCreateStyle(Button button)
        {
            button.BackColor = Color.FromArgb(0, 120, 215);
            button.ForeColor = Color.White; 
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.AutoSize = true;
            button.Padding = new Padding(8, 4, 8, 4);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 190); 
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 160);  
        }
        public static void ApplyDeleteStyle(Button button)
        {
            button.BackColor = Color.FromArgb(220, 53, 69);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 50);
        }

    }
}

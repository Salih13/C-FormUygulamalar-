using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    class Raket : Button
    {
        public Raket()
        {
            this.Anchor = AnchorStyles.Bottom;
            this.BackColor = Color.Salmon;
            this.Enabled = false;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Location = new Point(274, 407);
            this.Name = "button2";
            this.Size = new Size(170, 18);
            this.TabIndex = 0;
            this.UseVisualStyleBackColor = false;
        }
    }
}

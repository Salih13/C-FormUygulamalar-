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
    public class Sure:Label
    {
        public Sure()
        {
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.ForeColor = SystemColors.ActiveCaptionText;
            this.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
            this.BackColor = SystemColors.MenuHighlight;
            this.Location = new Point(44, 6);
            this.Name = "label1";
            this.Size = new Size(81, 35);
            this.TabIndex = 0;
            this.Text = " 00 : 00 ";
            this.BackColor = SystemColors.ButtonFace;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ForeColor = Color.Crimson;
        }
    }
}

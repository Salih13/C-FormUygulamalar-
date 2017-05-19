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
    class YuksekSkorlar:Button
    {
        private int field;

        public YuksekSkorlar()
        {
            this.BackColor = Color.Salmon;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = Color.Black;
            this.Location = new Point(167, 4);
            this.Name = "button1";
            this.Size = new Size(112, 40);
            this.TabIndex = 1;
            this.Text = "Yüksek Skorlar";
            this.UseVisualStyleBackColor = false;
            
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}

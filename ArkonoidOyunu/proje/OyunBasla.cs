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
    class OyunBasla:Label
    {
        public OyunBasla()
        {
            this.Anchor = AnchorStyles.Right;
            this.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = SystemColors.ActiveCaptionText;
            this.Location = new Point(285, 5);
            this.Name = "label2";
            this.Size = new Size(469, 40);
            this.TabIndex = 2;
            this.Text = "Oyunu başlatmak için tek tıklayın";
            this.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}

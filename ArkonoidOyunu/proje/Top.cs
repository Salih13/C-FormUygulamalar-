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
    class Top : PictureBox
    {
        public Top()
        {
            this.Anchor = ((AnchorStyles)(((AnchorStyles.Left)
           | AnchorStyles.Bottom)));
            this.Image = Image.FromFile("C:\\Users\\asus\\Desktop\\C# form\\butonu_oynatma\\ball.png");
            this.Location = new Point(340, 387);
            this.Name = "pictureBox1";
            this.Size = new Size(20, 20);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.TabIndex = 1;
            this.TabStop = false;
        }
    }
}

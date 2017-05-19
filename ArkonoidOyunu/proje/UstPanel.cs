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
    class UstPanel:Panel
    {
        public UstPanel()
        {
            this.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.BackColor = SystemColors.ActiveCaption;
            
            this.ForeColor = SystemColors.AppWorkspace;
            this.Location = new Point(0, 0);
            this.Name = "panel1";
            this.Size = new Size(766, 47);
            this.TabIndex = 0;
        }
    }
}

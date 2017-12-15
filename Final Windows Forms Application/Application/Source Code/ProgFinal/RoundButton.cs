using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace ProgFinal
{
    class RoundButton : Button      //This class allows for the creation of a new button in a different shape
        {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);       //specify the size, so user can choose by enlarging or decreasing it
                this.Region = new System.Drawing.Region(grPath);
                base.OnPaint(e);
            }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace gomukofinalcs
{
    class cell : Button
    {

        public bool occupy = false;
        public int turn1;
        public cell(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }
    }
}

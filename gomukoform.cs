using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gomukofinalcs
{
    enum player { BLUE, RED };
    public partial class gomuko : Form
    {
        int dim = 0;
        int winc;
        //string p1;
        //string p2;
        player turn = player.BLUE;
        cell[,] Cs;
        public void turnchange()
        {
            if (turn == player.BLUE)
            {
                turn = player.RED;
            }
            else if (turn == player.RED)
            {
                turn = player.BLUE;
            }
        }
        public gomuko()
        {
            InitializeComponent();
        }


        void loadcells()
        {

            Cs = new cell[dim, dim];
            cellspanel.Controls.Clear();
            cell b;
            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    b = new cell(cellspanel.Width / dim - 10, cellspanel.Height / dim - 10);
                    // b.Width = cellspanel.Width / dim-10;
                    //b.Height = cellspanel.Height / dim-10;
                    b.Click += new System.EventHandler(this.Cell_Click);
                    cellspanel.Controls.Add(b);
                    Cs[ri, ci] = b;
                }
            }
        }
        private void Cell_Click(object sender, EventArgs e)
        {
            cell B = (cell)sender;
            if (B.occupy == true)
            {
                MessageBox.Show("cheater");
                return;
            }
            if (turn == player.BLUE)
            {
                B.BackColor = Color.Blue;

                //turnchange();


            }
            else if (turn == player.RED)
            {
                B.BackColor = Color.Red;
                //turnchange();


            }
            B.occupy = true;

            if (iswin(turn))
            {
                MessageBox.Show("who has won the match" + turn.ToString());
                cellspanel.Controls.Clear();
                startbutton.Text = ("replay");
            }

            turnchange();

        }
        bool ishorwin(int ri, int ci, player turn)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < winc; i++)
            {

                if (ci + i < dim && Cs[ri, ci + i].BackColor == Color.Blue && Cs[ri, ci + i].occupy == true)
                {
                    count1++;

                }
                else if (ci + i < dim && Cs[ri, ci + i].BackColor == Color.Red && Cs[ri, ci + i].occupy == true)
                {
                    count2++;
                }
            }
            if (count1 == winc || count2 == winc)
            {
                return true;
            }
            else
                return false;


        }
        bool isverwin(int ri, int ci, player turn)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < winc; i++)
            {
                if (ri + i < dim && Cs[ri + i, ci].BackColor == Color.Blue && turn == player.BLUE && Cs[ri + i, ci].occupy == true)
                {
                    count1++;
                }
                else if (ri + i < dim && Cs[ri + i, ci].BackColor == Color.Red && turn == player.RED && Cs[ri + i, ci].occupy == true)
                {
                    count2++;
                }
            }
            if (count1 == winc || count2 == winc)
            {
                return true;
            }
            else
                return false;


        }
        bool isdiagLtoRwin(int ri, int ci, player turn)
        {
            int count = 0;
            for (int i = 0; i < winc; i++)
            {
                if (ci + i < dim && ri + i < dim && Cs[ri + i, ci + i].occupy == true)
                {
                    count++;
                }
            }
            return count == winc;
        }
        bool isdiagRtoLwin(int ri, int ci, player turn)
        {
            int count = 0;
            for (int i = 0; i < winc; i++)
            {
                if (ci - i > dim && ri + i < dim && Cs[ri + i, ci - i].occupy == true)
                {
                    count++;
                }
            }
            return count == winc;
        }
        bool iswin(player turn)
        {

            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    if (ishorwin(ri, ci, turn) || isverwin(ri, ci, turn)||isdiagLtoRwin(ri, ci, turn) || isdiagRtoLwin(ri, ci, turn))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            //if (threexthree.Checked)
            //    dim = 3;
            //else if (fivexfive.Checked)
            //    dim = 5;
            //else if (tenxten.Checked)
            //    dim = 10;
            dim = int.Parse(customdimension.Text);
            if (dim == 0)
            {
                MessageBox.Show("harami .....select option");
                return;
            }
            //else
            //{
            //    MessageBox.Show(dim.ToString());
            //}
            //if (wincount.Text!="")
            //    winc = Int32.Parse(wincount.Text);
            if (winc <=0&& winc > dim)
            {
                MessageBox.Show(" .....select wincount");
                return;
            }
            else
            {
                winc = int.Parse(wincount.Text);
            }
            loadcells();
        }

       
    }
}



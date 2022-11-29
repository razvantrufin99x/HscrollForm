using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HscrollForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public listaElementeHScroll le = new listaElementeHScroll();
      
        private void Form1_Load(object sender, EventArgs e)
        {
            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem-1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y+le.elemente[le.nrelem - 1].Height*(le.nrelem - 1);
            }
            catch { }

            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y  + le.elemente[le.nrelem - 1].Height* (le.nrelem - 1);
            }
            catch { }

            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }

            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }


            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }


            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }


            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }


            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }

            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }

            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }

            le.AddNew(new elementControl(10, 10));
            try
            {
                Controls.Add(le.elemente[le.nrelem - 1]);
                Controls[le.nrelem - 1].Visible = true;
                Controls[le.nrelem - 1].Left = le.elemente[le.nrelem - 1].X;
                Controls[le.nrelem - 1].Top = le.elemente[le.nrelem - 1].Y + le.elemente[le.nrelem - 1].Height * (le.nrelem - 1);
            }
            catch { }
        
        

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if ( e.Y < Height / 2)
            {
                for (int i = 0; i < le.nrelem; i++)
                {
                    le.elemente[i].Y -= 10;
                    Controls[i].Top = le.elemente[i].Y + le.elemente[i].Height * (i);
                }
            }

            else

            {
                for (int i = 0; i < le.nrelem; i++)
                {
                    le.elemente[i].Y += 10;
                    Controls[i].Top = le.elemente[i].Y + le.elemente[i].Height * (i);

                }
            }
              

       
        }

    
    }
}

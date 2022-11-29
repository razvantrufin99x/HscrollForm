using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HscrollForm
{
    public partial class elementControl : UserControl
    {
        public elementControl()
        {
            InitializeComponent();
        }

        public elementControl(int x, int y)
        {
            InitializeComponent();
            X = x;
            Y = y;
        }
       

        public int X;
        public int Y;
        public Form1 f;

        



        private void elementControl_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }
    }
}

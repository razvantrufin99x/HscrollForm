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
    public class listaElementeHScroll
    {
        public int X=100;
        public int Y=100;
        public int scrollRelativeX=0;
        public int scrollRelativeY=0;
        
        public int nrelem = 0; 
        public List<elementControl> elemente = new List<elementControl>();
        public listaElementeHScroll()
        {
           
        }
        public void AddNew(elementControl elc)
        {
           
            elemente.Add(new elementControl());
            elemente[nrelem]=elc; 
            nrelem++;
           
        }

      
    }
}

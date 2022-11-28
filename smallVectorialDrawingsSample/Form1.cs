using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smallVectorialDrawingsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public shapeResizerFrame srf = new shapeResizerFrame();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(srf.borderMovableSquares[0]);
            this.Controls.Add(srf.borderMovableSquares[1]);
            srf.hideSquareMovableShapesMargin();
             
        }
    }
}

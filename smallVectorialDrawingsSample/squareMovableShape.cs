using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smallVectorialDrawingsSample
{
    public partial class squareMovableShape : movableShape
    {
        public squareMovableShape()
        {
            InitializeComponent();
        }

        private void squareMovableShape_Load(object sender, EventArgs e)
        {
            this.Width = 5;
            this.Height = 5;
        }
    }
}

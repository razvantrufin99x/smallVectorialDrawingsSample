using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace smallVectorialDrawingsSample
{
    public partial class movableShape : UserControl
    {
        public movableShape()
        {
            InitializeComponent();
        }
        public bool ismd = false;
        public bool isSelected = false;
        public Form1 f;
        public void SelectShape()
        {
            SelectControlShape();
            if (isSelected == true) {
                DrawMarginsForResizeIsSelected();
                f.srf.setPositionsOfSquares(this.Left, this.Top, this.Width, this.Height);
                
            }
            else { 
                DrawMarginsForResizeIsNotSelected();
                f.srf.hideSquareMovableShapesMargin();
            }
        }
        public void SelectControlShape()
        {
            if (isSelected == true)
            { isSelected = false; }
            else
            { isSelected = true; }
        }
        public void DrawMarginsForResizeIsSelected()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Refresh();

        }
        public void DrawMarginsForResizeIsNotSelected()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Refresh();

        }
        private void movableShape_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;

        }

        private void movableShape_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                this.BringToFront();
                this.Left += e.X;
                this.Top += e.Y;
                f.srf.setPositionsOfSquares(this.Left, this.Top, this.Width, this.Height);
            }
        }

        private void movableShape_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }

        private void movableShape_Load(object sender, EventArgs e)
        {
            try { f = (Form1)this.ParentForm; }
            catch { }

            
            
        }

        public void setColorTransparent()
        {
            this.BackColor = Color.Transparent;
        }
        public void setEllipseShape()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, this.Width - 4, this.Height - 4);
            //path.CloseAllFigures();
            this.Region = new Region(path);
        }

        public void setShape()
        {

            GraphicsPath path = new GraphicsPath();

            Point[] pointsA = new Point[]
        {
        new Point(0, 0),
        new Point(40, 60),
        new Point(this.Width - 100, 10)
        };
            path.AddCurve(pointsA);

            Point[] pointsB = new Point[]
        {
        new Point(this.Width - 40, this.Height - 60),
        new Point(this.Width, this.Height),
        new Point(10, this.Height)
        };
            path.AddCurve(pointsB);
            path.CloseAllFigures();
            this.Region = new Region(path);
            
        
        }
        private void movableShape_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            SelectShape();
        }
    }
}

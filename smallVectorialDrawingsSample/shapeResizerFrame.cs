using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smallVectorialDrawingsSample
{
    public class shapeResizerFrame 
    {
        public int Left = 0;
        public int Top = 0;
        public int Width = 0;
        public int Heigth = 0;

        public bool Visible = false;

        public List<squareMovableShape> borderMovableSquares = new List<squareMovableShape>();
        
        public shapeResizerFrame()
        {
            borderMovableSquares.Add(new squareMovableShape());
            borderMovableSquares.Add(new squareMovableShape());

        }

        public void setPositionsOfSquares(int x, int y, int w, int h)
        {
           
            borderMovableSquares[0].Left = x - 4;
            borderMovableSquares[0].Top = y - 4;

            borderMovableSquares[1].Left = x+w +4;
            borderMovableSquares[1].Top = y+h + 4;

            showSquareMovableShapesMargin();
        }

        public void showSquareMovableShapesMargin()
        {
            borderMovableSquares[0].Visible = true;
            borderMovableSquares[1].Visible = true;
        }

        public void hideSquareMovableShapesMargin()
        {
            borderMovableSquares[0].Visible = false;
            borderMovableSquares[1].Visible = false;
        }
    }
}

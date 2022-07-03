using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OOP_shapes
{
    public class Shape
    {
        private int xPos, yPos, colourCode, type, xSize, ySize;
        private string name;
        private bool visible;

        public Shape(int reqColour, int x, int y, int reqShape, string reqName)
        {
            colourCode = reqColour;
            xPos = x;
            yPos = y;
            xSize = 76;
            ySize = 76;
            type = reqShape;
            name = reqName;
            visible = true;
        }

        public int X()
        {
            return xPos;
        }

        public int Y()
        {
            return yPos;
        }

        public int Colour()
        {
            return colourCode;
        }

        public int Type()
        {
            return type;
        }

        public string Name()
        {
            return name;
        }

        public void ChangeY(int moveAmount)
        {
            yPos = yPos + moveAmount;
        }

        public void ChangeX(int moveAmount)
        {
            xPos = xPos + moveAmount;
        }

        public bool Visibility()
        {
            return visible;
        }

        public void SetVisible(bool visibleStatus)
        {
            visible = visibleStatus;
        }

        public void MoveHorizontally(int amount)
        {
            xPos = xPos + amount;
        }

        public void MoveVertically(int amount)
        {
            yPos = yPos + amount;
        }

        public void ChangeSize(int width, int height)
        {
            xSize = width;
            ySize = height;
        }

        public int Width()
        {
            return xSize;
        }

        public int Height()
        {
            return ySize;
        }
    }
}

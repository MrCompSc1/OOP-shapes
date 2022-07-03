using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_shapes
{
    public partial class MainScreen : Form
    {
        // List of all shapes created
        private List<Shape> shapes;

        // Canvas to draw on
        private Graphics canvas;

        // Next available spot to place next new shape
        private int nextX, nextY;

        // Different coloured brushes used to paint on canvas
        private Brush redBrush = new SolidBrush(Color.Red);
        private Brush blueBrush = new SolidBrush(Color.Blue);
        private Brush yellowBrush = new SolidBrush(Color.Yellow);

        // Shape count for naming purposes
        private int nextCircle = 1;
        private int nextTriangle = 1;
        private int nextRectangle = 1;

        public MainScreen()
        {
            InitializeComponent();

            shapes = new List<Shape>();
            canvas = CreateGraphics();

            // First shape starting coordinates
            nextX = 50;
            nextY = 50;
        }

        private void DrawCircle(int reqX, int reqY, int reqBrush, int width, int height)
        {
            // Uses brush to paint circle with top left portion nextX from left, 
            // nextY from top with horizontal & vertical diameters
            // and colour selected from radio buttons
            if (reqBrush == 1)
            {
                canvas.FillEllipse(redBrush, reqX, reqY, width, height);
            }
            else if (reqBrush == 2)
            {
                canvas.FillEllipse(blueBrush, reqX, reqY, width, height);
            }
            else
            {
                canvas.FillEllipse(yellowBrush, reqX, reqY, width, height);
            }
        }

        private void DrawTriangle(int reqX, int reqY, int reqBrush, int width, int height)
        {
            // All points calculated from top left of shape boundary
            Point point1 = new Point(reqX + (int)width/2, reqY);
            Point point2 = new Point(reqX, reqY + height);
            Point point3 = new Point(reqX + width, reqY + height);
            Point[] sides = { point1, point2, point3 };

            // Uses brush to paint triangle with dimensions from array above
            // and colour selected from radio buttons
            if (reqBrush == 1)
            {
                canvas.FillPolygon(redBrush, sides);
            }
            else if (reqBrush == 2)
            {
                canvas.FillPolygon(blueBrush, sides);
            }
            else
            {
                canvas.FillPolygon(yellowBrush, sides);
            }
        }

        private void DrawRectangle(int reqX, int reqY, int reqBrush, int width, int height)
        {
            // All points calculated from top left of shape boundary
            Point point1 = new Point(reqX, reqY);
            Point point2 = new Point(reqX, reqY + height);
            Point point3 = new Point(reqX + width, reqY + height);
            Point point4 = new Point(reqX + width, reqY);

            Point[] sides = { point1, point2, point3, point4 };

            // Uses brush to paint rectangle with dimensions from array above
            // and colour selected from radio buttons
            if (reqBrush == 1)
            {
                canvas.FillPolygon(redBrush, sides);
            }
            else if (reqBrush == 2)
            {
                canvas.FillPolygon(blueBrush, sides);
            }
            else
            {
                canvas.FillPolygon(yellowBrush, sides);
            }
        }

        private void DrawShapes()
        {
            canvas.Clear(SystemColors.Control);

            foreach (Shape shape in shapes)
            {
                // Type 1 shapes are circles
                if (shape.Type() == 1 && shape.Visibility() == true)
                {
                    DrawCircle(shape.X(), shape.Y(), shape.Colour(), shape.Width(), shape.Height());
                }
                // Type 2 triangles
                else if (shape.Type() == 2 && shape.Visibility() == true)
                {
                    DrawTriangle(shape.X(), shape.Y(), shape.Colour(), shape.Width(), shape.Height());
                }
                // Type 3 rectangle
                else if (shape.Type() == 3 && shape.Visibility() == true)
                {
                    DrawRectangle(shape.X(), shape.Y(), shape.Colour(), shape.Width(), shape.Height());
                }
            }
        }

        private void MainScreen_Resize(object sender, EventArgs e)
        {
            DrawShapes();
        }

        private void addTriangleBtn_Click(object sender, EventArgs e)
        {
            int colourSelected;

            if (redSelected.Checked)
            {
                colourSelected = 1;
            }
            else if (blueSelected.Checked)
            {
                colourSelected = 2;
            }
            else
            {
                colourSelected = 3;
            }

            // Create new instance of Shape (2 used as parameter as this is the addTriangle button)
            Shape newShape = new Shape(colourSelected, nextX, nextY, 2, "Triangle" + nextTriangle);
            // Add name to control combo
            shapenamesCombo.Items.Add("Triangle" + nextTriangle);

            nextTriangle = nextTriangle + 1;
            AddShape(newShape);
        }

        private void addCircleBtn_Click(object sender, EventArgs e)
        {
            int colourSelected;

            if (redSelected.Checked)
            {
                colourSelected = 1;
            }
            else if (blueSelected.Checked)
            {
                colourSelected = 2;
            }
            else
            {
                colourSelected = 3;
            }

            // Create new instance of Shape (1 used as parameter as this is the addCircle button)
            Shape newShape = new Shape(colourSelected, nextX, nextY, 1, "Circle" + nextCircle);
            // Add name to control combo
            shapenamesCombo.Items.Add("Circle" + nextCircle);

            AddShape(newShape);
            nextCircle = nextCircle + 1;
        }

        private void addRectangleBtn_Click(object sender, EventArgs e)
        {
            int colourSelected;

            if (redSelected.Checked)
            {
                colourSelected = 1;
            }
            else if (blueSelected.Checked)
            {
                colourSelected = 2;
            }
            else
            {
                colourSelected = 3;
            }

            // Create new instance of Shape (3 used as parameter as this is the addRectangle button)
            Shape newShape = new Shape(colourSelected, nextX, nextY, 3, "Rectangle" + nextRectangle);
            // Add name to control combo
            shapenamesCombo.Items.Add("Rectangle" + nextRectangle);

            AddShape(newShape);
            nextRectangle = nextRectangle + 1;
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {
            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                // Find shape from its name
                Shape selectedShape = shapes.Find(x => x.Name() == shapenamesCombo.SelectedItem.ToString());
                // Move shape's position
                selectedShape.ChangeY(-20);
                DrawShapes();
            }
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                // Find shape from its name
                Shape selectedShape = shapes.Find(x => x.Name() == shapenamesCombo.SelectedItem.ToString());
                // Move shape's position
                selectedShape.ChangeX(20);
                DrawShapes();
            }
        }

        private void shapenamesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find shape from its name
            Shape selectedShape = shapes.Find(x => x.Name() == shapenamesCombo.SelectedItem.ToString());
            if (selectedShape.Visibility() == true)
            {
                visibleCheck.Checked = true;
            }
            else
            {
                visibleCheck.Checked = false;
            }
        }

        private void visibleCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Find shape from its name
            Shape selectedShape = shapes.Find(x => x.Name() == shapenamesCombo.SelectedItem.ToString());

            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                selectedShape.SetVisible(visibleCheck.Checked);
            }

            DrawShapes();
        }

        private void moveHorzBtn_Click(object sender, EventArgs e)
        {
            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                HorzPrompt prompt = new HorzPrompt(shapenamesCombo.SelectedItem.ToString(), shapes);
                prompt.ShowDialog();
            }
        }

        private void MainScreen_Activated(object sender, EventArgs e)
        {
            DrawShapes();
        }

        private void moveVertBtn_Click(object sender, EventArgs e)
        {
            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                VertPrompt prompt = new VertPrompt(shapenamesCombo.SelectedItem.ToString(), shapes);
                prompt.ShowDialog();
            }
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                DimensionsPrompt prompt = new DimensionsPrompt(shapenamesCombo.SelectedItem.ToString(), shapes);
                prompt.ShowDialog();
            }
        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {
            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                // Find shape from its name
                Shape selectedShape = shapes.Find(x => x.Name() == shapenamesCombo.SelectedItem.ToString());
                // Move shape's position
                selectedShape.ChangeY(20);
                DrawShapes();
            }
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            // Check that an object has been selected in combo
            if (shapenamesCombo.SelectedItem == null)
            {
                MessageBox.Show("No object selected - cannot proceed");
            }
            else
            {
                // Find shape from its name
                Shape selectedShape = shapes.Find(x => x.Name() == shapenamesCombo.SelectedItem.ToString());
                // Move shape's position
                selectedShape.ChangeX(-20);
                DrawShapes();
            }
        }

        private void AddShape(Shape shapeToAdd)
        {
            shapes.Add(shapeToAdd);

            // Move X point to next position
            nextX = nextX + 76;

            // Move next shapes down if no more room
            if (nextX > MainScreen.ActiveForm.Width - 200)
            {
                nextX = 50;
                nextY = nextY + 76;
            }

            DrawShapes();
        }
    }
}

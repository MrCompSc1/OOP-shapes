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
    public partial class DimensionsPrompt : Form
    {
        private List<Shape> importedShapes;

        public DimensionsPrompt(string selectedShape, List<Shape> shapes)
        {
            InitializeComponent();

            shapeLbl.Text = selectedShape;

            // Private local list points to reference of supplied parameter
            // so changes made here are reflected back in main form
            importedShapes = shapes;

            // Find shape using its name
            Shape foundShape = importedShapes.Find(x => x.Name() == shapeLbl.Text);

            // Update text boxes with current sizes
            xSizeBox.Text = foundShape.Width().ToString();
            ySizeBox.Text = foundShape.Height().ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int newXSize, newYSize;

            // Make sure inputs are integers as method expects it
            bool xParsedSuccessfully = int.TryParse(xSizeBox.Text, out newXSize);
            bool yParsedSuccessfully = int.TryParse(ySizeBox.Text, out newYSize);

            if (xParsedSuccessfully == false || yParsedSuccessfully == false)
            {
                MessageBox.Show("Needs integer values only to resize.");
            }
            else
            {
                // Find shape using its name
                Shape selectedShape = importedShapes.Find(x => x.Name() == shapeLbl.Text);
                // Move it
                selectedShape.ChangeSize(newXSize, newYSize);
                this.Close();
            }
        }
    }
}

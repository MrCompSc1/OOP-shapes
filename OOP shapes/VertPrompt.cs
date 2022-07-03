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
    public partial class VertPrompt : Form
    {
        private List<Shape> importedShapes;

        public VertPrompt(string selectedShape, List<Shape> shapes)
        {
            InitializeComponent();

            shapeLbl.Text = selectedShape;

            // Private local list points to reference of supplied parameter
            // so changes made here are reflected back in main form
            importedShapes = shapes;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int moveAmount;

            // Make sure input is an integer as method expects it
            bool parsedSuccessfully = int.TryParse(moveAmountBox.Text, out moveAmount);

            if (parsedSuccessfully == false)
            {
                MessageBox.Show("Needs an integer value to move.");
            }
            else
            {
                // Find shape using its name
                Shape selectedShape = importedShapes.Find(x => x.Name() == shapeLbl.Text);
                // Move it
                selectedShape.MoveVertically(moveAmount);
                this.Close();
            }
        }
    }
}

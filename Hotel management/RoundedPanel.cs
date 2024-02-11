using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hotel_management
{
    public class RoundedPanel : Panel
    {
        public RoundedPanel()
        {
            // Set properties for rounded borders
            this.BackColor = Color.FromArgb(150, Color.White); // Transparent background color
            this.BorderStyle = BorderStyle.None; // No border
            this.Paint += RoundedPanel_Paint; // Event handler for custom painting
        }

        private void RoundedPanel_Paint(object sender, PaintEventArgs e)
        {
            // Create a rounded rectangle for custom painting
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            int radius = 10; // Adjust the radius to change the roundness of the corners
            GraphicsPath path = RoundedRectangle.Create(rect, radius);
            this.Region = new Region(path);
        }
    }

    // Helper class to create a rounded rectangle
    public static class RoundedRectangle
    {
        public static GraphicsPath Create(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc
            path.AddArc(arc, 180, 90);

            // top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}

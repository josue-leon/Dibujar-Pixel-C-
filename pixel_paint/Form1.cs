using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixel_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color objcolor;
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int x, y, dim;

            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);
            dim = int.Parse(txtTamaño.Text);

            Graphics g = marco.CreateGraphics();

            // Obtener los valores actuales del TrackBar
            int pixelCount = trackBar.Value;
            Color pixelColor = objcolor;

            // Borrar los píxeles anteriores con el método Clear
            //g.Clear(Color.White);

            // Dibujar los nuevos píxeles con la clase PixelDrawer
            DibujarPixel.DrawPixels(g, new Point(x, y), new Size(dim, dim), pixelColor, pixelCount);
            
            // Liberar los recursos del objeto Graphics
            g.Dispose();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
              objcolor= colorDlg.Color;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void marco_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

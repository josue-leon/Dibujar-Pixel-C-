using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pixel_paint
{
    public class DibujarPixel
    {
        public static void DrawPixels(Graphics graphics, Point position, Size pixelSize, Color color, int count)
        {
            // Crear un pincel con el color especificado
            Brush brush = new SolidBrush(color);

            // Dibujar cada píxel
            for (int i = 0; i < count; i++)
            {
                // Calcular la posición del píxel actual
                Point pixelPosition = new Point(position.X + (i * pixelSize.Width), position.Y);

                // Dibujar el píxel actual
                graphics.FillRectangle(brush, new Rectangle(pixelPosition, pixelSize));
            }

            // Liberar los recursos del pincel
            brush.Dispose();
        }
    }
}

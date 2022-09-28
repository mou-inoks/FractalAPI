using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Form1 : Form
    {
        int hauteur = 0;
        int largeur = 0;

        int m = -1; // pour s'éloigner de l'axe des x 
        int segment = 70;

        double angle = 60; // angle avec lequel on va connecter le triangle
        Graphics graphics;
        Brush brush;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            hauteur = pan.Height;
            largeur = pan.Width;
            brush = new SolidBrush(Color.White);
            pen = new Pen(brush, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pan_Paint(object sender, PaintEventArgs e)
        {
            hauteur = pan.Height;
            largeur = pan.Width;
            int x0 = largeur / 2;
            int y0 = hauteur + m * 30 ; // on ne veut pas être au centre de l'image, on veut être en bas et remonter 

            graphics = pan.CreateGraphics();
            graphics.Clear(pan.BackColor);


            //  x0 = premier point d'entré       y0 = second point d'entré    x0 num 2 = point de sortie y2 = second point de sortie 
            graphics.DrawLine(pen, x0, y0, x0 + 180, y0 );
            graphics.DrawLine(pen, x0 *-segment, y0 * -30, x0 + 180, y0 + m);
        }
    }
}
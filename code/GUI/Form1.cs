using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Pen blackpen = new Pen(Color.Black);
        private Brush whitebrush = new SolidBrush(Color.White);
        private int squareSize = 30;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = Grid.CreateGraphics();
        }
        private void drawSquare(int col,int row ,Pen pen, Brush fill)
        {
            g.DrawRectangle(pen, col * squareSize, row * squareSize, squareSize, squareSize);
            if (fill != null)
            {
                g.FillRectangle(fill, col * squareSize + 1, row * squareSize + 1, squareSize - 1, squareSize - 1);
            }
        }
        private void DrawBoard(int BoardSize)
        {
            for (int C = 0; C < BoardSize; C++)
            {
                for (int R = 0; R < BoardSize; R++)
                {
                    Brush brush = whitebrush;
                    drawSquare(C, R, blackpen, whitebrush);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void diChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void newgame_Click(object sender, EventArgs e)
        {
            DrawBoard(3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

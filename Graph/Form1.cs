using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        Node[] nodes;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            nodes = new Node[2];

            for (int i = 0; i < 2; i++)
            {
                nodes[i] = new Node();
                nodes[i].Left = rand.Next(100, 1000);
                nodes[i].Top = rand.Next(100, 500);     
            }
         }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush aBrush = (Brush)Brushes.Black;
            Graphics g = e.Graphics;
            
            for (int i = 0; i < 2; i++)
            {
                g.FillRectangle(aBrush, nodes[i].Left, nodes[i].Top, 10, 10);
            }
        }
    }
}

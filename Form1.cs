using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindingClosestPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mye=(MouseEventArgs) e;
            System.Drawing.Pen myPen = new Pen(Color.Red,1);
            Graphics panelGragh = panel1.CreateGraphics();
            panelGragh.DrawEllipse(myPen, mye.Location.X, mye.Location.Y, 2, 2);            
            
        }

    }
}

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
        AxisWithPoints AxisWithPoints1=new AxisWithPoints();
        
        System.Drawing.Pen myRedPen = new Pen(Color.Red, 1);
        Graphics panelGragh;

        public Form1()
        {
            InitializeComponent();
            panelGragh = panel1.CreateGraphics();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mye = (MouseEventArgs)e;
            int x = mye.Location.X;
            int y = mye.Location.Y;
            panelGragh.DrawEllipse(myRedPen, x, y, 2, 2);
            addPointsInGrid1(x, y);
            AxisWithPoints1.addPoints(x, y);

        }

        void addPointsInGrid1(double x,double y){
            pointsGridDraw.Rows.Add(x,y);
        }

        private void buttonClearDraw_Click(object sender, EventArgs e)
        {
            AxisWithPoints1 = new AxisWithPoints();
            panelGragh.Clear(panel1.BackColor);
            pointsGridDraw.Rows.Clear();

        }

    }
}

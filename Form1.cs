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
        System.Drawing.Pen myBluePen = new Pen(Color.Blue, 1);
        System.Drawing.SolidBrush myBlueBrush = new SolidBrush(Color.Blue);
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

        private void buttonFindDraw_Click(object sender, EventArgs e)
        {
            textLogging("开始寻找于" + DateTime.Now.ToLongTimeString());
            textLogging("共计" + AxisWithPoints1.Points.Count.ToString() + "个点");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            double[][] closestPoints=AxisWithPoints1.FindClosestPointsPublic();
            watch.Stop();
            panelGragh.FillEllipse(myBlueBrush, (int)closestPoints[0][0], (int)closestPoints[0][1], 3, 3);
            panelGragh.FillEllipse(myBlueBrush, (int)closestPoints[1][0], (int)closestPoints[1][1], 3, 3);
            textLogging("结束寻找于" + DateTime.Now.ToLongTimeString());
            textLogging("共计耗时"+watch.ElapsedMilliseconds.ToString()+"毫秒");
        }

        public void textLogging(string str)
        {
            textBox2.Text += str + Environment.NewLine;
        }

    }
}

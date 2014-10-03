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
            if (AxisWithPoints1.Points.Count <= 1)
            {
                textLogging("error:点数太少");
                return;
            }
            textLogging("开始寻找于" + DateTime.Now.ToLongTimeString());
            textLogging("共计" + AxisWithPoints1.Points.Count.ToString() + "个点");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            double[][] closestPoints=AxisWithPoints1.FindClosestPointsPublic();
            watch.Stop();
            panelGragh.FillEllipse(myBlueBrush, (int)closestPoints[0][0], (int)closestPoints[0][1], 5, 5);
            panelGragh.FillEllipse(myBlueBrush, (int)closestPoints[1][0], (int)closestPoints[1][1], 5, 5);
            textLogging("结束寻找于" + DateTime.Now.ToLongTimeString());
            textLogging("共计耗时"+watch.ElapsedMilliseconds.ToString()+"毫秒");
        }

        public void textLogging(string str)
        {
            textBox2.Text += str + Environment.NewLine;
        }

        private void buttonRandomAndFind_Click(object sender, EventArgs e)
        {
            int RandomPointsNumber = Convert.ToInt32(textBoxRandomNumer.Text);
            if (RandomPointsNumber <= 1)
            {
                textLogging("error:点数太少");
                return;
            }
            var AxisWithPoints2 = new AxisWithPoints(RandomPointsNumber);
            textLogging("开始寻找于" + DateTime.Now.ToLongTimeString());
            textLogging("共计" + AxisWithPoints2.Points.Count.ToString() + "个点");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            double[][] closestPoints = AxisWithPoints2.FindClosestPointsPublic();
            watch.Stop();
            richTextBoxOutputResult.Text = "两点为" + pointsToString(closestPoints[0]) + "与" + pointsToString(closestPoints[1]);
            textLogging("结束寻找于" + DateTime.Now.ToLongTimeString());
            textLogging("共计耗时" + watch.ElapsedMilliseconds.ToString() + "毫秒");
           
        }

        string pointsToString(double[] points)
        {
            return "(" + points[0].ToString() + "," + points[1].ToString() + ")";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int maxPower = 16;
            int minPoewr = 8;
            dataGridViewTimeComplex.Rows.Add(maxPower-1-minPoewr);
            for (int i = 0; i < maxPower-minPoewr; i++)
            {
                dataGridViewTimeComplex.Rows[i].Cells[0].Value =(int) Math.Pow(2, i+minPoewr);
            }
        }

        private void calnLogn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewTimeComplex.Rows.Count; i++)
            {
                int pointsNumber = 0;
                try
                {
                    pointsNumber = (int)dataGridViewTimeComplex.Rows[i].Cells[0].Value;
                }
                catch (Exception excep) { textLogging(excep.ToString()); continue; }
                if (pointsNumber < 1) continue;
                AxisWithPoints AxisWithPoints3 = new AxisWithPoints(pointsNumber);
                textLogging("开始寻找于" + DateTime.Now.ToLongTimeString());
                textLogging("共计" + AxisWithPoints3.Points.Count.ToString() + "个点");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                AxisWithPoints3.FindClosestPointsPublic();
                watch.Stop();
                textLogging("结束寻找于" + DateTime.Now.ToLongTimeString());
                textLogging("共计耗时" + watch.ElapsedMilliseconds.ToString() + "毫秒");
                dataGridViewTimeComplex.Rows[i].Cells[1].Value = watch.ElapsedMilliseconds;
            }
        }

        private void caln2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewTimeComplex.Rows.Count; i++)
            {
                int pointsNumber = 0;
                try
                {
                    pointsNumber = (int)dataGridViewTimeComplex.Rows[i].Cells[0].Value;
                }
                catch (Exception excep) { textLogging(excep.ToString()); continue; }
                if (pointsNumber < 1) continue;
                AxisWithPoints AxisWithPoints3 = new AxisWithPoints(pointsNumber);
                textLogging("n^2开始寻找于" + DateTime.Now.ToLongTimeString());
                textLogging("n^2共计" + AxisWithPoints3.Points.Count.ToString() + "个点");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                AxisWithPoints3.FindClosestn2();
                watch.Stop();
                textLogging("n^2结束寻找于" + DateTime.Now.ToLongTimeString());
                textLogging("n^2共计耗时" + watch.ElapsedMilliseconds.ToString() + "毫秒");
                dataGridViewTimeComplex.Rows[i].Cells[2].Value = watch.ElapsedMilliseconds;
            }
        }

        //缩放窗口或最小化还原窗口后重画图形。需要重新取得panel大小。
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panelGragh.Clear(panel1.BackColor);
            panelGragh = panel1.CreateGraphics();
            foreach (double[] point in AxisWithPoints1.Points)
            {
                panelGragh.DrawEllipse(myRedPen, (int)point[0], (int)point[1], 2, 2);
            }
        }

    }
}

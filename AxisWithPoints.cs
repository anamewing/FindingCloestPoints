using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingClosestPoints
{
    class AxisWithPoints
    {
        public List<double[]> Points =new List<double[]>();

        public void addPoints(double x,double y){
            Points.Add(new double[]{x,y});
        }

        //分治法求最近点
        public double[][] FindClosest(List<double[]> PointsList)
        {
            double[][] nearPoints=new double[2][];
            //点数小于等于3时直接求最近点
            if (PointsList.Count==3){
                double d1=distance2Points(PointsList[0],PointsList[1]);
                double d2=distance2Points(PointsList[0],PointsList[2]);
                double d3=distance2Points(PointsList[1],PointsList[2]);
                if(d1<=d2){
                    nearPoints[0]=(PointsList[1]);
                    if(d1<=d3){
                        nearPoints[1]=(PointsList[0]);
                    }
                    else{
                        nearPoints[1]=(PointsList[2]);
                    }
                }else{
                    nearPoints[0]=(PointsList[2]);
                    if(d2<=d3){
                        nearPoints[1]=(PointsList[0]);
                    }else{
                       nearPoints[1]=(PointsList[1]);
                    }
                }
                return nearPoints;
            }
            else if (PointsList.Count == 2)
            {
                nearPoints[0] = PointsList[0];
                nearPoints[1] = PointsList[1];
                return nearPoints;
            }

            //分
            PointsList.Sort(SortByX);
            int halfLength=(int)Math.Floor(PointsList.Count/2.0);

            //治
            double[][] nearPoints1 = FindClosest(PointsList.Take(halfLength).ToList<double[]>());
            double[][] nearPoints2 = FindClosest(PointsList.Skip(halfLength).ToList<double[]>());

            //合
            double neard1 = distance2Points(nearPoints1[0], nearPoints1[1]);
            double neard2 = distance2Points(nearPoints2[0], nearPoints2[1]);
            double neard;
            if (neard1 <= neard2)
            {
                neard = neard1;
                nearPoints = nearPoints1;
            }
            else
            {
                neard = neard2;
                nearPoints = nearPoints2;
            }
            double halfX=PointsList[halfLength][0];
            List<double[]> HalfLinePoints = new List<double[]>();
            foreach (double[] point in PointsList)
            {
                if (Math.Abs(point[0] - halfX) < neard) HalfLinePoints.Add(point);
            }
            HalfLinePoints.Sort(SortByY);
            for (int i = 0; i < HalfLinePoints.Count; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    if ((i + j) >= HalfLinePoints.Count) continue;
                    double tempD = distance2Points(HalfLinePoints[i], HalfLinePoints[i + j]);
                    if (tempD < neard)
                    {
                        neard = tempD;
                        nearPoints[0] = HalfLinePoints[i];
                        nearPoints[1] = HalfLinePoints[i + j];
                    }
                }
            }
            return nearPoints;
        }

        public double[][] FindClosestPointsPublic()
        {
            return FindClosest(Points);
        }

        double distance2Points(double[] point1, double[] point2)
        {
            return Math.Sqrt(Math.Pow(point1[0]-point2[0],2)+Math.Pow(point1[1]-point2[1],2));
        }

        static int SortByX(double[] point1, double[] point2)
        {
            return point1[0].CompareTo(point2[0]);
        }

        static int SortByY(double[] point1, double[] point2)
        {
            return point1[1].CompareTo(point2[1]);
        }

    }
}

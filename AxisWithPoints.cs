using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingClosestPoints
{
    class AxisWithPoints
    {
        List<double[]> Points =new List<double[]>();

        public void addPoints(double x,double y){
            Points.Add(new double[]{x,y});
        }

        //分治法求最近点
        public double[][] FindClosest(List<double[]> PointsList)
        {
            double[][] nearPoints=new double[2][];
            //点数小于等于3时直接求最近点
            if (PointsList.Count<=3){
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

            //分
            PointsList.Sort(SortByX);
            int halfLength=(int)Math.Floor(PointsList.Count/2.0);

            //治
            double[][] nearPoints1 = FindClosest(PointsList.Take(halfLength) as List<double[]>);
            double[][] nearPoints2 = FindClosest(PointsList.Skip(halfLength) as List<double[]>);

            //合


             







        }

        double distance2Points(double[] point1,double[] point2)
        {
            return Math.Sqrt(Math.Pow(point1[0]-point2[0],2)+Math.Pow(point1[1]-point2[1],2));
        }

        static int SortByX(double[] point1, double[] point2)
        {
            return point1[0].CompareTo(point2[0]);
        }

    }
}

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

        


    }
}

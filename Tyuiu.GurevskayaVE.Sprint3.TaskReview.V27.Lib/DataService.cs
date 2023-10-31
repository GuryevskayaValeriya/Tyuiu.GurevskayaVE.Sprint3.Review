using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.GurevskayaVE.Sprint3.TaskReview.V27.Lib
{
    public class DataService
    {
        public double[] Calc(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                
                y = Math.Round((Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x), 2);
                valueArray[4] = 0;
                valueArray[cnt] = y;
                cnt++;
            }

            return valueArray;
        }
    }
}

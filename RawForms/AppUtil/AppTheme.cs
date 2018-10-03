using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawForms.AppUtil
{
   public static class AppTheme
    {
      
        public static int[] SetAppTheme()
        {
            var color = AppTheme.GetAppThemeColor();
            int[] rgbArr = new int[3];
            rgbArr[0] = ((int)(((byte)(color[0]))));
            rgbArr[1] = ((int)(((byte)(color[1]))));
            rgbArr[2] = ((int)(((byte)(color[2]))));
            return rgbArr;
        }
        public static int[] GetAppThemeColor(int? r=0,int? g=0, int? b=0)
        {
            int[] arrRGB = new int[3];
            if (r == 0 && g == 0 && b == 0)
            {
                arrRGB[0] = 0;
                arrRGB[1] = 122;
                arrRGB[2] = 204;
            }
            else
            {
                arrRGB[0] =(int) r;
                arrRGB[1] = (int)g;
                arrRGB[2] =(int) b;
            }
            return arrRGB;
        }
    }
}

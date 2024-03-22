using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Schet : ISchet
    {
        public string GetSize(string sizeS, string country)
        {
            int sizeNumber = 0;

            double[] russianSize = { 37.5, 38, 39, 39.5, 40, 41, 41.5, 42, 43, 43.5, 44, 44.5, 45, 46, 47 };
            double[] americanSize = { 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5, 13, 13.5 };
            double[] europeanSize = { 38.5, 39, 40, 40.5, 41, 42, 42.5, 43, 44, 44.5, 45, 46, 46.5, 47, 48 };
            double[] physicalSize = { 24.1, 24.4, 24.8, 25.4, 25.7, 26, 26.7, 27, 27.3, 27.9, 28.3, 28.6, 29, 29.4, 30 };


            if (sizeS == string.Empty)
            {
                return "Uncorrect size";
            }

            double size = Convert.ToDouble(sizeS);

            if (size < 24.1 || size > 30)
            {
                return "Uncorrect size";
            }
            else if (country == "")
            {
                return "Uncorrect country";
            }
            else
            {
                while (true)
                {
                    if (sizeNumber == 14)
                        break;
                    if (size >= physicalSize[sizeNumber + 1])
                    {
                        sizeNumber++;
                        continue;
                    }
                    break;
                }

                if (country == "American")
                {
                    return Convert.ToString(americanSize[sizeNumber]);
                }
                else if (country == "Russian")
                {
                    return Convert.ToString(russianSize[sizeNumber]);
                }
                else if (country == "European")
                {
                    return Convert.ToString(europeanSize[sizeNumber]);
                }
            }

            return "Error";
        }
    }
}

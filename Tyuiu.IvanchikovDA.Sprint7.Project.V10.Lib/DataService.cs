using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.IvanchikovDA.Sprint7.Project.V10.Lib
{
    public class SalesData
    {
        public string Month { get; set; }
        public int Sales { get; set; }
    }
    public class YearsData
    {
        public string Year { get; set; }
        public int Sales { get; set; }
    }
    public class PriceItems
    {
        public int GetPrice(string item)
        {
            switch (item)
            {
                case "молоко 1л":
                    return 80;  
                case "сметана домашняя":
                    return 115;
                case "сыр российский 250г":
                    return 207;
                case "творог 5% 300г":
                    return 105;
                case "творог 10% 300г":
                    return 130;
                case "сыр адыгейский 250г":
                    return 260;
                case "сыр гауда 250г":
                    return 215;
                case "сыр пошехонский 250г":
                    return 210;
                case "сыр сулугуни 250г":
                    return 250;
                case "буханка хлеба":
                    return 40;
                case "батон":
                    return 58;
                case "батон нарезной":
                    return 56;
                case "булка с маком":
                    return 78;
                case "булка с повидлом":
                    return 35;
                case "сливочное масло 82% 250г":
                    return 150;
                default:
                    return 0;
            }
        }
    }
        public class SalesDataCollection : List<SalesData>
        {
            public SalesDataCollection()
            {
                Add(new SalesData { Month = "Январь", Sales = 75 });
                Add(new SalesData { Month = "Февраль", Sales = 85 });
                Add(new SalesData { Month = "Март", Sales = 35 });
                Add(new SalesData { Month = "Апрель", Sales = 55 });
                Add(new SalesData { Month = "Май", Sales = 38 });
                Add(new SalesData { Month = "Июнь", Sales = 40 });
                Add(new SalesData { Month = "Июль", Sales = 23 });
                Add(new SalesData { Month = "Август", Sales = 42 });
                Add(new SalesData { Month = "Сентябрь", Sales = 51 });
                Add(new SalesData { Month = "Октябрь", Sales = 63 });
                Add(new SalesData { Month = "Ноябрь", Sales = 81 });
                Add(new SalesData { Month = "Декабрь", Sales = 95 });
            }

        }
    public class YearsDataCollection : List<YearsData>
    {
        public YearsDataCollection()
        {
            Add(new YearsData { Year = "2019", Sales = 50 });
            Add(new YearsData { Year = "2020", Sales = 150 });
            Add(new YearsData { Year = "2021", Sales = 180 });
            Add(new YearsData { Year = "2022", Sales = 200 });
            Add(new YearsData { Year = "2023", Sales = 650 });
        }
    }
    

}

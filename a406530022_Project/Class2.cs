using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a406530022_Project
{
    public class Class2
    {
    }
    public class Date
    {
        private int day;
        private int month;
        private int year;
        public Date()
        {
            year = 2000;
            month = 1;
            day = 1;
        }
        public Date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        public void setDate(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        public string show()
        {
            return year + "-" + month + "-" + day;
        }
        public int getYear()
        {
            return year;
        }
        public int getMonth()
        {
            return month;
        }
        public int getDay()
        {
            return day;
        }
    }
}

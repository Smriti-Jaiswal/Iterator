using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace WindowsIterator
{
    class clsDay
    {
        public string Day = "";
        public string Code = "";
    }
    class clsIterator
    {
        private int intCurrentIndex = 0;
        private ArrayList objArray = new ArrayList();
        public void FillObjects()
        {
            clsDay objDay = new clsDay();
            objDay.Day = "Sunday";
            objDay.Code = "1";
            objArray.Add(objDay);

            objDay = new clsDay();
            objDay.Day = "Monday";
            objDay.Code = "2";
            objArray.Add(objDay);

            objDay = new clsDay();
            objDay.Day = "Tuesday";
            objDay.Code = "3";
            objArray.Add(objDay);

            objDay = new clsDay();
            objDay.Day = "Wednesday";
            objDay.Code = "4";
            objArray.Add(objDay);

            objDay = new clsDay();
            objDay.Day = "Thursday";
            objDay.Code = "5";
            objArray.Add(objDay);

            objDay = new clsDay();
            objDay.Day = "Friday";
            objDay.Code = "6";
            objArray.Add(objDay);

            objDay = new clsDay();
            objDay.Day = "Saturday";
            objDay.Code = "7";
            objArray.Add(objDay);
        }
        public clsDay getByIndex(int intIndex)
        {
            if ((intIndex >= objArray.Count) || (intIndex == -1))
            {
                throw new Exception("End or Begin");
            }
            intCurrentIndex = intIndex;
            return (clsDay)objArray[intCurrentIndex];
        }
        public clsDay Prev()
        {
            int intTemp = intCurrentIndex;
            intTemp--;
            return (clsDay)getByIndex(intTemp);
        }
        public clsDay Next()
        {
            int intTemp = intCurrentIndex;
            intTemp++;
            return (clsDay)getByIndex(intTemp);
        }
        public clsDay getFirst()
        {
            return getByIndex(0);
        }
    }
}

using System.Collections.Generic;

namespace HackerRankSolution
{
    public class TimeConverter : ITimeConverter
    {
        
        
        public string ConvertTime(string s)
        {
            string newTimeFormatStr = "";
            List<string> timeOne = new List<string>() 
                {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11"};

            List<string> timeTwo = new List<string>() 
                {"12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"};


            string timeMark = s.Substring(s.Length - 2, 2);
            string sHours = s.Substring(0, 2);
            if (timeMark == "AM")
            {
                newTimeFormatStr = s.Remove(s.Length - 2, 2);
                
                
                if (sHours == "12")
                {
                    newTimeFormatStr = newTimeFormatStr.Remove(0, 2);
                    newTimeFormatStr = newTimeFormatStr.Insert(0, "00");
                }
            }
            
            if (timeMark == "PM")
            {
                newTimeFormatStr = s.Remove(s.Length - 2, 2);
                if (sHours != "12")
                {
                    string hoursNew = timeTwo[timeOne.IndexOf(sHours)];
                    newTimeFormatStr = newTimeFormatStr.Remove(0, 2);
                    newTimeFormatStr = newTimeFormatStr.Insert(0, hoursNew);
                }
                
            }
          
            return newTimeFormatStr;
        }
    }
}
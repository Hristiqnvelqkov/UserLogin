using System;
namespace UserLogin{
    public class Tools{
        public static DateTime getDateByString(String date){
            return DateTime.Parse(date);
        }
    }
}
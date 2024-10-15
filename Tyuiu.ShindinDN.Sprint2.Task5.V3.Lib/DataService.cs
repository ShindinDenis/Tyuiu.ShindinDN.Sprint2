using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShindinDN.Sprint2.Task5.V3.Lib
{
    public class DataService : ISprint2Task5V3
    {
        public string FindDayName(int value)
        {
            string day = "";
            switch (value){
                case 1:
                    day="понедельник";
                    break;
                case 2:
                    day="вторник";
                    break;
                case 3:
                    day="среда";
                    break;

                case 4:
                    day="четверг";
                    break;

                case 5:
                    day="пятница";
                    break;

                case 6:
                    day="суббота";
                    break;

                case 7:
                    day="воскресенье"; 
                    break;
            }
            return day;
        }
    }
}

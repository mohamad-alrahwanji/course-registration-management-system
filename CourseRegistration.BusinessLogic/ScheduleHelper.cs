using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistration.BusinessLogic
{
    public class ScheduleHelper
    {
        public static bool SchedulesOverlap(string firstSchedule, string secondSchedule)
        {
            int firstSpace = firstSchedule.IndexOf(' ');
            int secondSpace = secondSchedule.IndexOf(' ');

            string firstDaysText = firstSchedule.Substring(0, firstSpace);
            string secondDaysText = secondSchedule.Substring(0, secondSpace);

            string[] firstDays = firstDaysText.Split('/');
            string[] secondDays = secondDaysText.Split('/');

            bool sameDay = false;

            foreach (string firstDay in firstDays)
            {
                foreach (string secondDay in secondDays)
                {
                    if (firstDay == secondDay) sameDay = true;
                }
            }

            if (!sameDay) return false;

            string firstTimeText = firstSchedule.Substring(firstSpace + 1);
            string secondTimeText = secondSchedule.Substring(secondSpace + 1);

            string[] firstTimes = firstTimeText.Split(" - ");
            string[] secondTimes = secondTimeText.Split(" - ");

            DateTime firstStart = DateTime.Parse(firstTimes[0]);
            DateTime firstEnd = DateTime.Parse(firstTimes[1]);

            DateTime secondStart = DateTime.Parse(secondTimes[0]);
            DateTime secondEnd = DateTime.Parse(secondTimes[1]);

            return firstStart < secondEnd && firstEnd > secondStart;
        }
    }
}

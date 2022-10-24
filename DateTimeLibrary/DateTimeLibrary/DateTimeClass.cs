using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLibrary
{
    public class DateTimeClass
    {
        /// <summary>
        /// Определяет дату предыдущего дня
        /// </summary>
        public DateTime PrevDate(DateTime DateTimes)
        {
            if (DateTimes == DateTime.MinValue)
            {
                throw new Exception("Вы ввелм не верную дату");
            }
            return DateTimes.Subtract(TimeSpan.FromDays(1));
        }

        /// <summary>
        /// Определяет дату следующего дня
        /// </summary>
        public DateTime NextDate(DateTime DateTimes)
        {
            if (DateTimes == DateTime.MinValue)
            {
                throw new Exception("Вы ввелм не верную дату");
            }
            return DateTimes.Add(TimeSpan.FromDays(1));
        }

        /// <summary>
        /// Определяет количество дней до конца месяца
        /// </summary>
        public int DaysUntilEndMonth(DateTime DateTimes)
        {
            if (DateTimes == DateTime.MinValue)
            {
                throw new Exception("Вы ввелм не верную дату");
            }
            return DateTime.DaysInMonth(DateTimes.Year, DateTimes.Month) - DateTimes.Day;
        }

        /// <summary>
        /// Определяет високосный год сейчас или нет
        /// </summary>
        public bool LeapYearCheck(DateTime DateTimes)
        {
            if (DateTimes == DateTime.MinValue)
            {
                throw new Exception("Вы ввелм не верную дату");
            }
            return DateTime.IsLeapYear(DateTimes.Year);
        }

        /// <summary>
        /// Определяет високосный год сейчас или нет
        /// </summary>
        public DateTime FindDate(DateTime DateTimes, int i)
        {
            if (DateTimes == DateTime.MinValue)
            {
                throw new Exception("Вы ввелм не верную дату");
            }
            return DateTimes.AddDays(i);
        }

        /// <summary>
        /// Определяет установленная дата является ли последним днем месяца или нет
        /// </summary>
        public bool NextDayOfMonth(DateTime DateTimes)
        {
            if (DateTimes == DateTime.MinValue)
            {
                throw new Exception("Вы ввелм не верную дату");
            }
            if (DateTimes.Day == DateTime.DaysInMonth(DateTimes.Year, DateTimes.Month))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Определяет установленная дата является ли началом года или нет
        /// </summary>
        public bool FirstDayOdYear(DateTime DateTimes)
        {
            if (DateTimes == DateTime.MinValue)
            {
                throw new Exception("Вы ввелм не верную дату");
            }
            if (DateTimes.Day == 1 && DateTimes.Month == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;

namespace AlgorithmsPractice
{
    public class TimeMachine
    {
        public int StartHour { get; set; }
        public int HoursPassed { get; set; }

        private int _days;

        private int _hour;

        private String _amPm;

        private String _future;


        public TimeMachine(int startHour, int hoursPassed)
        {
            if (startHour < 1 || startHour > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(startHour), "only one through twelve allowed");
            }
            if ((2147483647 - startHour) < hoursPassed)
            {
                throw new ArgumentOutOfRangeException(nameof(hoursPassed), "the total hours exceeds the max int allowed");
            }
            StartHour = startHour;
            HoursPassed = hoursPassed;
        }

        private void CalculateTime()
        {
            int totalHours = StartHour;
            totalHours += HoursPassed;

            if (HoursPassed > 0)
            {
                _hour = totalHours % 24;
                _days = totalHours / 24;
                _future = "passed";
            }
            else
            {
                //convert to positive 
                totalHours *= -1;
                _hour = 24 - totalHours % 24;
                _days = totalHours / 24 + 1;
                // if the hour is 24 then subtract a day because the same day is starting at 12:00am
                if (_hour == 24)
                {
                    _days -= 1;
                }
                _future = "gone back";
            }
        }

        private void AmPm()
        {
            //handle am or pm
            if (_hour == 24 || _hour == 0)
            {
                _hour = 12;
                _amPm = "am";
            }
            else if (_hour >= 12)
            {
                _amPm = "pm";
                //if hour is bigger then 12 subtract 12 from it and make pm
                if (_hour > 12)
                {
                    _hour -= 12;
                }
            }
            else
            {
                _amPm = "am";
            }
        }

        public string GetTime()
        {
            CalculateTime();
            AmPm();
            return "The hour is now " + _hour + ":00" + _amPm + " and " + _days + " days have " + _future;
        }
    }
}
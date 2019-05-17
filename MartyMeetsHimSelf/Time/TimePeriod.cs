using System;

namespace MartyMeetsHimSelf.Time
{
    public class TimePeriod
    {
        public DateTime Start { get; }
        public DateTime Stop { get; }

        public TimePeriod(DateTime start, DateTime stop)
        {
            Start = start;
            Stop = stop;
        }

        public TimePeriod((DateTime, DateTime) startAndStop) : this(startAndStop.Item1, startAndStop.Item2) { }

        public bool IsIn(DateTime date) => date >= Start && date < Stop;
    }
}

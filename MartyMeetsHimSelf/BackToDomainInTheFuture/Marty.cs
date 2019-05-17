using System;
using System.Linq;
using System.Collections.Generic;
using MartyMeetsHimSelf.Time;

namespace MartyMeetsHimSelf.BackToDomainInTheFuture
{
    public class Marty
    {
        private readonly List<TimePeriod> _list;

        public MartyVersion Name { get; }

        public Marty(string name, List<(DateTime, DateTime)> list)
        {
            Name = new MartyVersion(name);
            _list = list.Select(tuple => new TimePeriod(tuple)).ToList();
        }

        public bool IsActivated { get; internal set; }

        public void OnTimeEvent(TimeEvent te)
        {
            var isIn = false;
            foreach (var at in _list)
            {
                isIn |= at.IsIn(te.SignalDate);
            }
            IsActivated = isIn;
        }
    }
}

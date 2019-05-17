using System;
using System.Collections.Generic;
using MartyMeetsHimSelf.Time;
using MartyMeetsHimSelf.BackToDomainInTheFuture;
using System.Linq;

namespace MartyMeetsHimSelf.TimeTravelling
{
    public class MartysMeetEachOther
    {
        readonly List<UbiquitiousMartys> _ubiquitiousMartys = new List<UbiquitiousMartys>();
        OpenTimePeriod _notYetFinishedPeriod;
        List<MartyVersion> _martys;

        public List<TimePeriod> TimePeriods 
            => _ubiquitiousMartys.Select(marts => marts.Period).ToList();
        public void AddMartys(IEnumerable<Marty> martys, DateTime time)
        {
            if (_notYetFinishedPeriod == null)
            {
                _notYetFinishedPeriod = new OpenTimePeriod(time);
                _martys = martys.Select(marts => marts.Name).ToList();
            }
            else
            {
                _ubiquitiousMartys.Add(new UbiquitiousMartys(_martys, _notYetFinishedPeriod, time));
                _notYetFinishedPeriod = null;
                _martys = null;
            }
        }
    }
}

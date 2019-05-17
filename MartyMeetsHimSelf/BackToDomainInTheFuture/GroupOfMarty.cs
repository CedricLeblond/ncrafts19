using System.Linq;
using System.Collections.Generic;
using MartyMeetsHimSelf.Time;

namespace MartyMeetsHimSelf.BackToDomainInTheFuture
{
    public class GroupOfMarty : IGroupOfMarty
    {
        private List<Marty> martys = new List<Marty>(5);
        public void AddMarty(Marty marty) => martys.Add(marty);

        public Marty GetMarty(string lookForOneMarty)
            => martys.FirstOrDefault(mart => mart.Name.Value == lookForOneMarty);

        public void OnTimeEvent(TimeEvent te)
            => martys.ForEach(mart => mart.OnTimeEvent(te));

        public IEnumerable<Marty> GetActivatedMarty()
            => martys.Where(mart => mart.IsActivated);
    }
}

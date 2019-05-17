using System;
using System.Collections.Generic;
using System.Text;

namespace MartyMeetsHimSelf.BackToDomainInTheFuture
{
    public class MartyVersion
    {
        public string Value { get; }
        public MartyVersion(string name) => Value = name;

        public override string ToString() => Value;
    }
}

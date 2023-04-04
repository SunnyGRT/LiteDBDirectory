using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucene.Net.Store.LiteDbDirectory.Entities
{
    public class IndexFileLock
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime LockReleaseTimestamp { get; set; }
    }
}

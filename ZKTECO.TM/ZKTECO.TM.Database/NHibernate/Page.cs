using System;
using System.Collections.Generic;
using System.Text;

namespace ZKTECO.TM.Database.NHibernate
{
    public class Page<T>
    {
        public long TotalElements { get; set; }
        public long PageIndex { get; set; }
        public long TotalPages { get; set; }
        public IList<T> Items { get; set; }

        public Page(IList<T> items, long count, int pageIndex, int pageSize)
        {
            TotalElements = count;
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            Items = items;
        }
    }
}

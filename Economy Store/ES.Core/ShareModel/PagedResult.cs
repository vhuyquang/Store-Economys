using System.Collections.Generic;

namespace ES.Core.ShareModel
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }

        public int TotalCount { get; set; }
    }
}
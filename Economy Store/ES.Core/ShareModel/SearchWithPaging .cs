namespace ES.Core.ShareModel
{
    public class SearchWithPaging
   {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string SearchTerm { get; set; }
    }
}
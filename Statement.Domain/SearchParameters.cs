namespace Statements.Domain
{
    public class SearchParameters
    {
        public string? SearchString { get; set; }
        public int PageIndex { get; set; } = 1;
    }
}

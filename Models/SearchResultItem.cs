namespace BlazorWebApp.Models
{
    public class SearchResultItem
    {
        public string Id { get; set; } = "";
        public string Title { get; set; } = "";
        public string Subtitle { get; set; } = "";
        public string Type { get; set; } = ""; // "Project", "Commercial", "User", etc.
        public string Url { get; set; } = "";
        public string Icon { get; set; } = "bi-search";
    }
}

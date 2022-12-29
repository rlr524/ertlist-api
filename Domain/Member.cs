namespace Domain
{
    public class Member
    {
        public Guid id { get; set; }
        public string? lastname { get; set; }
        public string? firstname { get; set; }
        public string? title { get; set; }
        public string? officephone { get; set; }
        public string? mobilephone { get; set; }
        public string? otherphone { get; set; }
        public Guid[]? location { get; set; }
        public bool active { get; set; }
    }
}
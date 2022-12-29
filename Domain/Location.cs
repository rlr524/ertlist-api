namespace Domain
{
    public class Location
    {
        public Guid id { get; set; }
        public string? abbreviation { get; set; }
        public string? name { get; set; }
        public string? street { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zip { get; set; }
        public string? phone { get; set; }
        public string? region { get; set; }
        public Guid[]? members { get; set; }
        public bool active { get; set; }
    }
}
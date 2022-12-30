namespace Domain
{
    public class Location
    {
        public Guid Id { get; set; }
        public string? Abbreviation { get; set; }
        public string? Name { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Region { get; set; }
        public List<Member>? Members { get; set; }
        public bool Active { get; set; }
    }
}
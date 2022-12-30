namespace Domain
{
    public class Member
    {
        public Guid Id { get; set; }
        public string? EmployeeNumber { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Title { get; set; }
        public string? OfficePhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? OtherPhone { get; set; }
        public Location? Location { get; set; }
        public bool Active { get; set; }
    }
}
namespace MapsterPoc.Models
{
    public partial record NameDto
    {
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string? Suffix { get; set; }
    }
}
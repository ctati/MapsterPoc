using System;
using MapsterPoc.Models;

namespace MapsterPoc.Models
{
    public partial record PersonDto
    {
        public int Id { get; set; }
        public NameDto Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
using MapsterPoc.Domain;
using MapsterPoc.Models;

namespace MapsterPoc.Models
{
    public static partial class PersonMapper
    {
        public static Person AdaptToPerson(this PersonDto p1)
        {
            if (p1 == null)
            {
                return null;
            }
            Person result = new Person(p1.Name.LastName);
            
            result.Id = p1.Id;
            funcMain1(p1.Name, result.Name);
            result.DateOfBirth = p1.DateOfBirth;
            return result;
            
        }
        public static Person AdaptTo(this PersonDto p4, Person p5)
        {
            if (p4 == null)
            {
                return null;
            }
            Person result = p5 ?? new Person(p4.Name.LastName);
            
            result.Id = p4.Id;
            funcMain2(p4.Name, result.Name);
            result.DateOfBirth = p4.DateOfBirth;
            return result;
            
        }
        public static PersonDto AdaptToDto(this Person p8)
        {
            return p8 == null ? null : new PersonDto()
            {
                Id = p8.Id,
                Name = p8.Name == null ? null : new NameDto()
                {
                    FirstName = p8.Name.FirstName,
                    LastName = p8.Name.LastName,
                    Suffix = p8.Name.Suffix
                },
                DateOfBirth = p8.DateOfBirth
            };
        }
        public static PersonDto AdaptTo(this Person p9, PersonDto p10)
        {
            if (p9 == null)
            {
                return null;
            }
            PersonDto result = p10 ?? new PersonDto();
            
            result.Id = p9.Id;
            result.Name = funcMain3(p9.Name, result.Name);
            result.DateOfBirth = p9.DateOfBirth;
            return result;
            
        }
        
        private static Name funcMain1(NameDto p2, Name p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Name result = p3 ?? new Name(p2.LastName);
            
            result.FirstName = p2.FirstName;
            result.Suffix = p2.Suffix;
            return result;
            
        }
        
        private static Name funcMain2(NameDto p6, Name p7)
        {
            if (p6 == null)
            {
                return null;
            }
            Name result = p7 ?? new Name(p6.LastName);
            
            result.FirstName = p6.FirstName;
            result.Suffix = p6.Suffix;
            return result;
            
        }
        
        private static NameDto funcMain3(Name p11, NameDto p12)
        {
            if (p11 == null)
            {
                return null;
            }
            NameDto result = p12 ?? new NameDto();
            
            result.FirstName = p11.FirstName;
            result.LastName = p11.LastName;
            result.Suffix = p11.Suffix;
            return result;
            
        }
    }
}
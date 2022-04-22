using MapsterPoc.Domain;
using MapsterPoc.Mappers;

namespace MapsterPoc.Mappers
{
    public partial class ClientMapper : IClientMapper
    {
        public Client Map(Person p1)
        {
            if (p1 == null)
            {
                return null;
            }
            Client result = new Client(p1.Name.LastName);
            
            result.Id = p1.Id;
            funcMain1(p1.Name, result.Name);
            result.DateOfBirth = p1.DateOfBirth;
            return result;
            
        }
        public Client Map(Person p4, Client p5)
        {
            if (p4 == null)
            {
                return null;
            }
            Client result = p5 ?? new Client(p4.Name.LastName);
            
            result.Id = p4.Id;
            funcMain2(p4.Name, result.Name);
            result.DateOfBirth = p4.DateOfBirth;
            return result;
            
        }
        
        private Name funcMain1(Name p2, Name p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Name result = p3 ?? new Name(p2.LastName);
            
            result.FirstName = p2.Suffix;
            result.Suffix = p2.FirstName;
            return result;
            
        }
        
        private Name funcMain2(Name p6, Name p7)
        {
            if (p6 == null)
            {
                return null;
            }
            Name result = p7 ?? new Name(p6.LastName);
            
            result.FirstName = p6.Suffix;
            result.Suffix = p6.FirstName;
            return result;
            
        }
    }
}
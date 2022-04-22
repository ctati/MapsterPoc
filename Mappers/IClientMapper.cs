using Mapster;
using MapsterPoc.Domain;

namespace MapsterPoc.Mappers;

// NOTE: Doesn't look like there is a way to do this in configuration
[Mapper]
public interface IClientMapper : IMapper<Person, Client>
{
    
}
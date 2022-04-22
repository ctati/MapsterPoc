using System.Reflection;
using Mapster;
using MapsterPoc.Domain;
using MapsterPoc.Models;

namespace MapsterPoc;

public class MappingRegister : IRegister
{
    // NOTE: This class is used by the Mapper generator
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Person, Client>()
            .ConstructUsing(person => new Client(person.Name.LastName))
            .UseDestinationValue(member => member.Type == typeof(Name));

        config.NewConfig<Name, Name>()
            .ConstructUsing(name => new Name(name.LastName))
            .Map(dest => dest.FirstName, src => src.Suffix)
            .Map(dest => dest.Suffix, src => src.FirstName);

        config.NewConfig<NameDto, Name>()
            .ConstructUsing(nameDto => new Name(nameDto.LastName));

        config.NewConfig<PersonDto, Person>()
            .ConstructUsing(personDto => new Person(personDto.Name.LastName))
            .UseDestinationValue(member => member.Type == typeof(Name));
    }
}

public class CodeGenRegister : ICodeGenerationRegister
{
    // NOTE: This class us used by the DTO generator
    public void Register(CodeGenerationConfig config)
    {
        // NOTE: Generate DTO classes
        config.AdaptTwoWays("[name]Dto", MapType.Map | MapType.MapToTarget )
            .ApplyDefaultRule();

        // NOTE: Generate DTO Mapper classes
        config.GenerateMapper("[name]Mapper")
            .ForType<Person>();
    }
}

static class RegisterExtensions
{
    public static AdaptAttributeBuilder ApplyDefaultRule(this AdaptAttributeBuilder builder)
    {
        return builder
            .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "MapsterPoc.Domain")
            .ExcludeTypes(typeof(Client))
            .ExcludeTypes(type => type.IsEnum)
            .AlterType(type => type.IsEnum || Nullable.GetUnderlyingType(type)?.IsEnum == true, typeof(string))
            .ShallowCopyForSameType(true);

    }
}

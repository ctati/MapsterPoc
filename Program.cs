// See https://aka.ms/new-console-template for more information
using MapsterPoc.Domain;
using MapsterPoc.Mappers;
using MapsterPoc.Models;

Console.WriteLine("Hello, Mapster World!");

var person = new Person("Last Name") {
    DateOfBirth = DateOnly.FromDateTime(DateTime.Today),
    Id = 1
};
person.Name.FirstName = "Fist Name";
person.Name.Suffix = "Suffix";
Console.WriteLine($"Person: {person.Id}, {person.DateOfBirth}, {person.Name.FirstName}, {person.Name.LastName}, {person.Name.Suffix}");

var client = new ClientMapper().Map(person);
Console.WriteLine($"Client: {client.Id}, {client.DateOfBirth}, {client.Name.FirstName}, {client.Name.LastName}, {client.Name.Suffix}");

var personDto = person.AdaptToDto();
Console.WriteLine($"PersonDTO: {personDto.Id}, {personDto.DateOfBirth}, {personDto.Name.FirstName}, {personDto.Name.LastName}, {personDto.Name.Suffix}");

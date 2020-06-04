
namespace AutoMap
{
    public class AddressDTO
    {
        public string Street { get; set; } = "123, Baker Street";
        public string City { get; set; } = "City of London";
        public string State { get; set; } = "London";
        public string ZipCode { get; set; } = "12345";
    }

    public class PersonDTO
    {
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "DOE";
        public AddressDTO Address { get; set; } = new AddressDTO();
    }
}

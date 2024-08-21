using CargoApp.Entities.Enums;

namespace CargoApp.Api.Dtos.MemberDto;

public class CreateMemberDto
{
    public string Name { get; set; }
    public string LastName { get; set; }
        
    public string Address { get; set; }
        
    public AddressEnum AddressType { get; set; } // Enum olarak saklanacak
}
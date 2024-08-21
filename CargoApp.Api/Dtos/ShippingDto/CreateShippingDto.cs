namespace CargoApp.Api.Dtos.ShippingDto;

public class CreateShippingDto
{
    public string SenderId { get; set; }
    
    public string ReceiverId { get; set; }

    public int PackageCount { get; set; }
    public int PackageWeight { get; set; }
    public string Description { get; set; }
}
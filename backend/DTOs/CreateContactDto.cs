namespace backend.DTOs
{
    public class CreateContactDto
    {
        // create a DTO named CreateContactDto that has properties FirstName, Lastname, physical address, and delivery address
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhysicalAddress { get; set; }
        public string DeliveryAddress { get; set; }
    }
}

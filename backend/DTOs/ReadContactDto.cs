namespace backend.DTOs
{
    public class ReadContactDto
    {
        // create a ReadContactDto that has properties Id of type Guid, FirstName, Lastname, physical address, and delivery address
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhysicalAddress { get; set; }
        public string DeliveryAddress { get; set; }
    }
}

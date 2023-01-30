namespace backend.Models
{
    public class Contact
    {
        // create a Contact model that has properties Id of type Guid, FirstName, Lastname, physical address, and delivery address
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhysicalAddress { get; set; }
        public string DeliveryAddress { get; set; }
    }
}

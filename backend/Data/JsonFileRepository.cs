using backend.Models;
using System.Text.Json;

namespace backend.Data
{
    public class JsonFileRepository
    {
        // Create a repository that uses a JSON file as the data store and stores the data inside a List<Contact> property
        public List<Contact> Contacts { get; private set; }
        
        public JsonFileRepository()
        {
            var json = File.ReadAllText("contacts.json");
            Contacts = JsonSerializer.Deserialize<List<Contact>>(json);
        }

        // CRUD
        // Create a read contact method that reads all contacts inside Contacts property
        public IEnumerable<Contact> ReadContacts()
        {
            return Contacts;
        }

        // Create a read contact method that reads a single contact inside Contacts property
        public Contact ReadContact(Guid id)
        {
            return Contacts.FirstOrDefault(c => c.Id == id);
        }

        // Create a create contact method that adds a new contact to the Contacts property
        public void CreateContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        // create a update contact method that updates a contact inside the Contacts property
        public void UpdateContact(Contact contact)
        {
            var index = Contacts.FindIndex(c => c.Id == contact.Id);
            Contacts[index] = contact;
        }

        // create a delete contact method that deletes a contact inside the Contacts property
        public void DeleteContact(Guid id)
        {
            var index = Contacts.FindIndex(c => c.Id == id);
            Contacts.RemoveAt(index);
        }

        // Create a save method that saves the data inside the Contacts property to the JSON file
        public void Save()
        {
            var json = JsonSerializer.Serialize(Contacts, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText("Data/contacts.json", json);
        }
    }
}

using AutoMapper;
using backend.Data;
using backend.DTOs;
using backend.Models;

namespace backend.Services
{
    public class JsonContactService
    {
        private readonly JsonFileRepository _repository;
        private readonly IMapper _mapper;

        public JsonContactService(JsonFileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Create a read contact method that reads all contacts inside Contacts property
        public List<ReadContactDto> ReadContacts()
        {
            return _mapper.Map<List<ReadContactDto>>(_repository.ReadContacts());
        }

        // Create a read contact method that reads a single contact inside Contacts property
        public ReadContactDto ReadContact(Guid id)
        {
            return _mapper.Map<ReadContactDto>(_repository.ReadContact(id));
        }

        // Create a create contact method that adds a new contact to the Contacts property
        public ReadContactDto CreateContact(CreateContactDto contact)
        {
            var contactModel = _mapper.Map<Contact>(contact);
            _repository.CreateContact(contactModel);
            _repository.Save();
            return _mapper.Map<ReadContactDto>(contactModel);
        }

        // create a update contact method that updates a contact inside the Contacts property
        public ReadContactDto UpdateContact(UpdateContactDto contact)
        {
            var contactModel = _mapper.Map<Contact>(contact);
            _repository.UpdateContact(contactModel);
            _repository.Save();
            return _mapper.Map<ReadContactDto>(contactModel);
        }

        // create a delete contact method that deletes a contact inside the Contacts property
        public void DeleteContact(Guid id)
        {
            _repository.DeleteContact(id);
            _repository.Save();
        }
    }
}

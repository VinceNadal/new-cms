using backend.DTOs;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly JsonContactService jsonContactService;
        public ContactsController(JsonContactService jsonContactService)
        {
            this.jsonContactService = jsonContactService;
        }

        [HttpGet]
        public ActionResult<List<ReadContactDto>> GetContacts()
        {
            return Ok(jsonContactService.ReadContacts());
        }

        [HttpGet("{id}", Name = nameof(GetContact))]
        public ActionResult<ReadContactDto> GetContact(Guid id)
        {
            var contact = jsonContactService.ReadContact(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [HttpPost]
        public ActionResult<ReadContactDto> CreateContact(CreateContactDto contact)
        {
            var contactModel = jsonContactService.CreateContact(contact);
            return CreatedAtAction(nameof(GetContact), new { id = contactModel.Id }, contactModel);
        }

        [HttpPut("{id}")]
        public ActionResult<ReadContactDto> UpdateContact(UpdateContactDto contact)
        {
            var contactModel = jsonContactService.UpdateContact(contact);
            return Ok(contactModel);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteContact(Guid id)
        {
            jsonContactService.DeleteContact(id);
            // TODO: Validate that the contact was deleted
            return NoContent();
        }
    }
}

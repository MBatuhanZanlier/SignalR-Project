using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _ContactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _ContactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_ContactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto ContactDto)
        {
            _ContactService.TAdd(new Contact()
            {
                FooterDescription = ContactDto.FooterDescription, 
                Location = ContactDto.Location, 
                Mail=ContactDto.Mail, 
                Phone=ContactDto.Phone,
            });
            return Ok("Kategori Eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _ContactService.TGetById(id);
            _ContactService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _ContactService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto ContactDto)
        {
            _ContactService.TAdd(new Contact()
            { 
                Id=ContactDto.Id,
                FooterDescription = ContactDto.FooterDescription,
                Location = ContactDto.Location,
                Mail = ContactDto.Mail,
                Phone = ContactDto.Phone,
            });
            return Ok("Başarıyla Güncellendi");
        }
        

    }
}

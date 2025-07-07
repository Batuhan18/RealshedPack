using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using RealshedPack.Dtos.Contact_MessagesDto;

namespace RealshedPack.Controllers
{
    public class MainContact : Controller
    {
        private readonly IContact_MessagesService _messagesService;
        private readonly IMapper _mapper;
        private readonly IAgentsService _agentsService;

        public MainContact(IContact_MessagesService messagesService, IMapper mapper, IAgentsService agentsService)
        {
            _messagesService = messagesService;
            _mapper = mapper;
            _agentsService = agentsService;
        }

        [HttpGet]
        public IActionResult ContactIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactIndex(CreateContact_MessagesDto createContact_MessagesDto)
        {
            var mesaage = _mapper.Map<Contact_Messages>(createContact_MessagesDto);
            mesaage.Created_Time = DateTime.UtcNow;
            _messagesService.TAdd(mesaage);
            TempData["MessageStatus"] = "Mesajınız başarıyla gönderildi.";
            return View("ContactIndex", createContact_MessagesDto);
        }

    }
}

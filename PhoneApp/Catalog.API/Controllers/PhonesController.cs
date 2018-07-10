using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Domain.ControllerWorkers;
using Catalog.Domain.DTO;
using Catalog.Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    public class PhonesController : Controller
    {
        private readonly IPhoneCW _phoneCW;

        public PhonesController(IPhoneCW phoneCW)
        {
            _phoneCW = phoneCW;
        }


        // GET api/phones
        [HttpGet]
        public IEnumerable<PhoneDTO> Get()
        {
            var result = _phoneCW.getPhones();
            return result;
        }

        // GET api/phones/1
        [HttpGet("{id}")]
        public PhoneDTO Get(int id)
        {
            var result = _phoneCW.getPhoneByIdentifier(id);
            return result;
        }

        //POST api/phones
        //ids: JSON Parameter in body
        [HttpPost]
        public List<PhonePriceDTO> Post([FromBody]List<int> ids)
        {
            var result = _phoneCW.getPricesByIdentifiers(ids);
            return result;
        }
    }
}

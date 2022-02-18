using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Service.Features.Commands;
using Service.Features.CustomerFeatures.Queries;

namespace API.HotelBooking.Controllers
{
   [ApiController]
   [Route("[controller]")]
    
    public class HotelController : BaseController
    {
        /// <summary>
        /// for adding new hotel
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewHotelCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await Mediator.Send(new GetHotelByIdQuery { hotelId = id }));
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel_Itinerary.Server.Data;
using Travel_Itinerary.Shared.Domain;
using Travel_Itinerary.Server.IRepository;
using Duende.IdentityServer.Validation;

namespace Travel_Itinerary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
		//private readonly ApplicationDbContext _context;
		private readonly IUnitOfWork _unitOfWork;

		//public DestinationController(ApplicationDbContext context)
		public DestinationController(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
        }

		// GET: api/Destination
		[HttpGet]
	
		public async Task<IActionResult> GetDestination()
		{
            //return NotFound();
            var Destination = await _unitOfWork.Destination.GetAll();
                //includes: q => q.Include(x => x.Customer).Include(x => x.Bookings));
			return Ok(Destination);
		}
		// GET: api/Destination/5
		[HttpGet("{id}")]

		public async Task<IActionResult> GetDestination(int id)
		{
			var Destination = await _unitOfWork.Destination.Get(q => q.Id == id);

			if (Destination == null)
			{
				return NotFound();
			}

			return Ok(Destination);
		}

		// PUT: api/Destination/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
        public async Task<IActionResult> PutDestination(int id, Destination Destination)
        {
            if (id != Destination.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Destination.Update(Destination);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
				if (!await DestinationExists(id))
				{
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

		// POST: api/Destination
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
        public async Task<ActionResult<Destination>> PostDestination(Destination Destination)
        {
            await _unitOfWork.Destination.Insert(Destination);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDestination", new { id = Destination.Id }, Destination);
        }

		// DELETE: api/Destination/5
		[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestination(int id)
        {
            var Destination = await _unitOfWork.Destination.Get(q => q.Id == id);
            if (Destination == null)
            {
                return NotFound();
            }

            await _unitOfWork.Destination.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

		private async Task<bool> DestinationExists(int id)
		{
            var Destination = await _unitOfWork.Destination.Get(q => q.Id == id);
            return Destination == null;
        }
    }
}

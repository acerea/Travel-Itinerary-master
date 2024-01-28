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
	public class TravelDocsController : ControllerBase
	{
		//private readonly ApplicationDbContext _context;
		private readonly IUnitOfWork _unitOfWork;

		//public TravelDocsController(ApplicationDbContext context)
		public TravelDocsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		// GET: api/TravelDocs
		[HttpGet]
		
		public async Task<IActionResult> GetTravelDocs()
		{
			var traveldocs = await _unitOfWork.TravelDocs.GetAll();
			return Ok(traveldocs);
		}
		// GET: api/TravelDocs/5
		[HttpGet("{id}")]

		public async Task<IActionResult> GetTravelDocs(int id)
		{
			var traveldocs = await _unitOfWork.TravelDocs.Get(q => q.Id == id);

			if (traveldocs == null)
			{
				return NotFound();
			}

			return Ok(traveldocs);
		}

		// PUT: api/TravelDocs/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTravelDocs(int id, TravelDocs traveldocs)
		{
			if (id != traveldocs.Id)
			{
				return BadRequest();
			}

			_unitOfWork.TravelDocs.Update(traveldocs);

			try
			{
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await TravelDocsExists(id))
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

		// POST: api/TravelDocs
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<TravelDocs>> PostTravelDocs(TravelDocs traveldocs)
		{
			await _unitOfWork.TravelDocs.Insert(traveldocs);
			await _unitOfWork.Save(HttpContext);

			return CreatedAtAction("GetTravelDocs", new { id = traveldocs.Id }, traveldocs);
		}

		// DELETE: api/TravelDocs/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTravelDocs(int id)
		{
			var traveldocs = await _unitOfWork.TravelDocs.Get(q => q.Id == id);
			if (traveldocs == null)
			{
				return NotFound();
			}

			await _unitOfWork.TravelDocs.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> TravelDocsExists(int id)
		{
			var traveldocs = await _unitOfWork.TravelDocs.Get(q => q.Id == id);
			return traveldocs == null;
		}
	}
}


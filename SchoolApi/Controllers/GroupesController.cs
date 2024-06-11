using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SchoolApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GroupesController : ControllerBase
	{
		private readonly SchoolDbContext _context;

		public GroupesController(SchoolDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Groupe>>> GetCourses()
		{
			return await _context.Groupes.ToListAsync();
		}

		/*

		[HttpGet("{id}")]
		public async Task<ActionResult<Groupe>> GetGroupeById(int id)
		{
			var groupe = await _context.Groupes.Where(c => c.Id.Equals(id)).FirstOrDefaultAsync();
			if (groupe == null)
			{
				return NotFound();
			}
			return groupe;
		}

		[HttpPost]
		public async Task<ActionResult<Groupe>> CreateGroupe(Groupe groupe)
		{
			// valider les données
			_context.Groupes.Add(groupe);
			await _context.SaveChangesAsync();
			return CreatedAtAction(nameof(GetGroupeById), new { id = groupe.Id }, groupe);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteGroupe(int id)
		{
			var groupe = await _context.Groupes.FindAsync(id);
			if (groupe == null)
			{
				return NotFound();
			}
			_context.Groupes.Remove(groupe);
			//await _context.SaveChangesAsync();
			return NoContent();
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateCourse(int id, Groupe groupe)
		{
			if (!id.Equals(groupe.Id))
			{
				return BadRequest("IDs are different");
			}
			var groupeToUpdate = await _context.Groupes.FindAsync(id);
			if (groupeToUpdate == null)
			{
				return NotFound($"Course with Id = {id} not found");
			}
			//courseToUpdate.Name = course.Name;
			map(groupe, groupeToUpdate);
			await _context.SaveChangesAsync();
			return NoContent();
		}

		private void map(Groupe groupe, Groupe groupeToUpdate)
		{
			groupeToUpdate.Nom = groupe.Nom;
		}
		*/
	}
}

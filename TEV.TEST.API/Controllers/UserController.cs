using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Interface;
using API.Models;
using API.Repository;
using TEV.TEST.API.Models;

namespace API.Controllers
{
	[Route("TEV/User")]
	public class UserController: Controller
	{

		private readonly IUser<User> _context;

		public UserController(IUser<User> context)
		{
			_context = context;
		}
	
		[HttpGet]
		public List<User> Get()
		{
			return _context.GetAll();
		}

		[HttpGet("GetUserById/{Id}")]
		public IActionResult Get(int Id)
		{
			var result = _context.GetById(Id);
			if (result == null)
				return NotFound("User not Found");

			return Ok(result);
		}


		[HttpPost]
		public IActionResult Post([FromBody] User model)
		{
			if (model == null)
			{
				return BadRequest();
			}
			var result = _context.Create(model);
			return Ok(result);
		}

		[HttpPut]
		public IActionResult Put([FromBody] User model)
		{
			if (model == null)
			{
				return BadRequest();
			}

			var result = _context.Update(model);
			return Ok(result);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(string id)
		{
			bool result;
			if (!string.IsNullOrEmpty(id))
			{
				result = _context.Delete(int.Parse(id));
			}
			else
				return NotFound();

			return Ok(result);
		}
	}
}

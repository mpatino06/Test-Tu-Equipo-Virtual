using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interface;
using API.Models;
using TEV.TEST.API.Models;

namespace API.Repository
{
	public class UserRepository : IUser<User>
	{
		readonly TEVContext _context;

		public UserRepository(TEVContext context)
		{
			_context = context;
			if (_context.Users.Count() == 0)
			{
				_context.Users.Add(new User
				{
					Id = 1,
					LastName = "Patiño",
					Address = "Cll 1, Casa 1",
					CreateDate = DateTime.Now,
				});
				_context.SaveChanges();
			}
		}

		public List<User> GetAll()
		{		
			return _context.Users.ToList(); 
		}

		public User GetById(int Id)
		{
			return _context.Users.FirstOrDefault(a => a.Id == Id);
		}

		public int Create(User user)
		{
			int result;
			try
			{
				_context.Users.Add(user);
				_context.SaveChanges();
				result =  _context.Users.Last().Id;
			}
			catch (Exception)
			{
				result = 0;
			}
			return result;
		}

		public bool Update(User user)
		{
			bool result = true;
			try
			{
				var getforUpfate = _context.Users.FirstOrDefault(a => a.Id == user.Id);
				if (getforUpfate != null)
				{
					getforUpfate.LastName = user.LastName;
					getforUpfate.Address = user.Address;
					getforUpfate.UpdateDate = DateTime.Now;
					_context.SaveChanges();
				}
			}
			catch (Exception)
			{
				//ADD LOG ERROR
				result = false;
			}

			return result;
		}

		public bool Delete(int Id)
		{
			bool result = true;
			try
			{
				var getforDelete = _context.Users.FirstOrDefault(a => a.Id == Id);
				if (getforDelete != null)
				{
					_context.Users.Remove(getforDelete);
					_context.SaveChanges();
				}
			}
			catch (Exception)
			{
				//ADD LOG ERROR
				result = false;
			}			
			return result;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEV.TEST.CORE.Context;
using TEV.TEST.CORE.Interface;
using TEV.TEST.CORE.Models;


namespace TEV.TEST.CORE.Services
{
	public class UserServices : IUser
	{

		AdminContext _context = new AdminContext();

		//public getval()
		//{
		//	List<User> user = _context.Users();

		//	var x = _context.Usuarios.

		//}

		public async Task<List<User>> GetAll()
		{
			List<User> users = new List<User>();
			await Task.Run(() =>
			 {
				 users = _context.Usuarios.ToList();

			 });
			return users;
		}


	}
}

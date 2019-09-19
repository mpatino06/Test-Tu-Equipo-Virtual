using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Interface
{
	public interface IUser<TEntity>
	{
		/// <summary>
		/// Get All Users
		/// </summary>
		/// <returns></returns>
		List<User> GetAll();

		/// <summary>
		/// Get user by id
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		User GetById(int Id);

		///// <summary>
		///// Create user
		///// </summary>
		///// <param name="user"></param>
		///// <returns></returns>
		int Create(User user);

		///// <summary>
		///// Update user
		///// </summary>
		///// <param name="user"></param>
		///// <returns></returns>
		bool Update(User user);

		///// <summary>
		///// Delete user
		///// </summary>
		///// <param name="Id"></param>
		///// <returns></returns>
		bool Delete(int Id);
	}
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TEV.TEST.CORE.Models;

namespace TEV.TEST.CORE.Interface
{
	public interface IUser
	{
		/// <summary>
		/// Get All Users
		/// </summary>
		/// <returns></returns>
		Task<List<User>> GetAll();

		/// <summary>
		/// Get user by id
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		//Task<User> GetById(int Id);

		///// <summary>
		///// Create user
		///// </summary>
		///// <param name="user"></param>
		///// <returns></returns>
		//Task<int> Create(User user);

		///// <summary>
		///// Update user
		///// </summary>
		///// <param name="user"></param>
		///// <returns></returns>
		//Task<bool> Update(User user);

		///// <summary>
		///// Delete user
		///// </summary>
		///// <param name="Id"></param>
		///// <returns></returns>
		//Task<bool> Delete(int Id);

	}
}

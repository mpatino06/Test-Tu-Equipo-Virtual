using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TEV.TEST.CORE.Models;

namespace TEV.TEST.CORE.Context
{
	public partial class AdminContext
	{
		public List<User> Usuarios
		{
			get => Users();
			set { }
		}

		public List<User> Users()
		{
			List<User> users = new List<User>();
			//await Task.Run(() =>
			//{
				users.Add(new User { Id = 1, LastName="Contreras Rivas", Address="Cll 01, Casa 01", CreateDate=DateTime.Now, UpdateDate=DateTime.Now });
				users.Add(new User { Id = 1, LastName = "Patino Hernandez", Address = "Cll 02, Casa 02", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
				users.Add(new User { Id = 1, LastName = "Peñalver Sosa", Address = "Cll 03, Casa 03", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
				users.Add(new User { Id = 1, LastName = "Aguaviva Felix", Address = "Cll 04, Casa 04", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
				users.Add(new User { Id = 1, LastName = "Jadir Rolos", Address = "Cll 05, Casa 05", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
				users.Add(new User { Id = 1, LastName = "Alcantar Zul", Address = "Cll 06, Casa 06", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
				users.Add(new User { Id = 1, LastName = "Velasquez Trinitario", Address = "Cll 07, Casa 07", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
			//});
			return users;
		}
	}
}

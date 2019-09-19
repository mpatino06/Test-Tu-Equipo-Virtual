using System;
using API.Controllers;
using API.Interface;
using API.Models;
using API.Repository;
using Xunit;

namespace TEV.TEST.UNITTEST
{
	public class UnitTest
	{

		private readonly IUser<User> _context;

		public UnitTest(IUser<User> context)
		{
			_context = context;
		}


		[Fact]
		public void Test()
		{
			var result = _context.GetById(1);
			Assert.Equal("Patiño", result.LastName);
		}
	}
}

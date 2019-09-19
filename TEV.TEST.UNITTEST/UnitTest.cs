using System;
using API.Controllers;
using API.Interface;
using API.Models;
using API.Repository;
//using FluentAssertions;
//using Xunit;
using System.Linq;
using Moq;
using TEV.TEST.API.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace TEV.TEST.UNITTEST
{
	public class UnitTest
	{

		[Fact]
		public void GetUserTest()
		{
			var mock = new Mock<IUser<User>>();
			mock.Setup(p => p.GetById(1)).Returns(new User { Id = 1 });

			UserController _user = new UserController(mock.Object);

			var result = _user.Get(1);
			var model = ((ObjectResult)result).Value;

			Assert.Equal(1, ((User)model).Id);

		}
	}
}

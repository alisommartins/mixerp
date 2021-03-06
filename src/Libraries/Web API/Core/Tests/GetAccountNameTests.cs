// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAccountNameTests
    {
        public static GetAccountNameController Fixture()
        {
            GetAccountNameController controller = new GetAccountNameController(new GetAccountNameRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountNameController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}
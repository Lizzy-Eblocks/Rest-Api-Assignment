using System;
using System.Collections.Generic;
using System.Text;
using af.assessment.api.Services;
using af.assessment.api.Controllers;
using Moq;
using Xunit;

namespace af.assessment.api.test.Controllers
{
  public class RegisterControllerTest {
        
        private readonly RegisterController _registerController;
        private readonly Mock<IRegisterService> _registerservice  = new Mock<IRegisterService>();

        public RegisterControllerTest()
        {
            _registerController = new RegisterController(_registerservice.Object);
        }

        [Fact]
        public void Register_New_Member_Successfully()
        {
            //Arrange
           
            //Act
           
            //Assert

        }

    }
}

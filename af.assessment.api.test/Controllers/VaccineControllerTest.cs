using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using af.assessment.api.Controllers;
using af.assessment.api.Data.Models;
using af.assessment.api.Enums;
using af.assessment.api.Services;
using Xunit;
using Moq;

namespace af.assessment.api.test.Controllers
{
    public class VaccineControllerTest
    {
        private readonly VaccineController _vaccineController;

        private readonly Mock<IVaccineService> _serviceMock = new Mock<IVaccineService>();

        public VaccineControllerTest()
        {
            _vaccineController = new VaccineController(_serviceMock.Object);
        }

        [Fact]
        public async void Should_Get_All_Appointments_By_MemberId()
        {
            //arrange
            var memberId = Guid.Parse("48ed15b1-af8a-4505-b795-12707bb5539f");
            
            var appointment = new List<Appointment>
            {
                new Appointment
                {
                    Id = Guid.Parse("23ce3616-efa0-4c1f-8254-6e3abde372b"),
                    AvailableDate = DateTime.Today,
                    DateSelected = DateTime.Now,
                    MemberId = Guid.Parse("48ed15b1-af8a-4505-b795-12707bb5539f"),
                    Status = AppointmentStatus.UpComing,
                    vaccineId = Guid.Parse("1691cd81-215a-4006-81c1-7bee3d73b1f2"),
                    Vaccines = new List<Vaccine>
                    {
                        new Vaccine()
                        {
                            Id = Guid.Parse("1691cd81-215a-4006-81c1-7bee3d73b1f2"),
                            Name = "Tetanus B",
                            Dose = 0.13,
                            Location = new Location()
                            {
                                Id = Guid.Parse("77046e00-2b75-48af-89ae-efe588e19c68"),
                                StreetName = "23rd Avenue",
                                PostalCode = 90210,
                                City = "Johannesburg"
                            }
                        }
                    }
                }
            };

            _serviceMock.Setup(s => s.GetAppointmentsByStatus(It.IsAny<Guid>(), It.IsAny<AppointmentStatus>()))
                .Returns(Task.FromResult(appointment));
            
            //act 

            var result = await _vaccineController.GetAppointmentsByStatus(memberId);
            
            //assert
            
            Assert.NotNull(result);
            Assert.Equal(appointment.Count, result.Count);
        }
    }
}
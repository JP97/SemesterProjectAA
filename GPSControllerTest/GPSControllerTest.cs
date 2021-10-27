using System;
using Xunit;
using Moq;
using SemesterProjectAA.Interfaces;
using SemesterProjectAA.Controllers;
using SemesterProjectAA.Services;

namespace GPSControllerTest
{
    public class GPSControllerTest
    {
        public Mock<IGPSService> _gpsService;


        public GPSControllerTest()
        {
            _gpsService = new Mock<IGPSService>();
        }

        [Fact]
        public void FetchGPSCoordinates_IsSuccessfull_True()
        {
            //arrange
            GPSController gpsController = new GPSController(_gpsService.Object);
            //act
            string result = gpsController.FetchGPSCoordinates();
            //assert
            _gpsService.Verify(x => x.FetchRemoteGPSCoordinates(), "some fake coordinates");
            
            //Assert.Equal("some fake coordinates", result);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SemesterProjectAA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemesterProjectAA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GPSController
    {
        public IGPSService _gpsService;
        public GPSController(IGPSService gpsService)
        {
            _gpsService = gpsService;
        }

        public string FetchGPSCoordinates()
        {
            return _gpsService.FetchRemoteGPSCoordinates();
        }


    }
}
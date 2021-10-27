using SemesterProjectAA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemesterProjectAA.Services
{
    public class GPSService : IGPSService
    {
        public string FetchRemoteGPSCoordinates()
        {
            return "some fake coordinates";
        }
    }
}

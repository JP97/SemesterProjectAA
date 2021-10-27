using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemesterProjectAA.Interfaces
{
    public interface IGPSService
    {
        public string FetchRemoteGPSCoordinates();
    }
}

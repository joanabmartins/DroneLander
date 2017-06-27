using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Common
{
    public static class MobileCenterConstants
    {
        public const string AndroidAppId = "2bcee86d-f073-465e-b480-4f2126d8b687";
        public const string iOSAppId = "";
    }
    public static class CoreConstants
    {

        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }
}

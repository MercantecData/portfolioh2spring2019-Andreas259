using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLibrary
{
    // Helper class.
    public static class Helper
    {
        // This helper method is only available in person library, the console app does not have any use for it.
        static internal string TypeOfVehicle(int wheels)
        {
            if (wheels == 2)
            {
                return "Bike";
            } else if (wheels == 4) 
            {
                return "Car";
            }

            return "Unknown";
        }  

    }
}

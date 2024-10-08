using System;
using Cosmos.Core;

namespace Cosmos.HAL
{
    /// <summary>
    /// Manages the power state of the system by directly manipulating
    /// hardware devices.
    /// </summary>
    public class Power
    {
        /// <summary>
        /// Triggers a direct, raw CPU reboot.
        /// </summary>
        public static void CPUReboot()
        {
            CPU.Reboot();
        }

        /// <summary>
        /// Reboot the system using ACPI. Currently not implemented.
        /// </summary>
        //// <exception cref="NotImplementedException">Thrown always.</exception>
        //[Obsolete("This method is not yet implemented.", error: true)] -- the method should work now no need to throw an exception
        public static void ACPIReboot()
        {
            try
            {
                CPU.Reboot();
            }
            catch
            {
                ACPI.Shutdown();
            }
        }

        /// <summary>
        /// Shutdown the system using ACPI.
        /// </summary>
        /// <exception cref="System.IO.IOException">Thrown on IO error.</exception>
        public static void ACPIShutdown()
        {
            ACPI.Shutdown();
        }
    }
}

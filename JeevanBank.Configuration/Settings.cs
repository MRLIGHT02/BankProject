using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeevanBank.Configuration
{
    /// <summary>
    /// Provides a centralized location for application-wide settings and configuration values.
    /// </summary>
    /// <remarks>This class is designed to store and manage static settings that are shared across the
    /// application. It is intended for use in scenarios where global configuration values are required.</remarks>
    public static class Settings
    {
        /// <summary>
        /// Gets or sets the base customer number used as the starting point for generating customer identifiers.
        /// </summary>
        public static long BaseCustomerNumber { get; set; } = 1000;
    }
}

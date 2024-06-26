// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    internal static partial class DesktopVirtualizationDayOfWeekExtensions
    {
        public static string ToSerialString(this DesktopVirtualizationDayOfWeek value) => value switch
        {
            DesktopVirtualizationDayOfWeek.Monday => "Monday",
            DesktopVirtualizationDayOfWeek.Tuesday => "Tuesday",
            DesktopVirtualizationDayOfWeek.Wednesday => "Wednesday",
            DesktopVirtualizationDayOfWeek.Thursday => "Thursday",
            DesktopVirtualizationDayOfWeek.Friday => "Friday",
            DesktopVirtualizationDayOfWeek.Saturday => "Saturday",
            DesktopVirtualizationDayOfWeek.Sunday => "Sunday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DesktopVirtualizationDayOfWeek value.")
        };

        public static DesktopVirtualizationDayOfWeek ToDesktopVirtualizationDayOfWeek(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Monday")) return DesktopVirtualizationDayOfWeek.Monday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tuesday")) return DesktopVirtualizationDayOfWeek.Tuesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Wednesday")) return DesktopVirtualizationDayOfWeek.Wednesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Thursday")) return DesktopVirtualizationDayOfWeek.Thursday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Friday")) return DesktopVirtualizationDayOfWeek.Friday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Saturday")) return DesktopVirtualizationDayOfWeek.Saturday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Sunday")) return DesktopVirtualizationDayOfWeek.Sunday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DesktopVirtualizationDayOfWeek value.");
        }
    }
}

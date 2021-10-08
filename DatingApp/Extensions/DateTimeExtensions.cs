﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CaclulateAge(this DateTime dob)
        {
            var age = DateTime.Today.Year - dob.Year;

            if (dob.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
    }
}

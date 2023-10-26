using Microsoft.AspNetCore.Mvc;

using System;

namespace Lekcja_2_ASP_NET_WSEI_2023.Models
{
    public class Birth
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && DateOfBirth < DateTime.Now;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - DateOfBirth.Year;
            if (currentDate < DateOfBirth.AddYears(age)) age--;
            return age;
        }
    }
}

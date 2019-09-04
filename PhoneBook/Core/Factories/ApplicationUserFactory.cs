using PhoneBook.Models;
using System;
using System.Globalization;

namespace PhoneBook.Core.Factories
{
    public class ApplicationUserFactory
    {
        public static ApplicationUser Create(dynamic user)
        {
            return new ApplicationUser
            {
                UserName = user.email,
                Email = user.email,
                FullName = $"{user.name.first} {user.name.last}",
                PhoneNumber = user.phone,
                DateOfBirth = Convert.ToDateTime(user.dob.date, CultureInfo.InvariantCulture),
                ThumbnailURL = user.picture.thumbnail,
                PhotoURL = user.picture.large,
            };
        }
    }
}
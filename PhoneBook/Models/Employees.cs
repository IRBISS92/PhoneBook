namespace PhoneBook.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Employees
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string ThumbnailURL { get; set; }

        public string PhotoURL { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
    }
}

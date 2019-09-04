using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.Core.Enums
{
    public enum SortTypes
    {
        [Display(Name = "Unsorted")]
        Unsorted,
        [Display(Name = "Sort Asc By Name")]
        SortByName,
        [Display(Name = "Sort Asc By Date Of Birth")]
        SortByDateOfBirth
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_DB_lec.Models.NorthWind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Category
    {
        public int CategoryID { get; set; }

       // [Display (Name = "Category Name"), Required]
        public string CategoryName { get; set; }

    //    [Required]
     //   [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]


        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
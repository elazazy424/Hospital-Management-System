//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMSS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Doctors_info
    {
        [Required(ErrorMessage ="Enter your Name please")]
        public string Name { get; set; }
        public int ID { get; set; }
        [Required(ErrorMessage ="Enter Your Speciality")]
        public string Specialty { get; set; }
    }
}

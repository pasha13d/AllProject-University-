//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDJ.UCommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwNonVerifiedUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Gender { get; set; }
        public System.DateTime JoinDate { get; set; }
        public string Ip { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string Image { get; set; }
    }
}

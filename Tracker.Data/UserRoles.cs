//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tracker.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRoles
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
        public int Id_UserRole { get; set; }
    
        public virtual Roles Roles { get; set; }
        public virtual Users Users { get; set; }
    }
}

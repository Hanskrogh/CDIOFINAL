//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Escademy.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class esc_profilegames
    {
        public int Id { get; set; }
        public int accountId { get; set; }
        public int gameId { get; set; }
        public int serviceTypeId { get; set; }
        public decimal SalaryUSD { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Verified { get; set; }
        public Nullable<long> Views { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    }
}
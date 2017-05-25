using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribetoNews { get; set; }

        public MembershipType Membershiptype { get; set; }

        public byte MembershipTypedId { get; set; } //Foreign key
    }
}
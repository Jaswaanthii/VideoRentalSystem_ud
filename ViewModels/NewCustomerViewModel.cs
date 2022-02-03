using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentalSystem.Models;

namespace VideoRentalSystem.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public DateTime? Birthdate { get; set; }

    }
}
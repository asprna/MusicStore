﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Domain
{
    public class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public long? SupportRepId { get; set; }

        public virtual Employee SupportRep { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}

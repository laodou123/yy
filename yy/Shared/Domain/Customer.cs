﻿using System.Security.Cryptography.X509Certificates;

namespace yy.Shared.Domain
{
    public class Customer :BaseDomianinModel
    {
        public string? DrivingLicense { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
        public List<Booking>Bookings { get; set; }

    }
}
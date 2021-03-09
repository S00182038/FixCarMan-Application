﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Application.Adverts
{
    public class AdDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string CarModel { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public virtual AppUserAdDto Advertiser { get; set; }
    }

  
}
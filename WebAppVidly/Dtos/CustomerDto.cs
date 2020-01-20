﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVidly.Models;

namespace WebAppVidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required()]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfaMember]
        public DateTime? Birthdate { get; set; }
    }
}
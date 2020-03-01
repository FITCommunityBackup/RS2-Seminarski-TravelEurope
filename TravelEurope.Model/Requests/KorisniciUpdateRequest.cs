﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class KorisniciUpdateRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public int GradId { get; set; }
        public string Lozinka { get; set; }
        public string LozinkaPotvrda { get; set; }
        public bool? Status { get; set; }
        [Required]
        public int UlogaId { get; set; }

        public byte[] Slika { get; set; }
    }
}

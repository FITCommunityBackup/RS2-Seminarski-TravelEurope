﻿using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class TuristRuta
    {
        public int TuristRutaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
        public int TuristickiVodicId { get; set; }
        public TuristickiVodic TuristickiVodic { get; set; }
        public int KategorijaId { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
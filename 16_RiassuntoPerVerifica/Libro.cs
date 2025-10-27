using System;

namespace _16_RiassuntoPerVerifica;

public class Libro
    {
        public int LibroID { get; set; }
        public string Titolo { get; set; }
        public int AutoreID { get; set; }
        public string Genere { get; set; }
        public int AnnoPubblicazione { get; set; }
        public int NumeroPagine { get; set; }
        public decimal Prezzo { get; set; }
        public bool Disponibile { get; set; }
    }
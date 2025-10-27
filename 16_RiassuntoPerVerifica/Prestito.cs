using System;

namespace _16_RiassuntoPerVerifica;

 public class Prestito
    {
        public int PrestitoID { get; set; }
        public int LibroID { get; set; }
        public string NomeUtente { get; set; }
        public DateTime DataPrestito { get; set; }
        public DateTime? DataRestituzione { get; set; }
    }

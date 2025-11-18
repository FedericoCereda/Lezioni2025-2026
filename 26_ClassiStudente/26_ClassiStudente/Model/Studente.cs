using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _26_ClassiStudente.Model;

public class Studente
{
    [Key]
    public int Matricola { get; set; }

    public string Nome { get; set; } = null!;
    public string Cognome { get; set; } = null!;

    public int FkClasse { get; set; }

    [ForeignKey("FkClasse")]
    public Classe Classe { get; set; } = null!;
}

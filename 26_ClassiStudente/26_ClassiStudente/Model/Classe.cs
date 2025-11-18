using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _26_ClassiStudente.Model;

public class Classe
{
    [Key]
    public int ClasseId { get; set; }
    public string Nome { get; set; }=null!;
    public string Cognome { get; set; }=null!;
    
    
    public int? Superficie { get; set; }
    [ForeignKey("FkClasse")]
    public List<Studente> Studenti=[];
    
}

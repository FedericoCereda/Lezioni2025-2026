# Classi e Liste per l'esercizio dei Romanzi

## Classi

### Autore (**AutoreId**, Cognome, Nome, Nazionalità) 
### Romanzo (**RomanzoId**, Titolo, AnnoPubblicazione, AutoreId*) 
###  Personaggio (**PersonaggioId**, Nome, Ruolo, Sesso, RomanzoId*) 

Con * viene indicata la chiave esterna, mentre la chiave primaria è indicata in grassetto ed è di tipo intero
---

 
### Lista Autori
```csharp
List<Autore> autori = new List<Autore> 
        { 
            new Autore { AutoreId = 1, Cognome = "Levi", Nome = "Primo", Nazionalità = 
"Italiana" }, 
            new Autore { AutoreId = 2, Cognome = "Eco", Nome = "Umberto", Nazionalità = 
"Italiana" }, 
            new Autore { AutoreId = 3, Cognome = "Calvino", Nome = "Italo", Nazionalità 
= "Italiana" }, 
            new Autore { AutoreId = 4, Cognome = "Moravia", Nome = "Alberto", 
Nazionalità = "Italiana" }, 
            new Autore { AutoreId = 5, Cognome = "Pirandello", Nome = "Luigi", 
Nazionalità = "Italiana" } 
        }; 
```

### Lista Romanzi

```csharp
romanzi = new List<Romanzo>{ 
            new Romanzo {RomanzoId = 1, Titolo = "Se questo è un uomo", 
AnnoPubblicazione = 1947, AutoreId =1}, 
            new Romanzo {RomanzoId = 2, Titolo = "Il nome della rosa", 
AnnoPubblicazione = 1980, AutoreId = 2}, 
            new Romanzo {RomanzoId = 3, Titolo = "Il barone rampante", 
AnnoPubblicazione = 1957, AutoreId = 3 }, 
            new Romanzo { RomanzoId = 4, Titolo = "Gli indifferenti", AnnoPubblicazione 
= 1929, AutoreId = 4 }, 
            new Romanzo { RomanzoId = 5, Titolo = "Uno, nessuno e centomila", 
AnnoPubblicazione = 1926, AutoreId = 5 }, 
            new Romanzo { RomanzoId = 6, Titolo = "La giornata di uno scrutatore", 
AnnoPubblicazione = 1963, AutoreId = 3 }, 
            new Romanzo { RomanzoId = 7, Titolo = "La coscienza di Zeno", 
AnnoPubblicazione = 19
            }
```

### Lista Personaggi

```csharp
 List<Personaggio> personaggi = new List<Personaggio> 
        { 
            new Personaggio { PersonaggioId = 1, Nome = "Jean Valjean", Ruolo = 
"Protagonista", Sesso = "M", RomanzoId = 1 }, 
            new Personaggio { PersonaggioId = 2, Nome = "Cosette", Ruolo = 
"Protagonista", Sesso = "F", RomanzoId = 1 }, 
            new Personaggio { PersonaggioId = 3, Nome = "Guglielmo da Baskerville", 
Ruolo = "Protagonista", Sesso = "M", RomanzoId = 2 }, 
            new Personaggio { PersonaggioId = 4, Nome = "Adso da Melk", Ruolo = 
"Protagonista", Sesso = "M", RomanzoId = 2 }, 
            new Personaggio { PersonaggioId = 5, Nome = "Cosimo Piovasco di Rondò", 
Ruolo = "Protagonista", Sesso = "M", RomanzoId = 3 }, 
            new Personaggio { PersonaggioId = 6, Nome = "Marcello", Ruolo = 
"Protagonista", Sesso = "M", RomanzoId = 4 }, 
            new Personaggio { PersonaggioId = 7, Nome = "Vitangelo Moscarda", Ruolo = 
"Protagonista", Sesso = "M", RomanzoId = 5 }, 
            new Personaggio { PersonaggioId = 8, Nome = "Amerigo Ormea", Ruolo = 
"Protagonista", Sesso = "M", RomanzoId = 6 }, 
            new Personaggio { PersonaggioId = 9, Nome = "Zeno Cosini", Ruolo = 
"Protagonista", Sesso = "M", RomanzoId = 7 }, 
            new Personaggio { PersonaggioId = 10, Nome = "Augusta", Ruolo = 
"Protagonista", Sesso = "F", RomanzoId = 7 } 
        }; 
```



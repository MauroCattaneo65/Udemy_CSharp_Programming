using System;

namespace Biblio
{
    public class Persona
    {
        public string Nome {get;set;}
        public string Cognome {get;set;}
        public virtual string Denominazione 
        {
            get 
            {
                return Nome + " " + Cognome;
            }
        }
    }
    public class Utente : Persona
    {
        public string Id {get; set;}

        public int AnnoIscrizione {get;set;}

        public override string Denominazione 
        {
            get 
            {
                return Id + " * " + Nome + " * " + Cognome;
            }
        }

        public Utente()
        {

        }
    }

    public class Libro
    {
        private string id;
        private string titolo;
        private string autore;
        private Utente utente;

        public Libro(string id, string titolo, string autore)
        {
            this.id = id;
            this.titolo = titolo;
            this.autore = autore;
            this.utente = null;
        }

        public string Descrizione()
        {
            return this.titolo + " di " + this.autore;
        }

        public void Prestito(Utente utente)
        {
            if(this.utente != null)
            {
                Console.WriteLine($"Libro già in prestito a: {this.utente.Denominazione}");
            }
            else
            {
                this.utente = utente;
                Console.WriteLine($"Libro prestato a: {this.utente.Denominazione}");
            }
     
        }

        public void Restituzione()
        {
            if(this.utente != null)
            {
                 Console.WriteLine($"L'utente: {utente.Denominazione} ha restituito il libro.");
            }
            this.utente = null;
        }
    }
  public  class Biblioteca
    {
        public static void Main(string[] args)
        {
            Utente utente1 = new Utente() {Id = "001", Nome = "Mario", Cognome = "Rossi", AnnoIscrizione=2020};
            Console.WriteLine(utente1.Denominazione);

            Utente utente2 = new Utente() {Id = "002", Nome = "Giuseppe", Cognome = "Verdi", AnnoIscrizione=2010};
            Console.WriteLine(utente2.Denominazione);

            Libro libro = new Libro("1","L'isola misteriosa","Giulio Verne");
            Console.WriteLine(libro.Descrizione());

            libro.Prestito(utente1);
            libro.Prestito(utente2);
            libro.Restituzione();
            libro.Prestito(utente2);
        }
    }
}

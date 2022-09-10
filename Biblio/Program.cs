﻿using System;

namespace Biblio
{
    public class Utente
    {
        private string id;
        private string nome;
        private string cognome;
        private int annoIscrizione;

        public Utente(string id, string nome, string cognome, int annoIscrizione)
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.annoIscrizione = annoIscrizione;
        }

        public string Denominazione()
        {
            return this.nome + " " + this.cognome;
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
                Console.WriteLine($"Libro già in prestito a: {this.utente.Denominazione()}");
            }
            else
            {
                this.utente = utente;
                Console.WriteLine($"Libro prestato a: {this.utente.Denominazione()}");
            }
     
        }

        public void Restituzione()
        {
            if(this.utente != null)
            {
                 Console.WriteLine($"L'utente: {utente.Denominazione()} ha restituito il libro.");
            }
            this.utente = null;
        }
    }
  public  class Biblioteca
    {
        public static void Main(string[] args)
        {
            Utente utente1 = new Utente("1","Mario","Rossi",2015);
            Console.WriteLine(utente1.Denominazione());

            Utente utente2 = new Utente("2","Giuseppe","Verdi",2010);
            Console.WriteLine(utente2.Denominazione());

            Libro libro = new Libro("1","L'isola misteriosa","Giulio Verne");
            Console.WriteLine(libro.Descrizione());

            libro.Prestito(utente1);
            libro.Prestito(utente2);
            libro.Restituzione();
            libro.Prestito(utente2);
        }
    }
}

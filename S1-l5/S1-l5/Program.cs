

using System;
using System.Collections.Generic;
using S1_l5;

class Program
{
    static List<Contribuente> contribuenti = new List<Contribuente>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Cosa vorresti fare?:");
            Console.WriteLine("1 Inserimento di una nuova dichiarazione di un contribuente");
            Console.WriteLine("2 La lista completa di tutti i contribuenti che sono stati analizzati");
            Console.WriteLine("3 Esci dal programma");
            Console.WriteLine("         ");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.Write("Scegli un'opzione: ");

            string? scelta = Console.ReadLine();
            if (scelta == null)
            {
                Console.WriteLine("Input non valido");
                continue;
            }

            switch (scelta)
            {
                case "1":
                    InserisciContribuente();
                    break;
                case "2":
                    VisualizzaContribuenti();
                    break;
                case "3":
                    return; 
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
    }
    static void InserisciContribuente()
    {
        Console.WriteLine("Inserisci i dati");
        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? string.Empty;
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine() ?? string.Empty;
        Console.Write("Data di Nascita (gg/mm/aaaa): ");
        string dataNascita = Console.ReadLine() ?? string.Empty;
        Console.Write("Codice Fiscale: ");
        string codiceFiscale = Console.ReadLine() ?? string.Empty;

        Genere sesso;
        while (true)
        {
            Console.Write("Sesso (M/F): ");
            string sessoInput = Console.ReadLine()?.ToUpper() ?? string.Empty;
            if (sessoInput == "M")
            {
                sesso = Genere.Maschio;
                break;
            }
            else if (sessoInput == "F")
            {
                sesso = Genere.Femmina;
                break;
            }
            else
            {
                Console.WriteLine("Input non valido. Inserisci 'M' per Maschio o 'F' per Femmina.");
            }
        }
        Console.Write("Comune di Residenza: ");
        string comune = Console.ReadLine() ?? string.Empty;
        Console.Write("Reddito Annuale: ");
        double redditoAnnuale = double.Parse(Console.ReadLine() ?? "0");

        Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comune, redditoAnnuale);
        contribuenti.Add(contribuente);

        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:\n");
        Console.WriteLine(contribuente);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
    }
    static void VisualizzaContribuenti()
    {

        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("Lista completa dei contribuenti analizzati:");
        foreach (var contribuente in contribuenti)
        {
            Console.WriteLine(contribuente); 
            Console.WriteLine("--------------------------------------------------");
        }
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
    }
}
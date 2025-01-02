// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;


public class Utilisateur
{
    static void Main(string[] args)
    {
        string normeSecurite = "Ceci sont les nomes de sécurité : ....."; 
        string logo = "Normalement sa serait une image mais pas grave";

        GenerationDocument generationDoc;

        Console.WriteLine("Vous êtes : " +
            "un particulier (1) ou un professionnel (2) ? :");
        var choix = Console.ReadLine();
        if (choix == "1")
        {
            generationDoc = new GenerationDocParticulier(); //+ ", " + normeSecurite + ", " + logo;
        }
        else
        {
            generationDoc = new GenerationDocPro(); //+ ", " + normeSecurite + ", " + logo;
        }
    }
}
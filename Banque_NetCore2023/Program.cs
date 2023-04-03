using Banque_NetCore2023.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Courant c1 = new Courant()
{
    Numero = "1",
    LigneDeCredit = 100,
    Titulaire = new Personne()
    {
        Nom = "Bya",
        Prenom = "Seb",
        DateNaiss = new DateTime(1991,3,27)
    }
};
Console.WriteLine($"Compte {c1.Numero} : {c1.Solde} €");
c1.Depot(1000);
Console.WriteLine("_______________________");
Console.WriteLine($"Compte {c1.Numero} : {c1.Solde} €");
c1.Retrait(100);
Console.WriteLine("_______________________");
Console.WriteLine($"Compte {c1.Numero} : {c1.Solde} €");
c1.Titulaire.Prenom = "Toto";
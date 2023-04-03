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
        DateNaiss = new DateTime(1991, 3, 27)
    }
};
Courant c2 = new Courant()
{
    Numero = "2",
    LigneDeCredit = 500,
    Titulaire = new Personne()
    {
        Nom = "Cafai",
        Prenom = "Jhon",
        DateNaiss = new DateTime(1860, 3, 27)
    }
};
Banque b = new Banque()
{
    Name = "Les Voleurs",
};
b.Ajouter(c1);
b.Ajouter(c2);
b["1"].Depot(1000);
b["2"].Depot(500);
Console.WriteLine($"Compte {b["1"].Numero} : {b["1"].Solde} €");
Console.WriteLine("_______________________");
Console.WriteLine($"Compte {b["2"].Numero} : {b["2"].Solde} €");
Console.WriteLine("_______________________");
c1.Titulaire.Prenom = "Toto";

foreach (KeyValuePair<string, Courant> kvp in b.Comptes)
{
    Console.WriteLine($"Compte {kvp.Value.Numero} : {kvp.Value.Solde} €");
}
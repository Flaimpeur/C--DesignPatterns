public class Vendeur
{
    private ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse construit(string nomClient)
    {
        constructeur.construireBonDeCommande(nomClient);
        constructeur.construireDemandeImmatriculation(nomClient);
        return constructeur.getProduit();
    }
}

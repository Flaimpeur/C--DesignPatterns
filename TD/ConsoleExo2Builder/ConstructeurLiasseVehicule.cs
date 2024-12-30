using System;

public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse;

    public abstract void construireBonDeCommande(string client);
    public abstract void construireDemandeImmatriculation(string client);

    public Liasse getProduit()
    {
        return liasse;
    }
}
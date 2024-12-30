public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculePdf()
    {
        liasse = new LiassePdf();
    }

    public override void construireBonDeCommande(string nomClient)
    {
        
    }

    public override void construireDemandeImmatriculation(string nomClient)
    {
        
    }
}
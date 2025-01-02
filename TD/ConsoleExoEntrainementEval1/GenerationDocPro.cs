public class GenerationDocPro : GenerationDocument
{
    public RIB generationRIB(string ribClient)
    {
        return new RIBPro(ribClient);
    }

    public AttestationCompte generationAttestation(string AttestationCompte)
    {
        return new AttestationCompteDetailler(AttestationCompte);
    }
}
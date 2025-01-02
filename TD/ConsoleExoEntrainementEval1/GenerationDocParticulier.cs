public class GenerationDocParticulier : GenerationDocument
{
    public RIB generationRIB(string ribClient)
    {
        return new RIBParticulier(ribClient);
    }

    public AttestationCompte generationAttestation(string AttestationCompte)
    {
        return new AttestationCompteStandardiser(AttestationCompte);
    }
}
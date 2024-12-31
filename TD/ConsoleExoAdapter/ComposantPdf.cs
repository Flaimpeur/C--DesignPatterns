using System;

public abstract class ComposantPdf
{
    public abstract void pdfFixeContenu(string contenu);
    public abstract void pdfPreparerAffichage();
    public abstract void pdfRafraichir();
    public abstract void pdfTermineAffichage();
    public abstract void pdfEnvoieImprimante();
}
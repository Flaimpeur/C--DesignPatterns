public class DocumentPdf : IDocument
{
    private string _contenu;
    private ComposantPdf outilPdf;

    public void setContenu(string contenu)
    {
        _contenu = contenu;
        this.outilPdf.pdfFixeContenu(contenu);
    }

    public void dessin()
    {
        this.outilPdf.pdfPreparerAffichage();
        this.outilPdf.pdfRafraichir();
        this.outilPdf.pdfTermineAffichage();
    }

    public void imprime()
    {
        this.outilPdf.pdfEnvoieImprimante();
    }
}
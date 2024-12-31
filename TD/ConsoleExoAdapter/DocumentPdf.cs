public class DocumentPdf : IDocument
{
    protected ComposantPdf outilPdf = new ComposantPdf();

    public string contenu
    {
        set
        {
            outilPdf.pdfFixeContenu(value);
        }
    }

    public void dessin()
    {
        outilPdf.pdfPreparerAffichage();
        outilPdf.pdfRafraichir();
        outilPdf.pdfTermineAffichage();
    }

    public void imprime()
    {
        outilPdf.pdfEnvoieImprimante();
    }
}
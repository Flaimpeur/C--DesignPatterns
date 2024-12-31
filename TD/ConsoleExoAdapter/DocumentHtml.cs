public class DocumentHtml : IDocument
{
    private string _contenu;

    public void setContenu(string contenu)
    {
        _contenu = contenu;
    }

    public void dessin()
    {
        Console.WriteLine("On est en dessin HTML");
    }

    public void imprime()
    {
        Console.WriteLine("On est en imprime HTML");
    }
}
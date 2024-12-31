public class DocumentHtml : IDocument
{
    private string _contenu;

    public string contenu
    {
        protected get
        {
            return _contenu;
        }
        set
        {
            _contenu = value;
        }
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
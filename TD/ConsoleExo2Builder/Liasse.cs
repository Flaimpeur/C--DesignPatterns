public abstract class Liasse
{
    protected IList<string> documents =  new List<string>();

    public void ajouteDocument(string document)
    {
        documents.Add(document);
    }
    public abstract void imprime();
}
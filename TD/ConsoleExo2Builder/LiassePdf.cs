public class LiassePdf : Liasse
{
    public override void imprime()
    {
        Console.WriteLine("Liasse PDF :");
        foreach (string doc in documents)
        {
            Console.WriteLine(doc);
        }
    }
}
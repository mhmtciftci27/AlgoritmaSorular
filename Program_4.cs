internal class Program4
{
    private static void Main(string[] args)
    {
        // Ödev 4 
        Console.WriteLine("Bir Cümle Giriniz: ");
        string cumle = Console.ReadLine();
        
        string cumle2 = cumle.Replace(" ","");
        int uz = cumle2.Length;
        Console.WriteLine("Toplam harf Sayısı: "+ uz);

        string[] cumle3 = cumle.Split(' ');

        int kelime = cumle3.Count();
        Console.WriteLine("Toplam kelime Sayısı: "+ kelime);
    }
}
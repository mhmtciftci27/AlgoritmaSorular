internal class Program3
{
    private static void Main4(string[] args)
    {
        // Ödev 2 
        Console.WriteLine("Pozitif Bir Sayı Giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        string[] kelimeler= new string[n];

        Console.WriteLine(n + " adet kelime giriniz.");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i+1 +". Kelimeyi giriniz");
            kelimeler[i] = Console.ReadLine();
        }

        for (int i = 1; i <=n; i++)
        {
            Console.WriteLine(kelimeler[n-i]);
        }
    }
}
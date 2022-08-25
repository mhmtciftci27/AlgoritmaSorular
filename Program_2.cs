internal class Yenipogram
{
    private static void Main3(string[] args)
    {
        // Ödev 2 
        Console.WriteLine("Pozitif iki Sayı Giriniz. İlk Rakam: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Pozitif iki Sayı Giriniz. İkinci Rakam: ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        int[] sayilar= new int[n];
        Console.WriteLine(n + " Pozitif sayı giriniz.");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i+1 +". Pozitif Sayıyı giriniz");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(m + "ile bölünen ve eşit sayılar");
        foreach (var item in sayilar)
        {
            if(item%m==0)
                Console.WriteLine(item);            
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        // Ödev 1 
        Console.WriteLine("Bir Sayı Giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] sayilar= new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i+1 +". Pozitif Sayıyı giriniz");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Çift Olan Sayılar");
        foreach (var item in sayilar)
        {
            if(item%2==0)
                Console.WriteLine(item);            
        }
    }
}
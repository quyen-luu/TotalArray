public class Program
{
    private static void Main(string[] args)
    {
        //B1: khai bao mang
        Console.Write("Nhap so phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Nhap tung phan tu: ");

        //B2: them phan tu vao mang
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Phan tu: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int item in numbers)
        {
            Console.Write(item + "; ");
        }
        Console.WriteLine();

        int totalArray = 0;
        foreach (int item in numbers)
        {
            totalArray += item;
        }
        Console.WriteLine($"Tong cac phan tu trong mang la: {totalArray}");
    }
}
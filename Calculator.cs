class Calculator
{
     static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int a = 10;
            int b = 6;

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian" + a + " / " + b + " = " + Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.WriteLine();


        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
}
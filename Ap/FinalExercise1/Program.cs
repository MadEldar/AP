namespace FinalExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var samsung = new MobilePhone("SamSung", 1000000);
            var iPhone = new MobilePhone("IPhone", 2000000);
            samsung.Display();
            iPhone.Display();
        }
    }
}
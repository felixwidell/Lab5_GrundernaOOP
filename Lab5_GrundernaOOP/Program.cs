namespace Lab5_GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newCircle = new Circle();
            newCircle.Radius = 5;
            Console.WriteLine("Cirkel med radie 5 har arean: " + newCircle.GetArea().ToString("#.00"));
            newCircle.Radius = 6;
            Console.WriteLine("Cirkel med radie 6 har arean: " + newCircle.GetArea().ToString("#.00"));
            Console.WriteLine("Cirkel med radie 6 har Omkretsen: " + newCircle.GetCircumference().ToString("#.00"));
            Console.WriteLine("Glob med radie 6 har Volymen: " + newCircle.GetSphereVolume().ToString("#.00"));
        }
    }
}
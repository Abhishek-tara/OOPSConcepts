namespace OOPSConcepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Constructor Demo
            ConstructorDemo demoOne = new ConstructorDemo();
            ConstructorDemo demoTwo = new ConstructorDemo("Bruce", 45);
            demoTwo.Display();

            //Interface Demo
            InheritanceDemo objOne = new InheritanceDemo();
            objOne.methodOne();

            //Enum Demo
            Console.WriteLine(Members.Abhi);
            int count = (int)Members.Abhi;
            Console.WriteLine(count);

            // Inheritance Demo
            ChildClass obj = new ChildClass();
            obj.Nationality = "Indian";
            obj.methodOne();

            

        }
    }
}

namespace OOPSConcepts
{
    public class Program : AbstractionDemo
    {
        public static void Main(string[] args)
        {
            //Constructor Demo
            //ConstructorDemo demoOne = new ConstructorDemo();
            //ConstructorDemo demoTwo = new ConstructorDemo("Bruce", 45);
            //demoTwo.Display();

            //Interface Demo
            //InheritanceDemo objOne = new InheritanceDemo();
            //objOne.methodOne();

            //Enum Demo
            //Console.WriteLine(Members.Abhi);
            //int count = (int)Members.Abhi;
            //Console.WriteLine(count);

            // Inheritance Demo
            //ChildClass obj = new ChildClass();
            //obj.Nationality = "Indian";
            //obj.methodOne();

            //Abstract method
            //Program obj = new Program();
            //obj.methodNormal();
            //obj.methodAbstract();

            //Type casting
            //TypeCasting obj = new TypeCasting();
            //obj.Method();

            //ValueType
            //ValueType obj = new ValueType();
            //obj.ValueTypeMethod();

            //Reference Type
            //ReferenceType obj = new ReferenceType();
            //int val = 5;
            //Console.WriteLine(val);
            //obj.ReferenceMethod(ref val);
            //Console.WriteLine(val);

            //Encapsulation
            //Encapsulation obj = new Encapsulation();
            //Console.WriteLine(obj.Name);
            //obj.Name = "Clark";
            //Console.WriteLine(obj.Name);

            //Polymorphism
            OverLoading obj = new OverLoading();
            obj.MethodOne();
            obj.MethodOne(4,"Abc");
            obj.MethodOne(4,"Abc");
            obj.MethodOne();
        }

        // over ride abstract method to provide implementation
        public override void methodAbstract()
        {
            Console.WriteLine("It's a abstract method");
        }
    }
}

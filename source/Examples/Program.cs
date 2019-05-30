class Program
{

    static void Main(string[] args)
    {
        var program = new Program();
        program.Validate();
    }

    class MyClass
    {
        public string Value;
    }

    class MyOtherClass
    {
        public readonly string Value;
        public MyOtherClass(string value)
        {
            Value = value;
        }
    }

    void Validate()
    {
        var validator = new MikValSor.Immutable.ImmutableValidator();

        var myObject = new MyClass { Value = "Value" };
        bool isMyObjectImmutable = validator.IsImmutable(myObject);
        System.Console.WriteLine($"Is myObject immutable: {isMyObjectImmutable}");

        var myOtherObject = new MyOtherClass("Value");
        bool isMyOtherObjectImmutable = validator.IsImmutable(myOtherObject);
        System.Console.WriteLine($"Is myOtherObject immutable: {isMyOtherObjectImmutable}");
    }
    /**
        Output:
        Is myObject immutable: False
        Is myOtherObject immutable: True
    **/



}
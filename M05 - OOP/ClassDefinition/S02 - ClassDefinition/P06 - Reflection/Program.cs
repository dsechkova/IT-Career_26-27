using System.Reflection;

namespace P06___Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public |
           BindingFlags.Instance);
            Console.WriteLine(fields.Length);


            string fieldAge = "age";
            string fieldName = "name";

            Person person = new Person();

            Type personType2 = typeof(Person);
            FieldInfo field = personType2.GetField(fieldAge, BindingFlags.Public |
                BindingFlags.Instance);
            Console.WriteLine(field.GetValue(person));
            field.SetValue(person, 100);
            Console.WriteLine(field.GetValue(person));

            string personTypeName = typeof(Person).Name;
            Type personTypes = Assembly.GetCallingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name == personTypeName);
            ConstructorInfo ctor = personTypes.GetConstructors().First();
            Person person23 = (Person)ctor.Invoke(new object[] { });

        }
    }
}

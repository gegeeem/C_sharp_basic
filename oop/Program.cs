using System;

namespace MyNamespaces
{
    public class Person{
        public string name;
        public string surname;
        private DateOnly dateOfB;
        public Person(string _name, string _surname, DateOnly _dateOfB){
            name = _name;
            surname = _surname;
            dateOfB = _dateOfB;

        }
        public string getDateOfB(){
            return dateOfB.ToString();
        }
    }
public class MyApp{
    public static void Main(){
        Person me = new Person("Emir", "Gegic", new DateOnly(1990, 9, 3) );
        Console.WriteLine($"Name: {me.name}, Surname: {me.surname}, Date of birthday: {me.getDateOfB()}");
    }

}
    
}

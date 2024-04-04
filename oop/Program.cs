using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

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
    class Car{
        string colorN = "red"; // default is private, field
        int maxSpeedN = 200;// field
        public void StartCar(){
            Console.WriteLine($"Car with {this.colorN} color and {this.maxSpeedN} max speed is started");
        }
    }

    class Car1 {
        public string model;
        public int maxSpeed;
        string uniqueNumb = ""; // private
        public Car1(string _model, int _maxSpeed){
            model = _model;
            maxSpeed = _maxSpeed;

        }

       public string UniqueNumb{

        get {return uniqueNumb;} //get method
        set{uniqueNumb = value;} //set method

       }

       

        
    }
public class MyApp{
    public static void Main(){
        Person me = new Person("Sam", "Shark", new DateOnly(1999, 1, 3) );// we can set, but not access dateOfB like prop. Only access by method getDateOfB
        Console.WriteLine($"Name: {me.name}, Surname: {me.surname}, Date of birthday: {me.getDateOfB()}");

        Car peugeot = new Car();
        // Console.WriteLine($"My car is {peugeot.colorN} and have max speed {peugeot.maxSpeedN}" ); dosn t work

        peugeot.StartCar();    

        // creating object with constructor
        Car1 automobile = new Car1("Toyota", 250);
        automobile.UniqueNumb = "NY-255-A";
        Console.WriteLine($"Car model {automobile.model} has {automobile.maxSpeed} max speed, uniqueNum is {automobile.UniqueNumb}");
    }

}
    
}

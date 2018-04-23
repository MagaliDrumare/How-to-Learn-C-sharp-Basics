// Video 13 : Interfaces 
// Une interface est un modèle de classe. 
// Elle contient des méthodes et des propriétés, 
// avec la particularité qu'elle ne fournit pas l'implémentation des méthodes. 
// Cela veut dire qu'on décrit juste les méthodes sans décrire ce qu'elles font.


 
using System;


namespace FIRST
{
    class MainClass{

    interface IAnimal
    {

        string Name { get; }
        void Move(); 

    }

    class Dog : IAnimal
    {
        private string m_name;
         // implement Name properties of the Interface
        public string Name{
            get { return m_name; }
        }

        public Dog(string name){
            m_name = name;
        }

        // implement Move Methods of the Interface 
        public void Move()
        {
            Console.WriteLine("Oups ", m_name);
        }

    }

    public static void Main(string[] args)
            
        {
        IAnimal milou = new Dog("Milou");
        milou.Move();
        }

     }                    

}


 
    

// Video 1 : Hello world! 
//Console.WriteLine("Hello World!");
//Console.WriteLine("Hello Magali, what's up?");
//Console.ReadKey();

// Video 2 : Type of variables 
//int num01 = 20;
//double decimalpoint = 10.2;
//bool trueOrFalse = true;
//string sentence = "tata yoyo"; 

// Video 3 : Calculator to add 
//Start: 
//int num01;
//int num02;

//Console.Write("Fisrt number:");
//num01 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Second number:");
//num02 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Result is: " + num01 * num02);
//Console.ReadKey();
//goto Start;// jump to the start 

//Calculator to devide 
//Start: 
//double num01;
//double num02;

//Console.Write("Fisrt number:");
//num01 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Second number:");
//num02 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Result is: " + num01 / num02);
//Console.ReadKey();
//goto Start;// jump to the start 


// Video 4 : IF Statements 
//Console.WriteLine("What is you age? :");
//int age = Convert.ToInt32(Console.ReadLine()); 
//if(age<18){

//    Console.WriteLine("You are too young"); 

//} else if(age==18) {

//    Console.WriteLine("Your are lucky"); 
//} else {
//    Console.WriteLine("You are too old"); 
//}
//Console.ReadKey();  


// Video 5 : Switch statements 
//Random numberGenerator = new Random();
//int num01 = numberGenerator.Next(1,11);
//int num02 = numberGenerator.Next(1,11);

//Console.WriteLine("Whats is " + num01 + " times " + num02+ "?");

//int result = Convert.ToInt32(Console.ReadLine()); 

//if (result==num01*num02){
//    Console.WriteLine("Good answer");

//} else {

//  int responseIndex = numberGenerator.Next(1,4); 

//      switch(responseIndex){
//      case 1:
//          Console.WriteLine("You're a looser");
//          break;

//      case 2: 
//          Console.WriteLine("You're a big looser");
//          break;

//      default:
//          Console.WriteLine("Try again");
//          break;

//  }

//}


// Video 6 : For loop 
//for (int i = 0; i < 100; i++){
//    Console.Write(i);
//}



//Video 7 : While loop 

//Random numberGenerated = new Random();

//int attempt = 0;
//int numberOfAttempts = 0; 

//while(attempt!=6) {
//    attempt = numberGenerated.Next(1, 7);
//    Console.WriteLine("I rolled : " + attempt+ "!");
//    numberOfAttempts++;
//}

//Console.WriteLine("You need : " + numberOfAttempts + " attemps to make a 6!"); 


// Video 8 : Methods simple 

//using System;

//namespace FIRST
//{
//    class Program
//    {
//        static void Main(string[] args) // this is the method call "Main". called when the program starts
//        {

//            Goodbye();
//            // Videos 8 : methods 
//            Console.ReadKey();


//        }
//        public static void Goodbye()
//        {

//            Console.WriteLine("Goodbye Lenine!");
//        }

//    }
//}


// Video 8 : Methods complex 
//using System;

//namespace FIRST
//{
    //class Program
    //{
        //static void Main(string[] args) // this is the method call "Main". called when the program starts
        //{

        //    int result = Add(13, 5);
        //    if (result > 10)
        //    {
        //        Console.WriteLine("Good result");
        //    }
        //    else if (result < 10)
        //    {
        //        Console.WriteLine("Bad result");
        //    }

        //    Console.ReadKey();


        //}
        //public static int Add(int num01, int num02)
        //{

        //    return num01 + num02;
        //}

//    }
//}



// Video 9 : Creation array 
            // string[] names =new string[3]{"MC", "Alain", "Yann"};
            //int[] numbers = new int[5];
            //numbers[0] = 50;
            //numbers[1] = 3;
            //numbers[4] = 15;
           

            //for (int i = 0; i < numbers.Length; i++) {

                //Console.WriteLine(numbers[i]);

                //foreach(int number in numbers){
                    //Console.WriteLine(); 

                //}

// Video 9 : List
// cw  double ->| Console.WriteLine
//List<int> numbers = new List<int>();
//numbers.Add(17);
//numbers.Add(4);
//numbers.Add(8);

//for (int i = 0; i < numbers.Count; i++){
//       Console.WriteLine(numbers[i]);
//    numbers.Remove(4);
//}

//Video 9 : Grid 
//using System;
//using System.Collections.Generic;

//namespace FIRST
//{
    //class Program
    //{
        //static void Main(string[] args) // this is the method call "Main". called when the program starts
        //{
        //    CreateGrid();

        //}


        //public static void CreateGrid()
        //{

            //int width = 5;
            //int height = 5;

            //int[,] grid = new int[width, height];
            // int[][] grid = new int [width][height];
            //for (int x = 0; x < width; x++)
            //{

            //    for (int y = 0; y < height; y++)
            //    {

            //        grid[2, 3] = 5;
            //        Console.WriteLine(grid[x, y] + "");
            //    }

            //    Console.WriteLine();
            //}


// Video 10 : Classes 
// modifiers : private (inside to same class), 
//public (accessible to all class) 
//and static (shared by all the instances of a class 

//using System;
//using System.Collections.Generic;

//namespace FIRST
//{


//    class Animal
//    {

//        //public static int Count = 0;
//        //public string name = "Toto";
//        //public int age = 3;
//        //public float hapiness = 0.5f;
//// Variables 
//        public string name;
//        public int age;
//        public float happiness;
////Constructor 

//     public Animal(){

//        name = "Toto"; 
//        age= 13; 
//        happiness= 5f;
//    }

//        public Animal(string _name, int _age, float _happiness){

//            name = _name;
//            age = _age;
//            happiness = _happiness;

//        }
//        // Methods 
//        public void Print(){
//        Console.WriteLine("Name "+ name);
//        Console.WriteLine("Age " + age);
//            Console.WriteLine("Happiness " + happiness);

//    }


//    class Program
//    {
//static void Main(string[] args) // this is the method call "Main". called when the program starts
//        {

//            Animal dog = new Animal();
//            Animal cat = new Animal("Titi", 8, 9f);
//                //Animal.Count += 2;
//                //Console.WriteLine(Animal.Count);
//                dog.Print();
//                cat.Print(); 

           
//            }
//        }
                
       
//    }  

//} 



// Video 11 : Inheritance 

//using System;
//using System.Collections.Generic;

//namespace FIRST
//{
//    class MainClass
//    {
//            class Animal 
//            {
//                public string name;
//                public int age;
//                public float happiness;

//                public void Print(){
//                    Console.WriteLine("name "+ name);
//                    Console.WriteLine("age " + age);
//                    Console.WriteLine("hapiness " + happiness);
//                 }

//              } 

//            class Dog: Animal
//            {

//                public int count; 
//                public void Ouarf() {
//                    Console.WriteLine("Ouarf");
//                } 
//            }
             
//        class Cat: Animal {
//            public float cuteness; 
//            public void Miaou(){
//                Console.WriteLine("MIAOUUU");
//            }

//        }

      
//         public static void Main(string[] args) // this is the method call "Main". called when the program starts
            
//        {   Dog puppy = new Dog();
//            puppy.name = "Puppy";
//            puppy.age = 9;
//            puppy.happiness = 0.8f;
//            puppy.count = 156;
//            puppy.Ouarf();
//            puppy.Print();

//            Cat chachou = new Cat();
//            chachou.name = "Kittie";
//            chachou.age = 7;
//            chachou.happiness = 25f;
//            chachou.Print();
//            chachou.Miaou();

//            Console.ReadKey();  
//          }

//     }
                  
//}  



// Video 12 : Inheritance 

//using System;
//using System.Collections.Generic;

//namespace FIRST
//{
//    class MainClass
//    {
//        enum Breed { Tata, Yoyo, Milou, Tintin }; 
            
//        class Animal  
//            {
//                public string name;
//                public int age;
//                public float happiness;

//              } 

//            class Dog: Animal
//            {

//            public Breed breed; 
//            public Dog (string _name,int _age, float _happiness, Breed _breed)
//            {
//                name = _name;
//                age = _age;
//                happiness = _happiness;
//                breed = _breed;
            
//            }

//            public void Print()
//            {
//                Console.WriteLine("name " + name);
//                Console.WriteLine("age " + age);
//                Console.WriteLine("happiness " + happiness);
//                Console.WriteLine("Breed " + breed);
//            }
               
//            public static void Main(string[] args) // this is the method call "Main". called when the program starts
            
//        {
//                Dog warf = new Dog("Titin", 9, 8f, Breed.Milou);
//                warf.Print();
//            }

//     }                    
//} 

//} 

// Video 13 : Properties 
// "get" and "set" are the mechanism for encapsualting acces through a property, 
// rather than allowing direct access to a field.
 
//using System;

//namespace FIRST
//{
    //class MainClass
    //{  

     //   class Player {
     //   private int _health = 100; 
     //   public int health
     //   {

     //       get{
     //           return _health;
     //       }

     //       set{

     //           if (value<=0){
     //               _health = 0;
     //           } else if (value >=100) {
     //               _health = 100; 
     //           } else {
     //               _health = value; 
     //           }
               
     //       }
     //   }
     //}
               
     //   public static void Main(string[] args)
            
     //   {
     //       Player TataYoyo = new Player();
     //       TataYoyo.health = -100; 
     //       Console.WriteLine(TataYoyo.health);
     //   }

     //}  






/*
    * datatype variableName = value ;
    *  camalCase  | PascalCase 
*/



// Contcatenation 
Console.Write("Enter your name :  ");
string firstName =  Console.ReadLine()  ;


Console.Write("Enter your city :  ");
string city = Console.ReadLine() ;


Console.Write("Enter your age :  ");
string ageInput = Console.ReadLine() ;
int age = int.Parse(ageInput) ;

Console.WriteLine($"Hello,  {firstName} , your city is {city} ! ");
Console.WriteLine($" your age is {age} !  , and your age after 5 years is {age + 5 }");


/*
* Type Conversions 
*--------------------
*   1- implicit 
*    2- Explicit 
*   3- coversion (parse , convert )
*
*/
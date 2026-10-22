/*
**  if statment 
** -------------- 
**  if(condition) {
**        statment
**  }else{
**        statment
**  }
**  
*** = => Assignment
    == => Equal 
*/
// Console.Write("Inter the grade : ");

// string gradeInput = Console.ReadLine();

// int grade = int.Parse(gradeInput);

// if (grade >= 90 )
// {
//     Console.WriteLine("Excellent");
// }
// else if (grade >= 80)
// {
//     Console.WriteLine("Very Good");

// }
// else if (grade >= 70)
// {
//     Console.WriteLine(" Good");

// }
// else if (grade >= 50)
// {
//     Console.WriteLine("Passed");

// }
// else
// {
//     Console.WriteLine("Need to Improvments");

// }




/*
*  Logical operator
* --------------------
   && => and 
   || => OR
   ! => Not 
*/

// int age  = 50 ;
// bool isStudent = true ;

// if(!(age < 27) && isStudent == true)
// {
//     Console.WriteLine("Access Allowed") ;
// }
// else
// {
//         Console.WriteLine("Access Denied") ;

// }


// Console.Write("Inter the day between ( 1 to 7 )  : ");

// string dayInput = Console.ReadLine();

// int day = int.Parse(dayInput);

// switch (day)
// {
//     case 1:
//         Console.WriteLine("This day is Saturday");
//         break;
//     case 2:
//         Console.WriteLine("This day is Sunday");
//         break;
//     case 3:
//         Console.WriteLine("This day is Monday");
//         break;
//     case 4:
//         Console.WriteLine("This day is Tuesday");
//         break;
//     case 5:
//         Console.WriteLine("This day is Wenesday");
//         break;
//     case 6:
//         Console.WriteLine("This day is Thursday");
//         break;
//     case 7:
//         Console.WriteLine("This day is Friday");
//         break;
//     default:
//         Console.WriteLine("Invaild Selection");
//         break;


// }


/*
string dayName = day switch
{
    1 => "Saturday",
    2 => "Sunday",
    3 => "Monday",
    4 => "tuesday",
    5 => "wensday",
    6 => "thursday",
    7 => "friday",
    _ => "unknwon",
};


Console.WriteLine($"This day is {dayName}");

*/
Console.Write("Select the role (Admin , Moderator , Student ) :  ");

string role = Console.ReadLine().ToLower();


string roleName = role switch
{
    "admin" => "Admin",
    "moderator" => "Moderator",
    "student" => "Student",
    _ => "unkwoun ",
};

Console.Write($"Your role is  {roleName}");

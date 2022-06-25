// See https://aka.m
// s/new-console-template for more information
//password genrator
string choice;
Console.WriteLine(" if u want to  genrate password please enter 'y'");
choice = Console.ReadLine();

while (choice == "y")
{
    Random r = new Random();
    
    string password;
    string password1;


    String b = "abcdefghijklmnopqrstuvwxyz";
    int length = 6;
    string random = "";

    for (int i = 0; i < length; i++)
    {

        int a = r.Next(0, 26);
        random=random+b.ElementAt(a);
    }
    int num =r.Next();
    password = num.ToString();
    int num2=r.Next();
    password1 = num2.ToString();
    if (password1 == password)
    {
       int p=int.Parse(password1);
        p += 2;
       password= p.ToString();



    }

    Console.WriteLine("your password is :-" + password + random.ToUpper() +password1);
    Console.WriteLine("password saved susccefully !");










   

   




    Console.WriteLine(" if you want to change ur password enter (y)");
    choice = Console.ReadLine();
    Console.WriteLine("password updated !");



}


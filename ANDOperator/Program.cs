

//Math >= 90; Biology >= 90; Chemistry >= 90;


using System.Transactions;

int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratz, Your application is accepted!");
}
else
{
    Console.WriteLine("Your application cannot be accepted.");
}
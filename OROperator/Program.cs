

//Math >= 90 OR Chemistry >= 90 OR Biology >= 90;

//math && chemistry || math && biology || biology && chemistry;

int math, chemistry, biology;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (biology >= 90 && chemistry >= 90))
{
    Console.WriteLine("Your application is accepted!");
}
else
{
    Console.WriteLine("Your application cannot be accepted.");
}


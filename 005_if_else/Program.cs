Console.Write("Введите имя пользователя ");
string uzername = Console.ReadLine();

if(uzername.ToLower() == "ксюша")
{
   Console.WriteLine("Ура! Это же Ксюша");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(uzername);
}
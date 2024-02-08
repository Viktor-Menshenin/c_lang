Console.WriteLine("Введите ваше имя");
string userName = Console.ReadLine();
if(userName.ToLower() == "маша"){
    Console.WriteLine("Ура это Маша!");
}else{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}
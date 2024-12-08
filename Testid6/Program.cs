//string hello = "Hello, world!".;
//int counter = 0;

//for (int i = 0; i < hello.Length; i++)
//{
//    if (hello[i] =='1')
//    {
//        counter++;
//    }
//}
//Console.WriteLine($"There are {counter} l's in the string \"{hello}\"");

//string hello = "hello!";
//hello = hello.Replace(hello[0],char.ToUpper(hello[0]));
//Console.WriteLine(hello);

string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();
var randomColor = colors[rnd.Next(0,colors.length)];
Console.WriteLine($"You should wear {colors[randomColor]} today.");
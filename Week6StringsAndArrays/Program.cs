string hello = " we are the champions?";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];

Console.WriteLine(firstLetter);

Console.WriteLine(hello);


//string hello = " hello, world! ";

//int stringLength = hello.Length;

//string trimmedString = hello.Trim(); 

//Console.WriteLine(stringLength); teist korda Console.WriteLine(trimmedString.Length);

//---------------------------------------------------------------------------------------------------------

//string hello = " hello, world! ";

//int stringLength = hello.Length;

//hello = hello.Trim();

//int wordCounter = 0;

//for (int i = 0; i < hello.Length; i++)
//{
//  Console.WriteLine($"{i} symbol in string: {hello[i]}");
//}

// Console.WriteLine(hello.Length);

//--------------------------------------------------------------------------------------------------------

//string hello = " hello, world! ";

//int stringLength = hello.Length;

//hello = hello.Trim();

//int wordCounter = 1;

//for (int i = 0; i < hello.Length; i++)
//{
//    if (hello[i] == ' ')
//    {
//      wordCounter++;
//  }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");

//--------------------------------------------------------------------------------------------------------


//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");

//Console.WriteLine(hello.Length);


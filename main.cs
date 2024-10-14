// // Executar seu primeiro programa!
// //Console.WriteLine("Hello World");

// //Declarar e usar variáveis

// string Friend = "Clary";
// //Console.WriteLine(Friend);
// Console.WriteLine("Hello " + Friend);
// // ---------- // ------------

// Friend = "Saw";
// //Console.Write(Friend);

// Console.WriteLine("Hello " + Friend);

// // ---------- // ------------

// Friend = "Sophie";
// Console.WriteLine($"Hello {Friend}");

// // ---------- // ------------

// // Trabalhar com cadeias de caracteres

// string firstFriend = "Minnv";
// string secondFriend = "Octers";
// Console.WriteLine($"Meu amigo {firstFriend} e {secondFriend}");

// // Parametro Length

// Console.WriteLine($"O nome {firstFriend} contém {firstFriend.Length} letras");
// Console.WriteLine($"O nome {secondFriend} contém {secondFriend.Length} letras");

// // Testes demasiados

// Console.WriteLine(Friend.ToLower());

// 14/10/2024 testes com a linguagem

// string nome = "Maria";
// Console.WriteLine($"Olá {nome}");

// string greeting = "      Hello World!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

// string texto = "Não mataras";
// Console.WriteLine(texto);
// texto = texto.Replace("mataras","faltaras");
// Console.WriteLine(texto);
// Console.WriteLine(texto.ToUpper());
// Console.WriteLine(texto.ToLower());

// string letrasMusica = "Teste de caracteres e sons";
// Console.WriteLine(letrasMusica.Contains("Teste"));
// Console.WriteLine(letrasMusica.Contains("teste"));
// Console.WriteLine(letrasMusica.StartsWith("Teste"));
// Console.WriteLine(letrasMusica.EndsWith("sons"));

//Manipular números inteiros e de ponto flutuante

// int a = 22;
// int b = 45;
// int c = a + b;
// Console.WriteLine(c);

// Explorar a ordem das operações

// int a = 20;
// int b = 10;
// int c = 2 + (a*2) / (b*2);
// Console.WriteLine(c);

// Explorar a precisão de inteiros e limites

// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine($"Quociente: {d}");
// Console.WriteLine($"Resto: {e}");

// int max = int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"The range of integers is {min} to {max}");

// int what = max + 10;
// Console.WriteLine($"An example of overflow: {what}");

// double a = 19;
// double b = 23;
// double c = 8;
// double d = (a + b) / c;
// Console.WriteLine(d);

// double max = double.MaxValue;
// double min = double.MinValue;
// Console.WriteLine($"The range of double is {min} to {max}");

// double third = 1.0 / 3.0;
// Console.WriteLine(third);
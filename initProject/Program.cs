
// int counter = 0;

// while (counter < 10) 
// {
//     Console.WriteLine("Teste " + counter);
//     Thread.Sleep(1000);
//     counter++;
// }

// Do while

int counter = 0; 
do
{
    Console.WriteLine($"Teste {counter}");
    counter++;
    Thread.Sleep(500);
} while (counter < 20);
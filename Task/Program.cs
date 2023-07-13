using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
//Programacion asincrona

Stopwatch sw = Stopwatch.StartNew();

var task = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    //codigo, Task, etc
    //int num = 0;
    /*for (int i = 0; i <= 1000; i++) {
        num += i;
    }
    crono.Stop();
    */
    Console.WriteLine($"Task 1: {crono.Elapsed}");
});

var task2 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    //codigo, Task, etc
    //int num = 0;
    /*for (int i = 0; i <= 1000; i++) {
        num += i;
    }
    crono.Stop();
    */
    Console.WriteLine($"Task 2:{crono.Elapsed}");
});

var task3 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    //codigo, Task, etc
    //int num = 0;
    /*for (int i = 0; i <= 1000; i++) {
        num += i;
    }
    crono.Stop();
    */
    Console.WriteLine($"Task 3: {crono.Elapsed}");
});

task.Start();
task2.Start();
task3.Start();

await task;
await task2;
await task3;
sw.Stop();
Console.WriteLine($"Main:{sw.Elapsed}");

static async Task<String> RandomAsync() {
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    sw.Stop();
    var str = ($"{num.ToString()} calculado en: {sw.Elapsed}");
    Console.WriteLine( str );
    return str;
}


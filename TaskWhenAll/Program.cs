
await DoAll();

async Task DoIt()
{
    await Task.Delay(1000);
    Console.WriteLine("DoIt");
}

async Task DoItAgain()
{
    await Task.Delay(1500);
    Console.WriteLine("IDoItAgain");
}

async Task DoSomething()
{
    await Task.Delay(300);
    Console.WriteLine("IDoSomething");
}

void WhenAll()
{
    Console.WriteLine("All Done..");
}

async Task DoAll()
{
    await Task.WhenAll(DoIt(), DoItAgain(), DoSomething());
    WhenAll();
}
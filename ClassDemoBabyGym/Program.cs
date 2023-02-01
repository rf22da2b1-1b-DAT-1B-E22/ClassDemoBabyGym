// See https://aka.ms/new-console-template for more information
using ClassDemoBabyGym.model;

Console.WriteLine("Hello, World!");

Hold hold = new Hold(34,"sjovGym", 400, 3);
SvoemmeHold shold = new SvoemmeHold(22, "deGladesvømmere", 500, 10, "Svømmehallen ved Kirkegården");
Console.WriteLine(shold);

Console.WriteLine(hold);


HoldKatalog kat = new HoldKatalog();
kat.TilføjHold(hold);
kat.TilføjHold(shold);

Console.WriteLine(kat);

Hold FundetHold = kat.FindHold(34);
Console.WriteLine(FundetHold);


Deltager deltager = new Deltager("Peter", "Roskilde", 2);
hold.TilmeldDeltager(deltager);
Console.WriteLine("tilmeldt");
hold.TilmeldDeltager(deltager);

try
{
    kat.TilføjHold(hold);
}
catch(ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}






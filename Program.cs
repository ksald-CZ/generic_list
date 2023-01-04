using generic_list;

Repository<string> s = new Repository<string>();
s.Cerate("adam");
s.Cerate("pavel");
s.Cerate("radim");
s.Cerate("adela");
Console.WriteLine(s.Read(0));
Console.WriteLine(s.Read(1));
Console.WriteLine(s.Read(2));
Console.WriteLine(s.Read(3));
s.Update(0, "viktor");
Console.WriteLine(s.Read(0));
Console.WriteLine(s.Read(1));
Console.WriteLine(s.Read(2));
Console.WriteLine(s.Read(3));
Console.WriteLine (s.GetCount());
//s.Delete(0);
Console.WriteLine(s.Read(0));
Console.WriteLine(s.Read(1));
Console.WriteLine(s.Read(2));
Console.WriteLine(s.Read(3));
//s.Clear();
Console.WriteLine(s.GetCount());
foreach (var x in s.AsArray())
{
    Console.WriteLine(x);
}
foreach (var item in s)
{
    Console.WriteLine(item);
}
var en = s.GetEnumerator();

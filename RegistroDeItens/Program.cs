using a;


List<Item> itens = new List<Item>();
string[] cs = Console.ReadLine().Split(' ');
for (int x = 0; x < cs.Length; x++)
{
    var item = itens.FirstOrDefault(a => a.Name == cs[x]);
    // verifica se existe o item
    if (itens.Contains(item))
    {
        item.Quantity++;
    }
    else
    {
        itens.Add(new()
        {
            Name = cs[x],
            Quantity = 1
        });
    }
}


foreach (var item in itens)
{
    Console.WriteLine(item);
}

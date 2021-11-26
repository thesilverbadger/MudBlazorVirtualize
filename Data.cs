namespace MudBlazorVirtualize
{
    public class Item
    {
        public string Name { get; set; }

        public int Index { get; }

        public string PartnerName { get; }

        public string Field1 { get; }

        public string Field2 { get; }

        public string Field3 { get; }

        public string Field4 { get; }

        public string Field5 { get; }

        public Item(int index)
        {
            Name = $"Name: {index}";
            Index = index;
            PartnerName = $"Partner {index}";
            Field1 = $"Lorum Ipsum {Index}";
            Field2 = $"Lorum Ipsum {Index}";
            Field3 = $"Lorum Ipsum {Index}";
            Field4 = $"Lorum Ipsum {Index}";
            Field5 = $"Lorum Ipsum {Index}";
        }
    }

    public static class Data
    {
        private static List<Item> _items;

        public static List<Item> Items
        {
            get
            { 
                if( _items == null)
                {
                    _items = new List<Item>();

                    _items.Add(new Item(0));

                    for (var i = 1; i < 100; i++)
                    {
                        _items.Add(new Item(i));
                    }

                    _items = _items.OrderBy(x => x.Index).ToList();
                }

                return _items;
            }
        }
    }
}

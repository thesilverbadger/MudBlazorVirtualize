namespace MudBlazorVirtualize
{
    public class Data
    {
        public string Name { get; set; }

        public int Index { get; }

        public string PartnerName { get; }

        public string Field1 { get; }

        public string Field2 { get; }

        public string Field3 { get; }

        public string Field4 { get; }

        public string Field5 { get; }

        public Data(int index)
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
}

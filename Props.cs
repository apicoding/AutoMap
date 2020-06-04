
namespace AutoMap
{
    internal struct Item
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    internal class Props
    {
        public string Foo { get; set; } = "123";
        public int Bar { get; set; } = 456;
        public Item MyItem { get; set; } = new Item { Name = "Name", Value = "Value" };
    }
}
using System.Collections.Generic;

namespace DoubleRecyclerView.Model
{
    public class ItemSection
    {
        public ItemSection()
        {
            Items = new List<Item>();
        }

        public string Title { get; set; }
        public List<Item> Items { get; set; }
    }
}
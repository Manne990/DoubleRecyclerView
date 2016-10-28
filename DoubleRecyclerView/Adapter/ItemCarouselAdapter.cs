using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using DoubleRecyclerView.Model;
using DoubleRecyclerView.ViewHolder;

namespace DoubleRecyclerView.Adapter
{
    public class ItemCarouselAdapter : RecyclerView.Adapter
    {
        private readonly List<Item> _items;
        private readonly int _viewSize;
        private readonly int _imageSize;

        public ItemCarouselAdapter(List<Item> items, int viewSize, int imageSize)
        {
            _items = items;
            _viewSize = viewSize;
            _imageSize = imageSize;
        }

        public override int ItemCount => _items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = (ItemViewHolder)holder;

            viewHolder.Update(_items[position]);
            viewHolder.Container.LayoutParameters = new ViewGroup.LayoutParams(_viewSize, _viewSize);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ItemViewLayout, parent, false);

            return new ItemViewHolder(itemView, _imageSize);
        }
    }
}
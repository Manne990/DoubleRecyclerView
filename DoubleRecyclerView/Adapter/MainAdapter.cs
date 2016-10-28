using System.Collections.Generic;
using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using DoubleRecyclerView.Model;
using DoubleRecyclerView.ViewHolder;

namespace DoubleRecyclerView.Adapter
{
    public class MainAdapter : RecyclerView.Adapter
    {
        private const int ImageMaxDpi = 2;
        private readonly List<ItemSection> _sections;

        public MainAdapter(List<ItemSection> sections)
        {
            _sections = sections;
        }

        public override int ItemCount => _sections.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var density = Application.Context.Resources.DisplayMetrics.Density;
            var viewHolder = (ItemSectionViewHolder)holder;

            var viewSize = (int)(250 * density);
            var topMargin = ((ViewGroup.MarginLayoutParams)viewHolder.ItemsView.LayoutParameters).TopMargin;
            var bottomMargin = ((ViewGroup.MarginLayoutParams)viewHolder.ItemsView.LayoutParameters).BottomMargin;
            var childViewSize = viewSize - topMargin - bottomMargin;
            var imageSize = density > ImageMaxDpi ? (int)((childViewSize / density) * ImageMaxDpi) : viewSize;

            viewHolder.Container.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, viewSize);
            viewHolder.Update(_sections[position], childViewSize, imageSize);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var section = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ItemSectionLayout, parent, false);

            return new ItemSectionViewHolder(section);
        }

        public bool ShouldRefresh()
        {
            return _sections.Count == 0;
        }

        public void UpdateSections()
        {
            if (_sections.Count == 0)
            {
                return;
            }

            NotifyItemInserted(ItemCount - 1);
        }
    }
}
using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DoubleRecyclerView.Adapter;
using DoubleRecyclerView.Model;

namespace DoubleRecyclerView.ViewHolder
{
    public class ItemSectionViewHolder : RecyclerView.ViewHolder
    {
        private readonly TextView _titleTextView;

        public ItemSectionViewHolder(View itemView) : base(itemView)
        {
            Container = itemView.FindViewById<RelativeLayout>(Resource.Id.container);

            _titleTextView = itemView.FindViewById<TextView>(Resource.Id.captionTextView);

            ItemsView = itemView.FindViewById<RecyclerView>(Resource.Id.itemsRecyclerView);

            ItemsView.SetLayoutManager(new LinearLayoutManager(Application.Context, LinearLayoutManager.Horizontal, false));
        }

        public void Update(ItemSection section, int viewSize, int imageSize)
        {
            _titleTextView.Text = section.Title;

            var adapter = new ItemCarouselAdapter(section.Items, viewSize, imageSize);

            ItemsView.SetAdapter(adapter);
        }

        public RelativeLayout Container { get; }
        public RecyclerView ItemsView { get; }
    }
}
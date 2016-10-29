using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DoubleRecyclerView.Helper;
using DoubleRecyclerView.Model;

namespace DoubleRecyclerView.ViewHolder
{
    public class ItemViewHolder : RecyclerView.ViewHolder
    {
        private readonly ImageView _backgroundImageView;
        private readonly ProgressBar _progressBar;
        private readonly TextView _titleTextView;
        private readonly int _imageSize;

        public ItemViewHolder(View itemView, int imageSize) : base(itemView)
        {
            Container = itemView.FindViewById<RelativeLayout>(Resource.Id.container);

            _backgroundImageView = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            _progressBar = itemView.FindViewById<ProgressBar>(Resource.Id.progressBar);
            _titleTextView = itemView.FindViewById<TextView>(Resource.Id.captionTextView);

            _imageSize = imageSize;
        }

        public RelativeLayout Container { get; }

        public void Update(Item item)
        {
            _titleTextView.Text = item.Title;

            ImageLoader.LoadImage(item.ImageUrl, _imageSize, _imageSize, _backgroundImageView, _progressBar);
        }
    }
}
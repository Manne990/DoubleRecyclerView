using Android.App;
using Android.Views;
using Android.Widget;
using Square.Picasso;

namespace DoubleRecyclerView.Helper
{
    public static class ImageLoader
    {
        public static void LoadImage(string url, int width, int height, ImageView imageView, ProgressBar progressBar)
        {
            progressBar.Visibility = ViewStates.Visible;

            Picasso.With(Application.Context)
                .Load(url)
                .Resize(width, height)
                .CenterCrop()
                .Into(imageView, () =>
                {
                    progressBar.Visibility = ViewStates.Gone;
                }, () =>
                {
                    progressBar.Visibility = ViewStates.Gone;
                });
        }
    }
}
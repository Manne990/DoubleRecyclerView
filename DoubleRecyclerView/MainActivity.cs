using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using DoubleRecyclerView.Adapter;
using System.Collections.Generic;
using DoubleRecyclerView.Model;

namespace DoubleRecyclerView
{
    [Activity(Label = "DoubleRecyclerView", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private RecyclerView _recyclerView;
        private RecyclerView.LayoutManager _layoutManager;
        private MainAdapter _adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Recycler View - Main Container
            _recyclerView = FindViewById<RecyclerView>(Resource.Id.containerRecyclerView);

            _adapter = new MainAdapter(CreateMockData());

            _recyclerView.SetAdapter(_adapter);

            _layoutManager = new LinearLayoutManager(Application.Context, LinearLayoutManager.Vertical, false);
            _recyclerView.SetLayoutManager(_layoutManager);
        }

        private List<ItemSection> CreateMockData()
        { 
            var sections = new List<ItemSection>();

            sections.Add(new ItemSection()
            {
                Title = "SECTION 1",
                Items = new List<Item>()
                {
                    new Item() { Title = "ITEM 1", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 2", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 3", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 4", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 5", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" }
                }
            });

            sections.Add(new ItemSection()
            {
                Title = "SECTION 2",
                Items = new List<Item>()
                {
                    new Item() { Title = "ITEM 1", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 2", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 3", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 4", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 5", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" }
                }
            });

            sections.Add(new ItemSection()
            {
                Title = "SECTION 3",
                Items = new List<Item>()
                {
                    new Item() { Title = "ITEM 1", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 2", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 3", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 4", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" },
                    new Item() { Title = "ITEM 5", ImageUrl = "https://media.licdn.com/media/AAEAAQAAAAAAAAbNAAAAJDYzOWYyYTkwLTcwZDUtNGQ5Yy1iYjMwLWU5ODc1YmYwNGM4NA.png" }
                }
            });

            return sections;
        }
    }
}
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            tabbar.Items.Add(new ShellContent 
            { 
                Title = "Test",
                Icon = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Microsoft_logo.svg/480px-Microsoft_logo.svg.png")),
                ContentTemplate = new DataTemplate(() =>
                {
                    ObservableCollection<Tile> tiles = new ObservableCollection<Tile>();

                    tiles.Add(new Tile("1", "Tile 1", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("2", "Tile 2", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Surface-Laptop-Go-2-for-Business-Consumer-01?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("3", "Tile 3", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Microsoft-365-Lifestyle-Sandstone-Icon-Toss?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("4", "Tile 4", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/gldn-XSX-CP-Xbox-Series-X?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("5", "Tile 5", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Xbox-Series-S-1TB-Black-Merch-01?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("6", "Tile 6", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Highlight-Games-Starfield-Key-Art:VP5-1596x600")) });
                    tiles.Add(new Tile("7", "Tile 7", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("8", "Tile 8", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Surface-Pro-9-for-Business-Angled-1?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("9", "Tile 9", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Microsoft-365-For-Business-Woman-Teams-Call?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("10", "Tile 10", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("1", "Tile 1", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("2", "Tile 2", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("3", "Tile 3", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("4", "Tile 4", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("1", "Tile 1", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("2", "Tile 2", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Surface-Laptop-Go-2-for-Business-Consumer-01?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("3", "Tile 3", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Microsoft-365-Lifestyle-Sandstone-Icon-Toss?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("4", "Tile 4", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/gldn-XSX-CP-Xbox-Series-X?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("5", "Tile 5", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Content-Card-Xbox-Series-S-1TB-Black-Merch-01?wid=380&hei=213&fit=crop")) });
                    tiles.Add(new Tile("6", "Tile 6", "none") { ImageSource = ImageSource.FromUri(new Uri("https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/Highlight-Games-Starfield-Key-Art:VP5-1596x600")) });

                    TileViewModel model = new TileViewModel(tiles);
                    return new TileView(model, false, "Test");
                })
            });
            tabbar.Items.Add(new ShellContent
            {
                Title = "Test",
                Icon = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Microsoft_logo.svg/480px-Microsoft_logo.svg.png")),
                ContentTemplate = new DataTemplate(() =>
                {
                    ObservableCollection<Tile> tiles = new ObservableCollection<Tile>();

                    tiles.Add(new Tile("1", "Tile 1", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("2", "Tile 2", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("3", "Tile 3", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("4", "Tile 4", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("5", "Tile 5", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("6", "Tile 6", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("7", "Tile 7", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("8", "Tile 8", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("9", "Tile 9", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("10", "Tile 10", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("1", "Tile 1", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("2", "Tile 2", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("3", "Tile 3", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("4", "Tile 4", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("5", "Tile 5", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("6", "Tile 6", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("7", "Tile 7", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("8", "Tile 8", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("9", "Tile 9", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });
                    tiles.Add(new Tile("10", "Tile 10", "none") { ImageSource = ImageSource.FromUri(new Uri("https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png")) });

                    TileViewModel model = new TileViewModel(tiles);
                    return new OtherTileView(model, false, "Test");
                })
            });

        }
    }
}

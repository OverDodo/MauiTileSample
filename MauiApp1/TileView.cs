using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class TileView : ContentPage
    {
        private Grid outerGrid;
        private Grid gridLayout;
        private CollectionView collectionView;

        public TileView(TileViewModel tileViewModel, Boolean embedded, string title)
        {
            Shell.SetTitleView(this, null);
            this.Title = null;
            gridLayout = new Grid();
            gridLayout.Padding = new Thickness(10, 10, 10, 10);

            outerGrid = new Grid();
            outerGrid.RowSpacing = 0;



            if (!embedded)
            {
                NavigationPage.SetHasNavigationBar(this, false);

                Shell.SetNavBarIsVisible(this, false);
                outerGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                outerGrid.RowDefinitions.Add(new RowDefinition { });

                ContentView headerImage = new ContentView
                {
                    Padding = new Thickness(0, 5, 0, 5),
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Content = new Image
                    {
                        Source = ImageSource.FromUri(new Uri("https://news.microsoft.com/wp-content/uploads/prod/sites/40/2022/11/Screenshot-2022-03-02-102510-1-960x640-2.jpg")),
                        VerticalOptions = LayoutOptions.Center,
                        HeightRequest = 60
                    },
                };




                outerGrid.Add(headerImage, 0, 0);
                Content = outerGrid;
            }
            else
            {
                Title = title;
                outerGrid.RowDefinitions.Add(new RowDefinition { });
                Content = outerGrid;
            }

            //setMainView();
            gridLayout.ColumnSpacing = 5;
            gridLayout.RowSpacing = 5;

            collectionView = new CollectionView();

            collectionView.BindingContext = tileViewModel;
            BindingContext = tileViewModel;
            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "Tiles");
            collectionView.SetAppThemeColor(BackgroundColorProperty, Colors.White, Colors.Black);
            ContentView cw = new ContentView();
            collectionView.RemainingItemsThreshold = 4;

            cw.Padding = new Thickness(10, 10, 10, 10);
            var layout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical) { HorizontalItemSpacing = 5, VerticalItemSpacing = 5 };
            collectionView.ItemsLayout = layout;
            collectionView.ItemTemplate = new DataTemplate(() => {

                Grid grid = new Grid();
                grid.RowSpacing = 5;
                grid.AddRowDefinition(new RowDefinition { Height = GridLength.Auto });
                grid.AddRowDefinition(new RowDefinition { Height = GridLength.Auto });

                Image image = new Image();
                var width = DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
                image.SizeChanged += Image_SizeChanged;
                image.WidthRequest = width * 0.25;

                // image.WidthRequest = width * 0.25;
                image.SetBinding(Image.SourceProperty, "ImageSource", BindingMode.OneTime);

                Label text = new Label
                {
                    FontSize = 20,
                    LineBreakMode = LineBreakMode.WordWrap,
                    VerticalOptions = LayoutOptions.Start,
                    HorizontalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center
                };

                text.SetBinding(Label.TextProperty, "Text", BindingMode.OneTime);


                Border border = new Border();
                CompressedLayout.SetIsHeadless(image, true);
                CompressedLayout.SetIsHeadless(text, true);

                grid.Add(image, 0, 0);
                grid.Add(text, 0, 1);

                border.BackgroundColor = Color.FromRgba(0, 0, 0, 0);
                border.Padding = 8;
                border.StrokeThickness = 2;
                border.StrokeShape = new RoundRectangle { CornerRadius = 3 };

                var brush = new SolidColorBrush();
                brush.Color = Color.FromRgb(0, 255, 0);

                border.Stroke = brush;
                border.Content = grid;

                CompressedLayout.SetIsHeadless(border, true);

                return border;
            });

            cw.Content = collectionView;
            outerGrid.Add(cw, 0, (embedded ? 0 : 1));

            





        }

        private void Image_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString() + " has changed its size " + e.ToString());
            
        }

        private void CollectionView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine(sender.ToString() + " has changed its property");
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Focus();
        }

     

    }
}

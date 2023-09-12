using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class OtherTileView : ContentPage
    {
       
        private CollectionView collectionView;

        public OtherTileView(TileViewModel tileViewModel, Boolean embedded, string title)
        {
            Shell.SetTitleView(this, null);
            this.Title = null;


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

                var content = new ContentView { Content = border };

                CompressedLayout.SetIsHeadless(border, true);

                return content;
            });



            Content = collectionView;




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

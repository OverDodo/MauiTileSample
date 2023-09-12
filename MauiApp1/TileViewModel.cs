using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class TileViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<Tile> views = new ObservableCollection<Tile>();

        public ObservableCollection<Tile> Tiles { get => views; }

        public TileViewModel(ObservableCollection<Tile> views)
        {
            this.views = views;
        }


    }
}

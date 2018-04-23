using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Map;


namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            // Create a map control.
            MapControl map = new MapControl();

            // Create a layer.
            ImageTilesLayer layer = new ImageTilesLayer();
            map.Layers.Add(layer);

            // Create a data provider.
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            layer.DataProvider = provider;

            // Add the map control to the window.
            this.Content = map;
        }

    }
}

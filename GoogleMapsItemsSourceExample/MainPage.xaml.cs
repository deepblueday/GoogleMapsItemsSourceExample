using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMapsItemsSourceExample.Helpers;
using GoogleMapsItemsSourceExample.Models;
using Xamarin.Forms;

namespace GoogleMapsItemsSourceExample
{

    /// <summary>
    /// A very basic example of a Xamarin.Forms app using Xamarin.Forms.GoogleMaps
    /// and Xamarin.Forms.GoogleMaps.Clustering, binding the map's ItemsSource property
    /// to an ObservableCollection.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        readonly int _pinCount = 500;

        readonly ObservableCollection<LocationModel> _locations;

        public ObservableCollection<LocationModel> Locations => _locations;

        public MainPage()
        {
            BindingContext = this;

            //Initialize collection that holds the locations bound to the Map

            _locations = new ObservableCollection<LocationModel>();

            Random randomPositionGenerator = new Random();

            for (int i = 0; i < _pinCount; i++)
            {
                //Create new location
                LocationModel locationModel = new LocationModel();
                locationModel.Address = $"Address {i}";
                locationModel.Description = $"Location {i}";
                locationModel.Position = RandomPositionGenerator.Next();

                //Add Location to the collection
                _locations.Add(locationModel);
            }

            InitializeComponent();
        }
    }
}

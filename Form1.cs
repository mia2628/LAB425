using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace _0501MapSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadIntoMap_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 1; // Minumum zoom Level
            map.MaxZoom = 100; // Maximum Zoom Level
            map.Zoom = 10; // current Zoom Level

            PointLatLng point = new PointLatLng(lat, longt);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);


            // 1. create a Overlay
            GMapOverlay markers = new GMapOverlay("markers");

            // 2. Add all available markers to that Overlay
            markers.Markers.Add(marker);

            // 3. Cover map with Overlay
            map.Overlays.Add(markers);
        }

    }
}

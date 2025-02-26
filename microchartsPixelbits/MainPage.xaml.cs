using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;

namespace microchartsPixelbits
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            graficas();
        }
        private void graficas()
        {
            var datos = RandomEntrys();

            BarrasGrafica.Chart = new BarChart
            {
                Entries = datos
            };
            LineasGrafica.Chart = new LineChart
            {
                Entries = datos
            };

            PastelGrafica.Chart = new PieChart
            {
                Entries = datos
            };
            DonaGrafica.Chart = new DonutChart
            {
                Entries = datos
            };
            MangueraGrafica.Chart = new RadialGaugeChart
            {
                Entries = datos
            };
            PuntosGrafica.Chart = new PointChart
            {
                Entries = datos
            };
            MangueraradialGrafica.Chart = new HalfRadialGaugeChart
            {
                Entries = datos
            };
            RadarGrafica.Chart = new RadarChart
            {
                Entries = datos
            };
        }



        private ChartEntry[] RandomEntrys()
        {
            var datos = new List<ChartEntry>();
            for (int i = 0; i < 12;i++)
            {
                datos.Add(new ChartEntry(random.Next(-500, 500))
                {
                    Label = DateTime.Now.AddMonths(i).ToString("MMM"),
                    ValueLabel = "$" + random.Next(-500, 500).ToString(),
                    Color = SKColor.Parse(String.Format("#{0:X6}",random.Next(0x1000000))),
                });

            }
            return datos.ToArray();


        }
        private void generarGraficas(object sender, EventArgs e)
        {
            graficas();
        }



    }

}

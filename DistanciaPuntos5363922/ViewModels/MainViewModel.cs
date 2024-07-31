using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaPuntos5363922.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public double x1;

        [ObservableProperty]
        public double x2;

        [ObservableProperty]
        public double y1;

        [ObservableProperty]
        public double y2;

        [ObservableProperty]
        public string total;

        [RelayCommand]
        public void Calculo()
        {

            if (double.TryParse(X1.ToString(), out double x1) &&
               double.TryParse(Y1.ToString(), out double y1) &&
               double.TryParse(X2.ToString(), out double x2) &&
               double.TryParse(Y2.ToString(), out double y2))
            {
                double distancia = CalculateDistance(x1, y1, x2, y2);
                Total = $"Distancia: {distancia:F2}";
            }
            else
            {
                Total= "Por favor, ingrese valores válidos.";
            }
        }

        private double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
    }



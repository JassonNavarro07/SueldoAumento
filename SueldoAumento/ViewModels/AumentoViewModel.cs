using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SueldoAumento.ViewModels
{
    partial class AumentoViewModel : ObservableObject
    {

        [ObservableProperty]
        public string sueldo;
        [ObservableProperty]
        public string aumento;
        [ObservableProperty]
        public string st;


        [RelayCommand]
        private void CalcularAumento()
        {
            if(double.TryParse(Sueldo, out double sueldo) && double.TryParse(Aumento, out double aumento))
            {
               
                   
                    if (sueldo <= 1000)
                    {
                       aumento = sueldo * 0.15;
                    }
                    else
                    {
                        aumento = sueldo * 0.12;
                    }

                    double nuevoSueldo = aumento + (sueldo * aumento);
                    St = $"El nuevo sueldo es: ${nuevoSueldo:F2}";

                
               

            }
        }
    }
}

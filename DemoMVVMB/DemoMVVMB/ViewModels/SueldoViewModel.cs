using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVMB.ViewModels
{
    

    public class SueldoViewModel : ViewModelBase
    {
        int sueldo;
        public int Sueldo
        {
            get { return sueldo; }
            set
            {
                if (sueldo != value)
                {
                    sueldo = value;
                    OnPropertyChanged();
                }
            }
        }

        int gratificacion;
        public int Gratificacion
        {
            get { return gratificacion; }
            set
            {
                if (gratificacion != value)
                {
                    gratificacion = value;
                    OnPropertyChanged();
                }
            }
        }

        int sueldoNeto;
        public int SueldoNeto
        {
            get { return sueldoNeto; }
            set
            {
                if (sueldoNeto != value)
                {
                    sueldoNeto = value;
                    OnPropertyChanged();
                }
            }
        }

        int calcular2;
        public int Calcular2
        {
            get { return calcular2; }
            set
            {
                if (calcular2 != value)
                {
                    calcular2 = value;
                    OnPropertyChanged();
                }
            }
        }


        int netoFinal;
        public int NetoFinal
        {
            get { return netoFinal; }
            set
            {
                if (netoFinal != value)
                {
                    netoFinal = value;
                    OnPropertyChanged();
                }
            }
        }


        Double impuesto;
        public Double Impuesto
        {
            get { return impuesto; }
            set
            {
                if (impuesto != value)
                {
                    impuesto = value;
                    OnPropertyChanged();
                }
            }
        }

        int descuento;
        public int Descuento
        {
            get { return descuento; }
            set
            {
                if (descuento != value)
                {
                    descuento = value;
                    OnPropertyChanged();
                }
            }
        }



        public ICommand CalcularSueldoNeto { protected set; get; }

        public ICommand CalcularNetoFinal { protected set; get; }
        public ICommand CalcularImpuesto { protected set; get; }

        public SueldoViewModel()
        {
            CalcularSueldoNeto = new Command(() =>
            {
                SueldoNeto = Sueldo + Gratificacion;
            });

            CalcularNetoFinal = new Command(() =>
            {
                NetoFinal = Sueldo + Gratificacion - Descuento;
            });

            CalcularImpuesto = new Command(() =>
            {
                Impuesto = SueldoNeto * 0.08  ;
            });
        }

     
    }
}

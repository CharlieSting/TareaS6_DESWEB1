using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using CalculadoraS6.Models;

namespace CalculadoraS6.ViewModel
{
    public class ViewModelExpresion : INotifyPropertyChanged
    {

        public ViewModelExpresion(){

            Sumar = new Command(() =>
            {

                Expresion p = new Expresion()
                {
                    Num1 = this.num2,
                    Num2 = this.num2
                   
                };

                Total = p.Sumar();



            });

            Restar = new Command(() =>
            {

                Expresion p = new Expresion()
                {
                    Num1 = this.num2,
                    Num2 = this.num2,



                };

                Total = p.Restar();



            });

            Multiplicar = new Command(() =>
            {

                Expresion p = new Expresion()
                {
                    Num1 = this.num2,
                    Num2 = this.num2

                };

                Total = p.Multiplicar();



            });

            Dividir = new Command(() =>
            {

                Expresion p = new Expresion()
                {
                    Num1 = this.num2,
                    Num2 = this.num2

                };

                Total = p.Dividir();



            });
        }


            double num1;

        public double Num1
        {

            get => num1;
            set
            {

                num1 = value;
                var args = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, args);

            }

        }

        double num2;

        public double Num2
        {

            get => num2;
            set
            {

                num1 = value;
                var args = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, args);

            }

        }

        double total;
        public double Total
        {

            get => total;
            set
            {
                total = value;
                var args = new PropertyChangedEventArgs(nameof(Total));
                PropertyChanged?.Invoke(this, args);

            }

        }

        public Command Sumar { get; }
        public Command Restar { get; }
        public Command Multiplicar { get; }
        public Command Dividir { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

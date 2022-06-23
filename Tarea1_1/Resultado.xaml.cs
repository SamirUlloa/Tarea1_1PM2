﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {

        public Resultado(int result, string oper)
        {
            InitializeComponent();
            lblResultado.Text = "El Resultado de la " + oper + " es: " + result;
        }
    }
}
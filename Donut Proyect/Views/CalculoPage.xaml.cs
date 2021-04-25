using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Donut_Proyect.Models;
using Donut_Proyect.Views;
using Donut_Proyect.ViewModels;
using Donut.Models;

namespace Donut_Proyect.Views
{
    public partial class CalculoPage : ContentPage
    {
        private List<RadioButton> TiposDona = new List<RadioButton>();
        private List<RadioButton> TiposRelleno = new List<RadioButton>();
        private List<RadioButton> TiposCubierta = new List<RadioButton>();
        private List<Dona> Donas = new List<Dona>();

        private double descuento = 0;
        private int DonaTotal = 0;
        private int DonaCaracCounter = 0;
        
        Dona dona = new Dona();
        
        public CalculoPage()
        {
            InitializeComponent();
            /*AñadirTiposDona();
            AñadirTiposRelleno();
            AñadirTiposCubierta();*/
        }

        /*private void AñadirTiposDona()
        {
            TiposDona.Add(rb_d_trigo);
            TiposDona.Add(rb_d_centeno);
            TiposDona.Add(rb_d_maiz);
            TiposDona.Add(rb_d_germinado);
            TiposDona.Add(rb_d_espelta);
        }

        private void AñadirTiposRelleno()
        {
            TiposRelleno.Add(rb_r_fresa);
            TiposRelleno.Add(rb_r_chocolate);
            TiposRelleno.Add(rb_r_vainilla);
            TiposRelleno.Add(rb_r_queso);
            TiposRelleno.Add(rb_r_merenge);
        }

        private void AñadirTiposCubierta()
        {
            TiposCubierta.Add(rb_c_cereales);
            TiposCubierta.Add(rb_c_chispas);
            TiposCubierta.Add(rb_c_chocolate);
            TiposCubierta.Add(rb_c_glaseado);
            TiposCubierta.Add(rb_c_nuez);
        }

        private void AñadirOnClick(object sender, EventArgs e)
        {
            DonaCaracCounter = 0;

            foreach (RadioButton rb in TiposDona)
            {
                if (rb.IsChecked)
                {
                    DonaCaracCounter++;
                }
            }

            foreach (RadioButton rb in TiposRelleno)
            {
                if (rb.IsChecked)
                {
                    DonaCaracCounter++;
                }
            }

            foreach (RadioButton rb in TiposCubierta)
            {
                if (rb.IsChecked)
                {
                    DonaCaracCounter++;
                }
            }

            if (DonaCaracCounter == 3)
            {
                dona.Precio = CalcularPrecio();
                DesactivarRButtons();
                Total_Label.Text = "Dona = $ 0";
                Dona_Anterior.IsEnabled = true;
                Donas.Add(dona);
                DonaTotal++;
                dona = new Dona();
                CalularPrecioFinal();
            }
            Mostrar();
            
        }
        */
        private double CalcularPrecio()
        {
            double precio = 0;

            if (rb_d_trigo.IsChecked)
            {
                precio += 30;
            }
            else if (rb_d_centeno.IsChecked)
            {
                precio += 30;
            }
            else if (rb_d_maiz.IsChecked)
            {
                precio += 27;
            }
            else if (rb_d_germinado.IsChecked)
            {
                precio += 33;
            }
            else if (rb_d_espelta.IsChecked)
            {
                precio += 30;
            }

            if (rb_r_fresa.IsChecked)
            {
                precio += 15;
            }
            else if (rb_r_chocolate.IsChecked)
            {
                precio += 15;
            }
            else if (rb_r_vainilla.IsChecked)
            {
                precio += 15;
            }
            else if (rb_r_queso.IsChecked)
            {
                precio += 18;
            }
            else if (rb_r_merenge.IsChecked)
            {
                precio += 18;
            }

            if (rb_c_cereales.IsChecked)
            {
                precio += 10;
            }
            else if (rb_c_chispas.IsChecked)
            {
                precio += 7;
            }
            else if (rb_c_glaseado.IsChecked)
            {
                precio += 7;
            }
            else if (rb_c_nuez.IsChecked)
            {
                precio += 10;
            }
            else if (rb_c_chocolate.IsChecked)
            {
                precio += 7;
            }

            return precio;
        }

        private void onTiposChanged(object sender, CheckedChangedEventArgs e)
        {
            Total_Label.Text = "Dona = $ " + CalcularPrecio();
            dona.TipoDona = sender as RadioButton;
            CalularPrecioFinal();
        }

        private void onCubiertaChanged(object sender, CheckedChangedEventArgs e)
        {
            Total_Label.Text = "Dona = $ " + CalcularPrecio();
            dona.TipoCubierta = sender as RadioButton;
            CalularPrecioFinal();
        }

        private void onRellenoChanged(object sender, CheckedChangedEventArgs e)
        {
            Total_Label.Text = "Dona = $ " + CalcularPrecio(); 
            dona.TipoRelleno = sender as RadioButton;
            CalularPrecioFinal();
        }

        private void AnteriorOnClick(object sender, EventArgs e)
        {
            if (DonaTotal > 0)
            {
                DonaTotal--;

                Actualizar(DonaTotal);
            }

            if (DonaTotal == 0)
            {
                Dona_Anterior.IsEnabled = false;
                
            }

            if (Donas.Count > 1)
            {
                Dona_Siguiente.IsEnabled = true;
            }
        }

        private void SiguienteOnClick(object sender, EventArgs e)
        {
            DonaTotal++;
            if (DonaTotal < Donas.Count)
            {
                
                Actualizar(DonaTotal);
            }
            else
            {
                DonaTotal--;
            }

            if (DonaTotal == Donas.Count-1)
            {
                Dona_Siguiente.IsEnabled = false;
                Dona_Anterior.IsEnabled = true;
            }
            else
            {
                Dona_Anterior.IsEnabled = true;
            }
        }
        
        private void Actualizar(int posi)
        {
            Mostrar();

            RadioButton rb_cubierta = Donas[posi].TipoCubierta;
            rb_cubierta.IsChecked = true;

            RadioButton rb_dona = Donas[posi].TipoDona;
            rb_dona.IsChecked = true;

            RadioButton rb_relleno = Donas[posi].TipoRelleno;
            rb_relleno.IsChecked = true;
        }

        private void DesactivarRButtons()
        {
            foreach (RadioButton rb in TiposDona)
            {
                if (rb.IsChecked)
                {
                    rb.IsChecked = false;
                }
            }

            foreach (RadioButton rb in TiposRelleno)
            {
                if (rb.IsChecked)
                {
                    rb.IsChecked = false; ;
                }
            }

            foreach (RadioButton rb in TiposCubierta)
            {
                if (rb.IsChecked)
                {
                    rb.IsChecked = false;
                }
            }
        }

        private void CalularPrecioFinal()
        {
            double precioo = 0;

            foreach (Dona donaa in Donas)
            {
                precioo += donaa.Precio;
            }
            CalcularDescuento(precioo);
            Descuento_Label.Text = "Descuento = $ " + descuento;
            Total_Final_Label.Text = "Total = $ " + (precioo - descuento);
        }

        private void Limpiarr(object sender, EventArgs e)
        {
            DesactivarRButtons();
            Donas.Clear();
            Dona_Anterior.IsEnabled = false;
            Dona_Siguiente.IsEnabled = false;
            Descuento_Label.Text = "Descuento = $ 0";
            Total_Final_Label.Text = "Total = $ 0";
            descuento = 0;
            DonaTotal = 0;
        }

        private void Mostrar()
        {
            Shower.Text = Donas.Count + " " + DonaTotal;
        }

        private void CalcularDescuento(double precio)
        {
            if (precio > 120)
            {
                descuento = precio * 0.30;
            }
            else if (precio > 270)
            {
                descuento = precio * 0.40;
            }
        }
    }
}
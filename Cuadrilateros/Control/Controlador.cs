using Cuadrilateros.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrilateros.Control
{
    class Controlador
    {

        Cuadrado cuadrado = new Cuadrado();
        Interfaz inter;
        Rectangulo rectangulo = new Rectangulo();
        Trapecio trapecio = new Trapecio();

        public Controlador(Interfaz interfaz)
        {
            inter = interfaz;

          

            inter.lbLadoDelCuadrado.Visible = false;
            inter.txtLadoUsuario.Visible = false;
            inter.btnCalcularAreaPerimetro.Visible = false;
            inter.pictureBox1.Visible = false;
            inter.panel1.Visible = false;
            inter.panel2.Visible = false;
            inter.btnRegresar.Visible = false;



            inter.panelRetangulo1.Visible = false;
            inter.panelRectangulo2.Visible = false;
            inter.panelRectangulo3.Visible = false;
            inter.picRectangulo.Visible = false;



            inter.panelTrapecio1.Visible = false;
            inter.pictureBox6.Visible = false;
            inter.panelTrapecio3.Visible = false;
            inter.panelTrapecio2.Visible = false;

            inter.btnLimpiar.Visible = false;



            inter.btnCuadrado.Click += new System.EventHandler(this.Click);
            inter.btnCalcularAreaPerimetro.Click += new System.EventHandler(this.CalcularAreaYPerimetro);

            inter.btnRectangulo.Click += new System.EventHandler(this.btnRecta);
            inter.btnCalcularRectángulo.Click += new System.EventHandler(this.btnCalcuarR);

            inter.btnTrapecio.Click += new System.EventHandler(this.btnTrapecio);
            inter.btnCalcularTrapecio.Click += new System.EventHandler(this.btnCalcularTrapecio);

            inter.btnRegresar.Click += new System.EventHandler(this.btnRegresar);

            inter.txtAreaCuadrado.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtH.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtLadoARectangulo.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtLadob.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtLadoB2.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtLadoBRectangulo.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtLadoD.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtLadoUsuario.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtResulAreaR.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtResulPerimetroR.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtResultadoPerimetro.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtResultadoTrapecio.KeyPress += new KeyPressEventHandler(numeros);
            inter.txtTrapecioResul2.KeyPress += new KeyPressEventHandler(numeros);

            inter.txtLadoUsuario.KeyPress += new KeyPressEventHandler(PasarCuadrado);
            inter.txtLadoARectangulo.KeyPress += new KeyPressEventHandler(PasarRectangulo);
            inter.txtLadoBRectangulo.KeyPress += new KeyPressEventHandler(PasarRectanguloDos);

            inter.txtLadob.KeyPress += new KeyPressEventHandler(PasarTrapecioUno);
            inter.txtLadoB2.KeyPress += new KeyPressEventHandler(PasarTrapecioDos);
            inter.txtLadoD.KeyPress += new KeyPressEventHandler(PasarTrapecioTres);
            inter.txtH.KeyPress += new KeyPressEventHandler(PasarTrapecioCuatro);

            inter.btnLimpiar.Click += new System.EventHandler(limpiar);


        }


        private void Click(object sender, EventArgs e)
        {
            inter.btnRegresar.Visible = true;
            inter.btnRectangulo.Visible = false;
            inter.btnTrapecio.Visible = false;

            inter.lbLadoDelCuadrado.Visible = true;
            inter.txtLadoUsuario.Visible = true;
            inter.btnCalcularAreaPerimetro.Visible = true;
            inter.pictureBox1.Visible = true;



        }


        private void limpiar(object sender, EventArgs e)
        {
            inter.txtLadoUsuario.Text = null;
            inter.txtLadoARectangulo.Text = null;
            inter.txtLadoBRectangulo.Text = null;
           inter.txtLadob.Text = null;
           inter.txtLadoB2.Text = null;
           inter.txtLadoD.Text = null ;
           inter.txtH.Text = null;

        }
        private void PasarCuadrado(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inter.btnCalcularAreaPerimetro.Focus();
            }


        }

        private void PasarRectangulo(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inter.txtLadoBRectangulo.Focus();
            }


        }

        private void PasarRectanguloDos(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inter.btnCalcularRectángulo.Focus();
            }


        }

        private void PasarTrapecioUno(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inter.txtLadoB2.Focus();
            }


        }

        private void PasarTrapecioDos(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inter.txtLadoD.Focus();
            }


        }

        private void PasarTrapecioTres(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inter.txtH.Focus();
            }


        }

        private void PasarTrapecioCuatro(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                inter.btnCalcularTrapecio.Focus();
            }


        }


        private void numeros (object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == 46) && !((TextBox)sender).Text.Contains("."))
            {

                e.Handled = false;


            }
            else
            {
                e.Handled = true;
            }



        }

        private void btnRegresar(object sender, EventArgs e)
        {

            inter.btnCuadrado.Visible = true;
            inter.btnRectangulo.Visible = true;
            inter.btnTrapecio.Visible = true;

            inter.lbLadoDelCuadrado.Visible = false;
            inter.txtLadoUsuario.Visible = false;
            inter.btnCalcularAreaPerimetro.Visible = false;
            inter.pictureBox1.Visible = false;

            inter.panel1.Visible = false;
            inter.panel2.Visible = false;

            inter.panelRetangulo1.Visible = false;
            inter.panelRectangulo2.Visible = false;
            inter.panelRectangulo3.Visible = false;
            inter.picRectangulo.Visible = false;


            inter.panelTrapecio1.Visible = false;
            inter.panelTrapecio2.Visible = false;
            inter.panelTrapecio3.Visible = false;
            inter.pictureBox6.Visible = false;

            inter.btnLimpiar.Visible = false;

        }

        private void CalcularAreaYPerimetro(object sender, EventArgs e)
        {

            if (inter.txtLadoUsuario.Text.Equals(""))
            {
                MessageBox.Show("Escribe un número", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                inter.btnLimpiar.Visible = true;

                inter.panel1.Visible = true;
            inter.panel2.Visible = true;

            cuadrado.longuitud = Convert.ToDouble(inter.txtLadoUsuario.Text);

            cuadrado.perimetroCudrado();

            inter.txtResultadoPerimetro.Text = cuadrado.perimetro + "";

            cuadrado.areaCuadrado();
            inter.txtAreaCuadrado.Text = cuadrado.area + "";


            }
        }

        private void btnRecta(object sender, EventArgs e)
        {

            inter.panelRetangulo1.Visible = true;

            inter.picRectangulo.Visible = true;

            inter.btnRegresar.Visible = true;
            inter.btnTrapecio.Visible = false;
            inter.btnCuadrado.Visible = false;

            inter.lbLadoDelCuadrado.Visible = false;
            inter.txtLadoUsuario.Visible = false;
            inter.btnCalcularAreaPerimetro.Visible = false;
            inter.pictureBox1.Visible = false;

            inter.panel1.Visible = false;
            inter.panel2.Visible = false;

        }

        private void btnCalcuarR(object sender, EventArgs e)
        {
            if (inter.txtLadoARectangulo.Text.Equals("") || inter.txtLadoBRectangulo.Text.Equals(""))
            {
                MessageBox.Show("Escribe un número", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                inter.btnLimpiar.Visible = true;

                inter.panelRectangulo2.Visible = true;
            inter.panelRectangulo3.Visible = true;

            rectangulo.A = Convert.ToDouble(inter.txtLadoARectangulo.Text);
            rectangulo.B = Convert.ToDouble(inter.txtLadoBRectangulo.Text);

            rectangulo.PerimetroRectangulo();

            inter.txtResulPerimetroR.Text = rectangulo.perimetroRectangulo + "";

            rectangulo.AreaRectangulo();

            inter.txtResulAreaR.Text = rectangulo.areaRectangulo + "";

            }
        }


        private void btnTrapecio(object sender, EventArgs e)
        {

          
            inter.btnRegresar.Visible = true;

            inter.btnCuadrado.Visible = false;
            inter.btnRectangulo.Visible = false;

            inter.lbLadoDelCuadrado.Visible = false;
            inter.txtLadoUsuario.Visible = false;
            inter.btnCalcularAreaPerimetro.Visible = false;
            inter.pictureBox1.Visible = false;

            inter.panel1.Visible = false;
            inter.panel2.Visible = false;

            inter.panelRetangulo1.Visible = false;
            inter.panelRectangulo2.Visible = false;
            inter.panelRectangulo3.Visible = false;
            inter.picRectangulo.Visible = false;

            inter.panelTrapecio1.Visible = true;
            inter.pictureBox6.Visible = true;

        }

        private void btnCalcularTrapecio(object sender, EventArgs e)
        {

            if (inter.txtH.Text.Equals("") || inter.txtLadob.Equals("") || inter.txtLadoB2.Equals("") || inter.txtLadoD.Equals(""))
            {
                MessageBox.Show("Escribe un número", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inter.btnLimpiar.Visible = true;

                inter.panelTrapecio2.Visible = true;
            inter.panelTrapecio3.Visible = true;

           trapecio.b = Convert.ToDouble(inter.txtLadob.Text);
           trapecio.B = Convert.ToDouble(inter.txtLadoB2.Text);
            trapecio.d = Convert.ToDouble(inter.txtLadoD.Text);
            trapecio.H = Convert.ToDouble(inter.txtH.Text);

            trapecio.PerimetroTrapecio();

            inter.txtResultadoTrapecio.Text = trapecio.perimetroTra + "";

            trapecio.AreaTrapecio();

            inter.txtTrapecioResul2.Text = trapecio.areaTra + "";

            }

        }

    }
}

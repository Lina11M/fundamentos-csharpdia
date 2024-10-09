using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projecto2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Invocar
            mostrarMensaje();
        }
        //Metodo para mostrar el mensaje por el navegador 
        public void mostrarMensaje()
        {
            //Se crea un objeto de tipo car
            Car car = new Car();
            string msj = car.stop();
            LblMensaje.Text = msj;
        }
    }
}
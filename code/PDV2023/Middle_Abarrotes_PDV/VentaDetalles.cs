using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Middle_Abarrotes_PDV
{
    public class VentaDetalles
    {
        public int venta_id = 0;
        public int producto_id = 0;
        public int cantidad = 0;
        CRUDs_BD bd;
        public VentaDetalles()
        {
            CRUDs_BD bd;
            //crear una instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "productos_pdv", "3306");

        }
        public List<VentaDetalles> consultarGeneral(string where)
        {
            List<VentaDetalles> detallesventa = new List<VentaDetalles>();
            VentaDetalles detallesventas = new VentaDetalles();

            List<object[]> res = this.bd.consulta("ventas_detalles", where);
            //validamos que traig un elemento la lista
            if (res.Count >= 1)
            {


                for (int i = 0; i < res.Count; i++)
                {
                    detallesventas = new VentaDetalles();

                    object[] tempo = res[0];
                    detallesventas.venta_id = int.Parse(tempo[0].ToString());
                    detallesventas.producto_id = int.Parse(tempo[1].ToString());
                    detallesventas.cantidad = int.Parse(tempo[2].ToString());


                }

                detallesventa.Add(detallesventas);

            }
            else
            {
                Usuarios.msgError = "no se encontraron resultados. " + this.bd.msgError;
                detallesventas= null;
            }

            return detallesventa;
        }


    }
}

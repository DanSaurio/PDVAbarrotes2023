using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Abarrotes_PDV
{
    public class Usuarios
    {
        //propiedades de la clase
        public string nombre;
        public string password;
        public string correo;
        public string imagen;
        public int id;

        CRUDs_BD bd;
        
        public static string msgError;
        public Usuarios()
        {
            //crear una instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "productos_pdv", "3306");
        }
        public bool crear( string nomb, string correo, string password,string imagen)
        {
            List<string> nombresCampos = new List<string>()
            {
                   "nombre","correo", "password","imagen"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar( nomb  ));
            vals.Add(new ValoresAInsertar(correo));
            vals.Add(new ValoresAInsertar( password ));
            vals.Add(new ValoresAInsertar(imagen ));

            bool resultado = this.bd.insertar("usuarios", nombresCampos, vals);
            //valir el res
            if (resultado == false)
                Usuarios.msgError = this.bd.msgError;

            return resultado;
        }
            //crear

            //borrar
        public bool borrarusuario(int id)
            {
                bool res = this.bd.borrarusuario("usuarios", id);
                if (res = false)
                    Usuarios.msgError = this.bd.msgError;
                return res;


            }

        public bool modificar(string nom , string correo, string password, string imagen,int id)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "correo", "password", "imagen"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(correo));
            vals.Add(new ValoresAInsertar(password));
            vals.Add(new ValoresAInsertar(imagen));
            vals.Add(new ValoresAInsertar(id.ToString()));

            bool resultado = this.bd.modificar("usuarios", nombresCampos, vals, id);
            //valir el res
            if (resultado == false)
                Usuarios.msgError = this.bd.msgError;

            return resultado;
        }


        //consultar
        public List<object[]> consultarTodos()
            {
                return this.bd.consulta("usuarios");
            }
           

            //consultar Precio por ID de producto
            /// <summary>
            /// 
            /// </summary>
            /// <param name="id"></param>
            /// <returns>El precio del producto con id consultado, o -1 para indicar un error.</returns>



            public List<Usuarios> consultarGeneral(string where)
            {
                List<Usuarios> listaDeUsuarios = new List<Usuarios>();
                Usuarios usuarioResultado = new Usuarios();

                List<object[]> res = this.bd.consulta("usuarios", where);
                //validamos que traig un elemento la lista
                if (res.Count >= 1)
                {


                    for (int i = 0; i < res.Count; i++)
                    {
                        usuarioResultado = new Usuarios();
                      
                        object[] tempo = res[0];
                        usuarioResultado.id = int.Parse(tempo[0].ToString());
                        usuarioResultado.nombre = tempo[1].ToString();
                        usuarioResultado.correo = tempo[2].ToString();
                        usuarioResultado.password = tempo[3].ToString();
                        usuarioResultado.imagen = tempo[4].ToString();



                    //switch (tempo[7].ToString())
                    //{
                    //    case "CAJA":
                    //        presentacionTexto = Presentacion.CAJA;
                    //        break;
                    //    case "KILO":
                    //        presentacionTexto = Presentacion.KILO;
                    //        break;
                    //    case "LITRO":
                    //        presentacionTexto = Presentacion.LITRO;
                    //        break;
                    //    case "PIEZA":
                    //        presentacionTexto = Presentacion.PIEZA;
                    //        break;
                    //    default:
                    //        presentacionTexto = Presentacion.KILO;
                    //        break;

                    //}
                    //prodResultado.unidad = presentacionTexto;
                }

                    listaDeUsuarios.Add(usuarioResultado);

                }
                else
                {
                    Usuarios.msgError = "no se encontraron resultados. " + this.bd.msgError;
                    usuarioResultado = null;
                }

                return listaDeUsuarios;
            }
        }
        

    }


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Xamarin.Forms;
using Pedidos.ViewModels;

namespace Pedidos.Models
{
    public static class Variables_Globales
    {
        //public byte[] Imagen { get; set; }
        public static byte[] Imagen_Articulo { get; set; }
        public static int Id_Sucursal_Ingreso_Sistema_Public { get; set; }
        public static int Id_Lista_Precio { get; set; }
        public static int Precio_Venta_Base { get; set; }
        public static int Precio_Venta_de_Anexo_Articulo_x_Lista_Precio { get; set; }
        public static int Monto_despues_de_Porcentaje_Base_del_Articulo { get; set; }
        public static Double Porcentaje_Base_del_Articulo_Public { get; set; }
        public static int Monto_del_Articulo_Public { get; set; }
        public static int Autorizado { get; set; }
        public static int Id_Articulo { get; set; }
        public static int Existe_para_Inventariar { get; set; }
        public static int Existe { get; set; }
        public static int Id_Bodega { get; set; }
        public static int Id_Detalle_Inventario { get; set; }
        public static int Rut_Empresa { get; set; }
        public static int Id_Mesa_Reservada { get; set; }
        public static int Id_Mesa_Anterior { get; set; }
        public static int Id_Vendedor { get; set; }
        public static int Id_Mesa_Destino { get; set; }
        public static int Id_Mesa_a_Dividir { get; set; }
        public static string Nombre_Mesa { get; set; }
        public static string Nombre_Categoria { get; set; }
        public static string Nombre_Articulo { get; set; }
        public static int Total_Cuenta { get; set; }
        public static int Total_Cuenta_Copia { get; set; }
        public static int Total_Cuenta_Nueva { get; set; }
        public static int Estado_Mesa { get; set; }
        public static int Cantidad_Consumos { get; set; }
        public static string Usuario { get; set; }
        public static string Password { get; set; }
        public static string Nombre_Usuario { get; set; }
        public static string Password_Desencriptada { get; set; }
        public static int Existen_Detalles_Nota_Venta { get; set; }
        public static int Grabo_Nota_Venta { get; set; }
        public static string Mesa_Origen { get; set; }
        public static string Mesa_Destino { get; set; }
        public static string Titulo { get; set; }
        public static string Color { get; set; }

        // Ventas
        public static int Precio_Venta { get; set; }
        public static int Stock { get; set; }
        public static int Id_Mesa { get; set; }
        public static string Categoria { get; set; }
        public static string Nombre { get; set; }
        public static string Mensaje { get; set; }
        public static int Cantidad { get; set; }
        public static int Total { get; set; }
        public static int Descuento { get; set; }
        public static string Codigo { get; set; }
        public static int Id_Venta { get; set; }
        public static int Id_Detalle_Venta { get; set; }
        // Tabla_Cliente
        public static int Id_Cliente { get; set; }
        public static string Rut_Cliente { get; set; }
        public static string Nombre_Cliente { get; set; }
        public static string Giro_Cliente { get; set; }
        public static string Direccion_Cliente { get; set; }
        public static string Ciudad_Cliente { get; set; }
        public static string Ciudad_Cliente_Nueva { get; set; }
        public static int Id_Ciudad_Cliente { get; set; }
        public static int Id_Ciudad_Cliente_Nueva { get; set; }
        public static string Comuna_Cliente { get; set; }
        public static string Comuna_Cliente_Nueva { get; set; }
        public static int Id_Comuna_Cliente { get; set; }
        public static int Id_Comuna_Cliente_Nueva { get; set; }
        public static string Comuna_Ciudad_Cliente { get; set; }
        public static string Telefono_Fijo_Cliente { get; set; }
        public static string Telefono_Celular_Cliente { get; set; }
        public static string EMail_Cliente { get; set; }
        public static string Estado_Descripcion_Cliente { get; set; }
        public static string Apodo_Cliente { get; set; }
        public static int Estado_Cliente { get; set; }
        public static string Fecha_Constitucion_Cliente { get; set; }
        public static string Rut_Representante_Legal_Cliente { get; set; }
        public static string Dv_Representante_Legal_Cliente { get; set; }
        public static string Nombre_Representante_Legal_Cliente { get; set; }
        public static int Id_Forma_Pago_Cliente { get; set; }
        public static string Descripcion_Forma_Pago_Cliente { get; set; }
        public static string Descripcion_Lista_Precio_Cliente { get; set; }
        public static string Linea_Credito_Cliente { get; set; }
        // Anexo_Empresa
        public static int Id_Empresa { get; set; }
        public static int Costo_Envio { get; set; }
        public static bool Pago_On_Line { get; set; }
        public static bool Pago_Red_Compra { get; set; }
        public static double Evaluacion { get; set; }
        public static bool Acumula_Puntos_Clientes { get; set; }
        public static int Consumo_Minimo { get; set; }
        public static bool Lunes { get; set; }
        public static bool Martes { get; set; }
        public static bool Miercoles { get; set; }
        public static bool Jueves { get; set; }
        public static bool Viernes { get; set; }
        public static bool Sabado { get; set; }
        public static bool Domingo { get; set; }
        public static int Hora_Apertura_Lunes_Viernes_HH { get; set; }
        public static int Hora_Apertura_Lunes_Viernes_MM { get; set; }
        public static int Hora_Cierre_Lunes_Viernes_HH { get; set; }
        public static int Hora_Cierre_Lunes_Viernes_MM { get; set; }
        public static int Hora_Apertura_Sabado_HH { get; set; }
        public static int Hora_Apertura_Sabado_MM { get; set; }
        public static int Hora_Cierre_Sabado_HH { get; set; }
        public static int Hora_Cierre_Sabado_MM { get; set; }
        public static int Hora_Apertura_Domingo_HH { get; set; }
        public static int Hora_Apertura_Domingo_MM { get; set; }
        public static int Hora_Cierre_Domingo_HH { get; set; }
        public static int Hora_Cierre_Domingo_MM { get; set; }

        //Categorias
        public static string Categroia_1 { get; set; }
        public static string Categroia { get; set; }
        public static int Id_Comanda { get; set; }
        public static int Id_Garzon { get; set; }
        public static int ToTal_Venta_Articulo { get; set; }
        public static int Correlativo_Delivery { get; set; }
        public static List<Categorias_APP> Lista_Catgeorias { get; set; }
        public static List<Articulos> Lista_Articulos { get; set; }
        public static List<Articulos> Lista_Articulos_Recomendados { get; set; }
        public static int Id_Detalle_Comanda { get; set; }
        public static string Observacion { get; set; }
        public static int Id_Forma_Pago{ get; set; }
        public static string Descripcion_Forma_pago { get; set; }
        public static int Monto_Cancela { get; set; } 
        public static int Id_Direcciones_Cliente { get; set; }
        public static string Mensaje_Agregados { get; set; }
        public static int Cantidad_Agregados { get; set; }
        public static bool Tiene_Agregados { get; set; }
        public static string Articulos_Agregados { get; set; }
        public static string Cantidad_a_Mensaje { get; set; }
        public static bool Tiene_Agregados_y_Selecciono { get; set; }
        public static int Cantidad_Agregados_seleccionados { get; set; }
        public static string Mensaje_Suma { get; set; }
        public static bool Realizo_Venta { get; set; }
        public static int N_Solicitud { get; set; }
        public static int Id_Cantidad_Agregados { get; set; }

        public static int N_Solicitud_1 { get; set; }
        public static int Id_Cantidad_Agregados_1 { get; set; }
        public static int N_Solicitud_2 { get; set; }
        public static int Id_Cantidad_Agregados_2 { get; set; }
        public static int N_Solicitud_3 { get; set; }
        public static int Id_Cantidad_Agregados_3 { get; set; }
        public static int N_Solicitud_4 { get; set; }
        public static int Id_Cantidad_Agregados_4 { get; set; }
        public static int N_Solicitud_5 { get; set; }
        public static int Id_Cantidad_Agregados_5 { get; set; }
        public static int N_Solicitud_6 { get; set; }
        public static int Id_Cantidad_Agregados_6 { get; set; }
        public static int N_Solicitud_7 { get; set; }
        public static int Id_Cantidad_Agregados_7 { get; set; }
        public static int N_Solicitud_8 { get; set; }
        public static int Id_Cantidad_Agregados_8 { get; set; }
        public static int N_Solicitud_9 { get; set; }
        public static int Id_Cantidad_Agregados_9 { get; set; }
        public static int N_Solicitud_10 { get; set; }
        public static int Id_Cantidad_Agregados_10 { get; set; }

    }
    public static class BaseDatos
    {
        #region Cliente
        public static async void Trae_Datos_Cliente(string Email)
        {
            
            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Datos_Cliente", cnx);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                        Variables_Globales.Nombre_Cliente = Convert.ToString(dr["Nombre"]);
                        Variables_Globales.Apodo_Cliente = Convert.ToString(dr["Apodo"]);
                        Variables_Globales.Direccion_Cliente = Convert.ToString(dr["Direccion"]);
                        Variables_Globales.Comuna_Cliente = Convert.ToString(dr["Comuna"]);
                        Variables_Globales.Ciudad_Cliente = Convert.ToString(dr["Ciudad"]);
                        Variables_Globales.Telefono_Celular_Cliente = Convert.ToString(dr["Telefono_Celular"]);
                        Variables_Globales.EMail_Cliente = Convert.ToString(dr["Email"]);
                        Variables_Globales.Password = Convert.ToString(dr["Password"]);
                        Variables_Globales.Estado_Cliente = Convert.ToInt32(dr["Estado_Cliente"]);
                      
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Datos_Empleado",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        #endregion

        #region Empleados
        public static async void Obtener_Datos_Anexo_Empresa(int Id_Empresa)
        {
            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Obtener_Datos_Anexo_Empresa", cnx);
                cmd.Parameters.Add("@Id_Empresa", SqlDbType.NVarChar).Value = Id_Empresa;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Costo_Envio = Convert.ToInt32(dr["Costo_Envio"]);
                        Variables_Globales.Pago_On_Line = Convert.ToBoolean(dr["Pago_On_Line"]);
                        Variables_Globales.Pago_Red_Compra = Convert.ToBoolean(dr["Pago_Red_Compra"]);
                        Variables_Globales.Evaluacion = Convert.ToDouble(dr["Evaluacion"]);
                        Variables_Globales.Acumula_Puntos_Clientes = Convert.ToBoolean(dr["Acumula_Puntos_Clientes"]);
                        Variables_Globales.Consumo_Minimo = Convert.ToInt32(dr["Consumo_Minimo"]);
                        Variables_Globales.Lunes = Convert.ToBoolean(dr["Lunes"]);
                        Variables_Globales.Martes = Convert.ToBoolean(dr["Martes"]);
                        Variables_Globales.Miercoles = Convert.ToBoolean(dr["Miercoles"]);
                        Variables_Globales.Jueves = Convert.ToBoolean(dr["Jueves"]);
                        Variables_Globales.Viernes = Convert.ToBoolean(dr["Viernes"]);
                        Variables_Globales.Sabado = Convert.ToBoolean(dr["Sabado"]);
                        Variables_Globales.Domingo = Convert.ToBoolean(dr["Domingo"]);
                        Variables_Globales.Hora_Apertura_Lunes_Viernes_HH = Convert.ToInt32(dr["Hora_Apertura_Lunes_Viernes_HH"]);
                        Variables_Globales.Hora_Apertura_Lunes_Viernes_MM = Convert.ToInt32(dr["Hora_Apertura_Lunes_Viernes_MM"]);
                        Variables_Globales.Hora_Cierre_Lunes_Viernes_HH = Convert.ToInt32(dr["Hora_Cierre_Lunes_Viernes_HH"]);
                        Variables_Globales.Hora_Cierre_Lunes_Viernes_MM = Convert.ToInt32(dr["Hora_Cierre_Lunes_Viernes_MM"]);
                        Variables_Globales.Hora_Apertura_Sabado_HH = Convert.ToInt32(dr["Hora_Apertura_Sabado_HH"]);
                        Variables_Globales.Hora_Apertura_Sabado_MM = Convert.ToInt32(dr["Hora_Apertura_Sabado_MM"]);
                        Variables_Globales.Hora_Cierre_Sabado_HH = Convert.ToInt32(dr["Hora_Cierre_Sabado_HH"]);
                        Variables_Globales.Hora_Cierre_Sabado_MM = Convert.ToInt32(dr["Hora_Cierre_Sabado_MM"]);
                        Variables_Globales.Hora_Apertura_Domingo_HH = Convert.ToInt32(dr["Hora_Apertura_Domingo_HH"]);
                        Variables_Globales.Hora_Apertura_Domingo_MM = Convert.ToInt32(dr["Hora_Apertura_Domingo_MM"]);
                        Variables_Globales.Hora_Cierre_Domingo_HH = Convert.ToInt32(dr["Hora_Cierre_Domingo_HH"]);
                        Variables_Globales.Hora_Cierre_Domingo_MM = Convert.ToInt32(dr["Hora_Cierre_Domingo_MM"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Datos_Empleado",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Obtener_Datos_Empleado(string Usuario)
        {
            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Datos_Empleado", cnx);
                cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = Usuario;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Usuario = Convert.ToString(dr["Usuario"]);
                        Variables_Globales.Estado_Cliente = Convert.ToInt32(dr["Estado"]);
                        Variables_Globales.Password = Convert.ToString(dr["Password"]);
                        Variables_Globales.Nombre_Usuario = Convert.ToString(dr["Nombre"]);
                        break;
                    }
                }
                if (Usuario == "APP")
                {
                    Variables_Globales.Id_Garzon = Convert.ToInt32(dr["Id_Empleado"]);
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Datos_Empleado",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Modificar_Password_Empleado(string Usuario, string Password)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Modificar_Password_Empleado", cnx);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Modificar_Password_Empleado",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        #endregion

        #region Varios  -----------> Procedimiento Almacenado
        public static async void Trae_Descripcion_Forma_Pago(int Id_Forma_Pago_App)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Descripcion_Forma_Pago", cnx);
                cmd.Parameters.Add("@Id_Forma_Pago_App", SqlDbType.Int).Value = Id_Forma_Pago_App;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Descripcion_Forma_pago = Convert.ToString(dr["Descripcion"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Descripcion_Forma_Pago",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void AgregarComanda(string Cliente, int Id_Mesa)
        {
            var Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("AgregarComanda", cnx);
                cmd.Parameters.Add("@Id_Mesa", SqlDbType.Int).Value = Id_Mesa;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Fecha;
                cmd.Parameters.Add("@Id_Garzon", SqlDbType.Int).Value = Variables_Globales.Id_Garzon;
                cmd.Parameters.Add("@Cliente", SqlDbType.NVarChar).Value = Cliente;
                cmd.Parameters.Add("@Cantidad_Comenzales", SqlDbType.NVarChar).Value = 1;
                cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = 600;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "AgregarComanda",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Crear_Envio_APP(int Id_Comanda, int Tipo_Envio, int Forma_Pago, string Informacion_Adicional)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Crear_Envio_APP", cnx);
                cmd.Parameters.Add("@Id_Comanda", SqlDbType.Int).Value = Id_Comanda;
                cmd.Parameters.Add("@Tipo_Envio", SqlDbType.Int).Value = Tipo_Envio;
                cmd.Parameters.Add("@Forma_Pago", SqlDbType.Int).Value = Forma_Pago;
                cmd.Parameters.Add("@Informacion_Adicional", SqlDbType.NVarChar).Value = Informacion_Adicional;
                cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = 1;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Crear_Envio_APP",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Agregar_Rutas_Despacho(int Id_Comanda, string Direccion_Original_Despacho, 
                                                        string Direccion_Alternativa_Despacho, int Monto_a_Cancelar, int Vuelto)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Agregar_Rutas_Despacho", cnx);
                cmd.Parameters.Add("@Id_Comanda", SqlDbType.Int).Value = Id_Comanda;
                cmd.Parameters.Add("@Direccion_Original_Despacho", SqlDbType.NVarChar).Value = Direccion_Original_Despacho;
                cmd.Parameters.Add("@Direccion_Alternativa_Despacho", SqlDbType.NVarChar).Value = Direccion_Alternativa_Despacho;
                cmd.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@Monto_a_Cancelar", SqlDbType.Int).Value = Monto_a_Cancelar;
                cmd.Parameters.Add("@Vuelto", SqlDbType.Int).Value = Vuelto;
                cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = 0;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Agregar_Rutas_Despacho",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Agregar_Direccion_Cliente(int Id_Cliente, string Apodo, string Direccion, int Id_Ciudad, 
                                                           int Id_Comuna, string Referencia, string Telefono_Celular)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Agregar_Direccion_Cliente", cnx);
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.Int).Value = Id_Cliente;
                cmd.Parameters.Add("@Apodo", SqlDbType.NVarChar).Value = Apodo;
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = Direccion;
                cmd.Parameters.Add("@Id_Ciudad", SqlDbType.Int).Value = Id_Ciudad;
                cmd.Parameters.Add("@Id_Comuna", SqlDbType.Int).Value = Id_Comuna;
                cmd.Parameters.Add("@Referencia", SqlDbType.NVarChar).Value = Referencia;
                cmd.Parameters.Add("@Telefono_Celular", SqlDbType.NVarChar).Value = Telefono_Celular;
                cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = 1;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Agregar_Direccion_Cliente",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Modificar_Estado_Comanda(int Id_Comanda, int Estado)
        {
            var Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Modificar_Estado_Comanda", cnx);
                cmd.Parameters.Add("@Id_Comanda", SqlDbType.Int).Value = Id_Comanda;
                cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = Estado;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Fecha;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Modificar_Estado_Comanda",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Agregar_DetalleComanda(string Codigo, int Descuento, int Total, string Observacion, int Id_Comanda, int Cantidad)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Agregar_DetalleComanda", cnx);
                cmd.Parameters.Add("@Id_Comanda", SqlDbType.Int).Value = Id_Comanda;
                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 50).Value = Codigo;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
                cmd.Parameters.Add("@Descuento", SqlDbType.Int).Value = Descuento;
                cmd.Parameters.Add("@Total", SqlDbType.Int).Value = Total;
                cmd.Parameters.Add("@Observación", SqlDbType.VarChar, 100).Value = Observacion;
                cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = "514";
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Agregar_DetalleComanda",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Obtener_Id_Comanda(int Id_Garzon, int Id_Mesa)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Obtener_Id_Comanda_APP", cnx);
                cmd.Parameters.Add("@Id_Garzon", SqlDbType.Int).Value = Id_Garzon;
                cmd.Parameters.Add("@Id_Mesa", SqlDbType.Int).Value = Id_Mesa;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Id_Comanda = Convert.ToInt32(dr["Id_Comanda"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Obtener_Id_Comanda",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static List<Categorias> Obtener_todas_las_Categorias()
        {
            List<Categorias> lista = new List<Categorias>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Obtener_todas_las_Categorias", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Categorias>();
                while (dr.Read())
                {
                    Categorias categorias = new Categorias()
                    {

                        ID = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Descripcion = dr.GetString(2),
                        Correlativo = dr.GetInt32(3),
                    };
                    
                    lista.Add(categorias);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }
        public static async void Trae_Primera_Direccion_Cliente(int Id_Cliente)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Primera_Direccion_Cliente", cnx);
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.NVarChar).Value = Id_Cliente;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Apodo_Cliente = Convert.ToString(dr["Apodo"]);
                        Variables_Globales.Direccion_Cliente = Convert.ToString(dr["Direccion"]);
                        Variables_Globales.Comuna_Cliente = Convert.ToString(dr["Comuna"]);
                        Variables_Globales.Ciudad_Cliente = Convert.ToString(dr["Ciudad"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Datos_Empleado",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_de_Cantidad_Agregados_Id_Cantidad_Agregados_y_N_Solicitud(int Id_Articulo)
        {

            SqlCommand cmd = null;
            try
            {
                int Cant = 1;
                Variables_Globales.N_Solicitud_1 = 0;
                Variables_Globales.Id_Cantidad_Agregados_1 = 0;
                Variables_Globales.N_Solicitud_2 = 0;
                Variables_Globales.Id_Cantidad_Agregados_2 = 0;
                Variables_Globales.N_Solicitud_3 = 0;
                Variables_Globales.Id_Cantidad_Agregados_3 = 0;
                Variables_Globales.N_Solicitud_4 = 0;
                Variables_Globales.Id_Cantidad_Agregados_4 = 0;
                Variables_Globales.N_Solicitud_5 = 0;
                Variables_Globales.Id_Cantidad_Agregados_5 = 0;
                Variables_Globales.N_Solicitud_6 = 0;
                Variables_Globales.Id_Cantidad_Agregados_6 = 0;
                Variables_Globales.N_Solicitud_7 = 0;
                Variables_Globales.Id_Cantidad_Agregados_7 = 0;
                Variables_Globales.N_Solicitud_8 = 0;
                Variables_Globales.Id_Cantidad_Agregados_8 = 0;
                Variables_Globales.N_Solicitud_9 = 0;
                Variables_Globales.Id_Cantidad_Agregados_9 = 0;
                Variables_Globales.N_Solicitud_10 = 0;
                Variables_Globales.Id_Cantidad_Agregados_10 = 0;
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_de_Cantidad_Agregados_Id_Cantidad_Agregados_y_N_Solicitud", cnx);
                cmd.Parameters.Add("@Id_Articulo", SqlDbType.Int).Value = Id_Articulo;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        if (Cant ==1)
                        {
                            Cant = Cant + 1;
                            Variables_Globales.N_Solicitud_1 = Convert.ToInt32(dr["N_Solicitud"]);
                            Variables_Globales.Id_Cantidad_Agregados_1 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                        }
                        else
                        {
                            if (Cant == 2)
                            {
                                Cant = Cant + 1;
                                Variables_Globales.N_Solicitud_2 = Convert.ToInt32(dr["N_Solicitud"]);
                                Variables_Globales.Id_Cantidad_Agregados_2 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                            }
                            else
                            {
                            if (Cant == 3)
                            {
                                Cant = Cant + 1;
                                Variables_Globales.N_Solicitud_3 = Convert.ToInt32(dr["N_Solicitud"]);
                                Variables_Globales.Id_Cantidad_Agregados_3 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                            }
                            else
                            {
                                    if (Cant == 4)
                                    {
                                        Cant = Cant + 1;
                                        Variables_Globales.N_Solicitud_4 = Convert.ToInt32(dr["N_Solicitud"]);
                                        Variables_Globales.Id_Cantidad_Agregados_4 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                                    }
                                    else
                                    {
                                        if (Cant == 5)
                                        {
                                            Cant = Cant + 1;
                                            Variables_Globales.N_Solicitud_5 = Convert.ToInt32(dr["N_Solicitud"]);
                                            Variables_Globales.Id_Cantidad_Agregados_5 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                                        }
                                        else
                                        {
                                            if (Cant == 6)
                                            {
                                                Cant = Cant + 1;
                                                Variables_Globales.N_Solicitud_6 = Convert.ToInt32(dr["N_Solicitud"]);
                                                Variables_Globales.Id_Cantidad_Agregados_6 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                                            }
                                            else
                                            {
                                                if (Cant == 7)
                                                {
                                                    Cant = Cant + 1;
                                                    Variables_Globales.N_Solicitud_7 = Convert.ToInt32(dr["N_Solicitud"]);
                                                    Variables_Globales.Id_Cantidad_Agregados_7 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                                                }
                                                else
                                                {
                                                    if (Cant == 8)
                                                    {
                                                        Cant = Cant + 1;
                                                        Variables_Globales.N_Solicitud_8 = Convert.ToInt32(dr["N_Solicitud"]);
                                                        Variables_Globales.Id_Cantidad_Agregados_8 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                                                    }
                                                    else
                                                    {
                                                        if (Cant == 9)
                                                        {
                                                            Cant = Cant + 1;
                                                            Variables_Globales.N_Solicitud_9 = Convert.ToInt32(dr["N_Solicitud"]);
                                                            Variables_Globales.Id_Cantidad_Agregados_9 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                                                        }
                                                        else
                                                        {
                                                            if (Cant == 10)
                                                            {
                                                                Cant = Cant + 1;
                                                                Variables_Globales.N_Solicitud_10 = Convert.ToInt32(dr["N_Solicitud"]);
                                                                Variables_Globales.Id_Cantidad_Agregados_10 = Convert.ToInt32(dr["Id_Cantidad_Agregados"]);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Cantidad_Mensaje_de_Agregados",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Cantidad_Mensaje_de_Agregados(int Id_Articulo, int N_Solicitud)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Cantidad_Mensaje_de_Agregados", cnx);
                cmd.Parameters.Add("@Id_Articulo", SqlDbType.Int).Value = Id_Articulo;
                cmd.Parameters.Add("@N_Solicitud", SqlDbType.Int).Value = N_Solicitud;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Mensaje_Agregados = Convert.ToString(dr["Mensaje"]);
                        Variables_Globales.Cantidad_Agregados = Convert.ToInt32(dr["Cantidad"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Cantidad_Mensaje_de_Agregados",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Descripcion_Ciudad_x_ID(int ID)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Descripcion_Ciudad_x_ID", cnx);
                cmd.Parameters.Add("@Id_Ciudad", SqlDbType.NVarChar).Value = ID;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Ciudad_Cliente_Nueva = Convert.ToString(dr["Descripcion"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Descripcion_Ciudad_x_ID",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Descripcion_Comuna_x_ID(int ID)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Descripcion_Comuna_x_ID", cnx);
                cmd.Parameters.Add("@Id_Comuna", SqlDbType.NVarChar).Value = ID;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Comuna_Cliente_Nueva = Convert.ToString(dr["Descripcion"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Descripcion_Comuna_x_ID",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Codigo_Detalle_Comanda(int Id_Detalle_Comanda)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Codigo_Detalle_Comanda", cnx);
                cmd.Parameters.Add("@Id_Detalle_Comanda", SqlDbType.Int).Value = Id_Detalle_Comanda;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                Variables_Globales.Id_Articulo = 0;
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Codigo = Convert.ToString(dr["Codigo"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Codigo_Detalle_Comanda",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Id_Articulo_x_Codigo(string Codigo)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Id_Articulo_x_Codigo", cnx);
                cmd.Parameters.Add("@Codigo", SqlDbType.NVarChar).Value = Codigo;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                Variables_Globales.Id_Articulo = 0;
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Id_Articulo = Convert.ToInt32(dr["Id_Articulo"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Id_Articulo_x_Codigo",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Direccion_Cliente_x_ID(int ID)
        {

            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Direccion_Cliente_x_ID", cnx);
                cmd.Parameters.Add("@Id_Direcciones_Cliente", SqlDbType.NVarChar).Value = ID;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Apodo_Cliente = Convert.ToString(dr["Apodo"]);
                        Variables_Globales.Direccion_Cliente = Convert.ToString(dr["Direccion"]);
                        Variables_Globales.Comuna_Cliente = Convert.ToString(dr["Comuna"]);
                        Variables_Globales.Ciudad_Cliente = Convert.ToString(dr["Ciudad"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Datos_Empleado",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static List<Comuna> Trae_Comunas(int Id_Ciudad, string Busqueda)
        {
            List<Comuna> lista = new List<Comuna>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Comunas", cnx);
                cmd.Parameters.Add("@Busqueda", SqlDbType.VarChar).Value = Busqueda;
                cmd.Parameters.Add("@Id_Ciudad", SqlDbType.VarChar).Value = Id_Ciudad;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Comuna>();
                while (dr.Read())
                {
                    Comuna p = new Comuna();
                    p.ID = Convert.ToInt32(dr["Id_Comuna"]);
                    p.Id_Ciudad = Convert.ToInt32(dr["Id_Ciudad"]);
                    p.Descripcion = Convert.ToString(dr["Descripcion"]);
                    lista.Add(p);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Ciudad> Trae_Ciudades(string Busqueda)
        {
            List<Ciudad> lista = new List<Ciudad>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Ciudades", cnx);
                cmd.Parameters.Add("@Busqueda", SqlDbType.VarChar).Value = Busqueda;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Ciudad>();
                while (dr.Read())
                {
                    Ciudad p = new Ciudad();
                    p.ID = Convert.ToInt32(dr["Id_Ciudad"]);
                    p.Descripcion = Convert.ToString(dr["Descripcion"]);
                    lista.Add(p);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Agregado_Articulo> Trae_Agregados_Articulo(int Id_Articulo, int Id_Cantidad_Agregados)
        {
            List<Agregado_Articulo> lista = new List<Agregado_Articulo>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Agregados_Articulo", cnx);
                cmd.Parameters.Add("@Id_Articulo", SqlDbType.VarChar).Value = Id_Articulo;
                cmd.Parameters.Add("@Id_Cantidad_Agregados", SqlDbType.VarChar).Value = Id_Cantidad_Agregados;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Agregado_Articulo>();
                while (dr.Read())
                {
                    Agregado_Articulo p = new Agregado_Articulo();
                    p.ID = Convert.ToInt32(dr["Id_Agregado_Articulo"]);
                    p.Id_Articulo = Convert.ToInt32(dr["Id_Articulo"]);
                    p.Id_Articulo_Agregado = Convert.ToInt32(dr["Id_Articulo_Agregado"]);
                    p.Descripcion = Convert.ToString(dr["Descripcion"]);
                    lista.Add(p);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Direcciones_Clientes> Trae_Direcciones_Cliente(int Id_Cliente)
        {
            List<Direcciones_Clientes> lista = new List<Direcciones_Clientes>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Direcciones_Cliente", cnx);
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = Id_Cliente;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Direcciones_Clientes>();
                while (dr.Read())
                {
                    Direcciones_Clientes p = new Direcciones_Clientes();
                    p.ID = Convert.ToInt32(dr["Id_Direcciones_Cliente"]);
                    p.Apodo = Convert.ToString(dr["Apodo"]);
                    p.Direccion = Convert.ToString(dr["Direccion"]) + ", " + Convert.ToString(dr["Comuna"]) + ", " + Convert.ToString(dr["Ciudad"]) ;
                    p.Id_Ciudad = Convert.ToInt32(dr["Id_Ciudad"]);
                    p.Ciudad = Convert.ToString(dr["Ciudad"]);
                    p.Id_Comuna = Convert.ToInt32(dr["Id_Comuna"]);
                    p.Comuna = Convert.ToString(dr["Comuna"]);
                    p.Referencia = Convert.ToString(dr["Referencia"]);
                    p.Telefono_Celular = Convert.ToString(dr["Telefono_Celular"]);
                    p.Estado = Convert.ToInt32(dr["Estado"]);
                    p.Email = Convert.ToString(dr["Email"]);
                    lista.Add(p);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Categorias_APP> Trae_Categoria_APP(string Categoria)
        {
            List<Categorias_APP> lista = new List<Categorias_APP>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Categoria_APP", cnx);

                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Categorias_APP>();
                while (dr.Read())
                {
                    Categorias_APP Categorias_APP = new Categorias_APP()
                    {
                        Nombre = dr.GetString(0),
                        Imagen = (byte[])dr["Imagen"],
                        Orden = dr.GetInt32(2),
                        Descripcion = dr.GetString(3),
                        Estado = dr.GetInt32(4),
                    };
                    lista.Add(Categorias_APP);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Categorias_APP> Obtener_todas_las_Categorias_APP()
        {
            Variables_Globales.Categroia_1 = "";
            List <Categorias_APP> lista = new List<Categorias_APP>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Obtener_todas_las_Categorias_APP", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Categorias_APP>();
                int cant = 1;
                while (dr.Read())
                {
                    Categorias_APP Categorias_APP = new Categorias_APP()
                    {
                        Nombre = dr.GetString(0),
                    };
                    lista.Add(Categorias_APP);
                    if (cant == 1) { Variables_Globales.Categroia_1 = dr.GetString(0); cant = cant + 1; }
                    break;
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }
        public static async void Incrementa_Correlativo_Delivery(int Folio_Serie_Disponible)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Incrementa_Correlativo_Delivery", cnx);
                cmd.Parameters.Add("@Folio_Serie_Disponible", SqlDbType.Int).Value = Folio_Serie_Disponible;
                cmd.Parameters.Add("@Nombre_Documento", SqlDbType.NVarChar).Value = "Delivery";
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                  "Incrementa_Correlativo_Delivery",
                                                  e.Message,
                                                  "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Correlativo_Delivery_e_Incrementa()
        {
            SqlCommand cmd = null;
            try
            {
                Variables_Globales.Correlativo_Delivery = 0;
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Correlativo_Delivery_e_Incrementa", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Correlativo_Delivery = Convert.ToInt32(dr["Folio_Serie_Disponible"]);
                    }
                }
                Variables_Globales.Correlativo_Delivery = Variables_Globales.Correlativo_Delivery + 1;
                Variables_Globales.Id_Mesa = Variables_Globales.Correlativo_Delivery;
                Incrementa_Correlativo_Delivery(Variables_Globales.Correlativo_Delivery);
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Correlativo_Delivery_e_Incrementa",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static List<Mesas> Trae_Mesa_Delivery_Desocupada()
        {
           
            List<Mesas> lista = new List<Mesas>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Mesa_Delivery_Desocupada", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Mesas>();
                while (dr.Read())
                {
                    Mesas Mesas = new Mesas()
                    {
                        ID = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                    };
                    lista.Add(Mesas);
                    Variables_Globales.Id_Mesa = dr.GetInt32(0);
                    break;
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }
        public static void Totaliza_Detalle_Comandas_APP(int Id_Comanda)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Variables_Globales.Total_Cuenta = 0;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Totaliza_Detalle_Comandas_APP", cnx);
                cmd.Parameters.Add("@Id_Comanda", SqlDbType.Int).Value = Id_Comanda;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Total_Cuenta = Convert.ToInt32(dr["Total"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Variables_Globales.Total_Cuenta = 0;
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }

        }
        
        public static List<Detalle_Comanda> Trae_Detalle_Comandas_APP(int Id_Comanda)
        {
            List<Detalle_Comanda> lista = new List<Detalle_Comanda>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Detalle_Comandas_APP", cnx);
                cmd.Parameters.Add("@Id_Comanda", SqlDbType.Int).Value = Id_Comanda;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Detalle_Comanda>();
                while (dr.Read())
                {
                    Detalle_Comanda Detalle_Comanda = new Detalle_Comanda()
                    {
                        Categoria = dr.GetString(0),
                        Descripcion = dr.GetString(1),
                        Cantidad = dr.GetInt32(2),
                        Total = dr.GetInt32(3),
                        ID = dr.GetInt32(4),
                        Observación = dr.GetString(5),
                    };

                    lista.Add(Detalle_Comanda);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }
        public static async void Verifica_si_Tiene_Agregados(int Id_Articulo)
        {

            SqlCommand cmd = null;
            try
            {
                Variables_Globales.Tiene_Agregados = false;
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Verifica_si_Tiene_Agregados", cnx);
                cmd.Parameters.Add("@Id_Articulo", SqlDbType.NVarChar).Value = Id_Articulo;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Tiene_Agregados = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Verifica_si_Tiene_Agregados",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        #endregion


        #region Articulos
        public static List<Articulos> Llenar_Lista_con_Articulos_x_Categoria(string Categoria)
        {
            List<Articulos> lista = new List<Articulos>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Llenar_Lista_con_Articulos_x_Categoria", cnx);
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = Categoria;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Articulos>();
                while (dr.Read())
                {
                    Articulos p = new Articulos();
                    p.ID = Convert.ToInt32(dr["Id_Articulo"]);
                    p.Nombre = Convert.ToString(dr["Nombre"]);
                    p.Categoria = Convert.ToString(dr["Categoría"]);
                    p.Imagen = (byte[])dr["Imagen"];
                    p.Codigo = Convert.ToString(dr["Codigo"]);
                    p.Precio_Venta = Convert.ToInt32(dr["Precio_Venta"]);
                    p.Costo_Envio = Convert.ToInt32(dr["Costo_Envio"]);
                    p.Consumo_Minimo = Convert.ToInt32(dr["Consumo_Minimo"]);
                    p.Evaluacion = Convert.ToDouble(dr["Evaluacion"]);
                    p.Tiempo_Espera = Convert.ToString(dr["Tiempo_Espera"]);
                    p.Componentes = Convert.ToString(dr["Componentes"]);
                    p.Oferta = Convert.ToString(dr["Oferta"]);
                    lista.Add(p);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Forma_Pago> Trae_Forma_Pago(int Id_Empresa)
        {
            List<Forma_Pago> lista = new List<Forma_Pago>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Forma_Pago", cnx);
                cmd.Parameters.Add("@Id_Empresa", SqlDbType.VarChar).Value = Id_Empresa;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Forma_Pago>();
                while (dr.Read())
                {
                    Forma_Pago p = new Forma_Pago();
                    p.ID = Convert.ToInt32(dr["Id_Forma_Pago_App"]);
                    p.Descripcion = Convert.ToString(dr["Descripcion"]);
                    lista.Add(p);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Articulos> Llenar_Lista_con_Articulos_Recomendados(int Id_Empresa)
        {
            List<Articulos> lista = new List<Articulos>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Llenar_Lista_con_Articulos_Recomendados", cnx);
                cmd.Parameters.Add("@Id_Empresa", SqlDbType.VarChar).Value = Id_Empresa;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Articulos>();
                while (dr.Read())
                {
                    Articulos p = new Articulos();
                    p.ID = Convert.ToInt32(dr["Id_Articulo"]);
                    p.Nombre = Convert.ToString(dr["Nombre"]);
                    p.Categoria = Convert.ToString(dr["Categoría"]);
                    p.Imagen = (byte[])dr["Imagen"];
                    p.Codigo = Convert.ToString(dr["Codigo"]);
                    p.Precio_Venta = Convert.ToInt32(dr["Precio_Venta"]);
                    p.Costo_Envio = Convert.ToInt32(dr["Costo_Envio"]);
                    p.Consumo_Minimo = Convert.ToInt32(dr["Consumo_Minimo"]);
                    p.Evaluacion = Convert.ToDouble(dr["Evaluacion"]);
                    p.Tiempo_Espera = Convert.ToString(dr["Tiempo_Espera"]);
                    p.Oferta = Convert.ToString(dr["Oferta"]);
                    lista.Add(p);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static async void Obtener_Articulo(string Codigo)
        {
            SqlCommand cmd = null;
            try
            {
                int Id_Articulo = 0;
                Variables_Globales.Nombre_Articulo = "No Exste";
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Obtener_Articulo", cnx);
                cmd.Parameters.Add("@Id_Bodega", SqlDbType.VarChar).Value = Variables_Globales.Id_Bodega;
                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Codigo;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        int Descuento_Articulo = 0;
                        int Precio_Venta = 0;
                        Descuento_Articulo = 0;
                        Precio_Venta = Variables_Globales.Precio_Venta;
                        Variables_Globales.Nombre_Articulo = Convert.ToString(dr["Descripcion"]);
                        Variables_Globales.Codigo = Convert.ToString(dr["Codigo"]);
                        Variables_Globales.Stock = Convert.ToInt32(dr["Stock_Actual"]);
                        Variables_Globales.Imagen_Articulo = (byte[])dr["Imagen"];
                        //Imagen = (byte[])dr["Imagen"],
                    }
                }
                Variables_Globales.Grabo_Nota_Venta = 0;
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Obtener_Articulo_y_Crea_Detalle_Nota_Venta",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static int Precio_Venta(int Id_Articulo)
        {
            //Trae_Precio_Venta_de_Anexo_Articulo_x_Lista_Precio(Id_Articulo);
            int Precio_Venta_New = Variables_Globales.Precio_Venta;
            return Precio_Venta_New;
        }
        public static List<Articulos> Trae_Articulo_APP(int Id_Empresa, string Codigo)
        {
            List<Articulos> lista = new List<Articulos>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Articulo_APP", cnx);
                cmd.Parameters.Add("@Id_Empresa", SqlDbType.VarChar).Value = Id_Empresa;
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Articulos>();
                while (dr.Read())
                {
                    Articulos articulos = new Articulos()
                    {
                        ID = Convert.ToInt32(dr["Id_Articulo"]),
                        Nombre = Convert.ToString(dr["Nombre"]),
                        Categoria = Convert.ToString(dr["Categoría"]),
                        Imagen = (byte[])dr["Imagen"],
                        Codigo = Convert.ToString(dr["Codigo"]),
                        Precio_Venta = Convert.ToInt32(dr["Precio_Venta"]),
                        Costo_Envio = Convert.ToInt32(dr["Costo_Envio"]),
                        Consumo_Minimo = Convert.ToInt32(dr["Consumo_Minimo"]),
                        Evaluacion = Convert.ToDouble(dr["Evaluacion"]),
                        Componentes = Convert.ToString(dr["Componentes"]),
                        Tiempo_Espera = Convert.ToString(dr["Tiempo_Espera"]),
                    };
                    lista.Add(articulos);
                    Variables_Globales.Precio_Venta = Convert.ToInt32(dr["Precio_Venta"]);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Detalle_Comanda> Trae_Detalle_Pedido_x_ID(int Id_Detalle_Comanda)
        {
            List<Detalle_Comanda> lista = new List<Detalle_Comanda>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Detalle_Pedido_x_ID", cnx);
                cmd.Parameters.Add("@Id_Detalle_Comanda", SqlDbType.Int).Value = Id_Detalle_Comanda;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Detalle_Comanda>();
                while (dr.Read())
                {
                    Detalle_Comanda Detalle_Comanda = new Detalle_Comanda()
                    {
                        Descripcion = Convert.ToString(dr["Nombre"]),
                        Categoria = Convert.ToString(dr["Categoría"]),
                        Imagen = (byte[])dr["Imagen"],
                        Codigo = Convert.ToString(dr["Codigo"]),
                        Precio_Venta = Convert.ToInt32(dr["Precio_Venta"]),
                        Costo_Envio = Convert.ToInt32(dr["Costo_Envio"]),
                        Consumo_Minimo = Convert.ToInt32(dr["Consumo_Minimo"]),
                        Evaluacion = Convert.ToDouble(dr["Evaluacion"]),
                        Componentes = Convert.ToString(dr["Componentes"]),
                        Tiempo_Espera = Convert.ToString(dr["Tiempo_Espera"]),
                        Observación = Convert.ToString(dr["Observación"]),
                        Cantidad = Convert.ToInt32(dr["Cantidad"]),
                    };
                    lista.Add(Detalle_Comanda);
                    Variables_Globales.Precio_Venta = Convert.ToInt32(dr["Precio_Venta"]);
                    Variables_Globales.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    Variables_Globales.Observacion = Convert.ToString(dr["Observación"]);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static async void Modificar_Detalle_Comanda(int Id_Detalle_Comanda, int Cantidad, string Observación, int Total)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Modificar_Detalle_Comanda", cnx);
                cmd.Parameters.Add("@Id_Detalle_Comanda", SqlDbType.Int).Value = Id_Detalle_Comanda;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
                cmd.Parameters.Add("@Observación", SqlDbType.NVarChar).Value = Observación;
                cmd.Parameters.Add("@Total", SqlDbType.NVarChar).Value = Total;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Modificar_Detalle_Comanda",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Eliminar_Detalle_Comanda(int Id_Detalle_Comanda)
        {
            SqlCommand cmd = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Eliminar_Detalle_Comanda", cnx);
                cmd.Parameters.Add("@Id_Detalle_Comanda", SqlDbType.Int).Value = Id_Detalle_Comanda;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Eliminar_Detalle_Comanda",
                            e.Message,
                           "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static List<Articulos> Trae_Articulo(string Codigo)
        {
            List<Articulos> lista = new List<Articulos>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Articulo", cnx);

                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Articulos>();
                while (dr.Read())
                {
                    Articulos articulos = new Articulos()
                    {
                        ID = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Categoria = dr.GetString(3),
                        Precio_Venta = dr.GetInt32(4),
                        Imagen = (byte[])dr["Imagen"],
                        Codigo = dr.GetString(6),
                    };
                    lista.Add(articulos);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public static List<Articulos> Trae_Todos_los_Articulos()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Todos_los_Articulos", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                lista = new List<Articulos>();
                while (dr.Read())
                {
                    Articulos articulos = new Articulos()
                    {
                        ID = dr.GetInt32(0),
                        Codigo = dr.GetString(1),
                        Categoria = dr.GetString(2),
                        Nombre = dr.GetString(3),
                        Imagen = (byte[])dr["Imagen"],
                        Stock = Convert.ToInt32(dr.GetValue(4)),
                        Precio_Venta = Convert.ToInt32(Precio_Venta(dr.GetInt32(0))),
                    };
                    lista.Add(articulos);
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
         }
        #endregion

       
        #region Empresa - Sucursal - Bodega
        public static async void Trea_Datos_Empresa()
        {
            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Datos_Empresa_2", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Rut_Empresa = Convert.ToInt32(dr["Rut_Empresa"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Datos_Empresa_2",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static async void Trae_Id_Bodega_Sucursal(int Id_Sucursal)
        {
            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Trae_Id_Bodega_Sucursal", cnx);
                cmd.Parameters.Add("@Id_Sucursal", SqlDbType.NVarChar).Value = Id_Sucursal;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Variables_Globales.Id_Bodega = Convert.ToInt32(dr["Id_Bodega"]);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                      "Trae_Id_Bodega_Sucursal",
                                                      e.Message,
                                                      "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        #endregion

        #region Autorizaciones ----------------> Procedimiento Almacenado
     
        public static async void Verifica_Autorizacion(string Usuario, string Menu)
        {
            SqlCommand cmd = null;
            try
            {
                SqlDataReader dr = null;
                Conexion cn = new Conexion();
                SqlConnection cnx = cn.Conectar();
                cmd = new SqlCommand("Verifica_Autorizacion", cnx);
                cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = Usuario;
                cmd.Parameters.Add("@Menu", SqlDbType.NVarChar).Value = Menu;
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();
                var Estado = false;
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Estado = dr.GetBoolean(2);
                    }
                }
                if (Estado == true)
                {
                    Variables_Globales.Autorizado = 1;
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                                                       "Verifica_Autorizacion",
                                                       e.Message,
                                                       "Aceptar");
                return;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        #endregion
    }
}

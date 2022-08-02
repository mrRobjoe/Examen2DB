using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen2JoharieEnriquez
{
    public class ClsCliente
    {
        private static string cedula { get; set; }
        private static string nombre { get; set; }
        private static string direccion { get; set; }
        private static string telefono { get; set; }

        private static float montoPagar { get; set; }
        private static float descuento { get; set; }
        private static float subTotal { get; set; }
        private static float iva { get; set; }
        private static float total { get; set; }

        private static int codFactura { get; set; }
        private static int codServicio;
        private static string tipServ;

        public ClsCliente(string nom, string ced, string direc, string telef, float montoPag, float desc, float subTo, float IVA, float tot)
        {
            nombre = nom;
            cedula = ced;
            direccion=direc;
            telefono = telef;
            montoPagar= montoPag;
            descuento = desc;
            subTotal = subTo;
            iva= IVA;
            total= tot;
            codFactura = 0;
        }

       /* internal static void SetMontoPagar(string text)
        {
            throw new NotImplementedException();
        }*/

        public static string GetNombre() { return nombre; }
        public static string GetCedula() { return cedula; }
        public static string GetDireccion() { return direccion; }
        public static string GetTelefono() { return telefono; }
        public static float GetMontoPagar() { return montoPagar; }
        public static float GetDescuento() { return descuento; }
        public static float GetSubTotal() { return subTotal; }
        public static float GetIVA() { return iva; }
        public static float GetTotal() { return total; }

        public static int GetFactura() { return codFactura; }
        public static int GetServicio() { return codServicio; }
        public static string GetTipoServ() { return tipServ; }
        

        public static void SetCedula(string ced)
        {
            cedula = ced;
        }
        public static void SetNombre(string nom)
        {
            nombre = nom;
        }
        public static void SetDireccion(string dir)
        {
            direccion = dir;
        }
        public static void SetTelefono(string tell)
        {
            telefono = tell;
        }
        public static void SetMontoPagar(float montP)
        {
            montoPagar = montP;
        }
        public static void SetDescuento(float descc)
        {
            descuento = descc;
        }
        public static void SetSubTotal(float subTott)
        {
            subTotal = subTott;
        }
        public static void SetIVA(float iVA)
        {
            iva = iVA;
        }
        public static void SetTotal(float tott)
        {
            total = tott;
        }


        public static void SetFactura()
        {
            codFactura++;
        }
        public static void SetServicio(int codServ)
        {
            codServicio = codServ;
        }
        public static void SetTipoServ(string tServ)
        {
            tipServ = tServ;
        }

        //
        public static Boolean Salvar()
        {
            Boolean existe = false;
            //string strConnString = ConfigurationManager.ConnectionStrings["Examen2DBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Examen2DBConnectionString"].ConnectionString);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_Salvar", con);
                command.Parameters.Add(new SqlParameter("@nombre", nombre));
                command.Parameters.Add(new SqlParameter("@cedula", cedula));
                command.Parameters.Add(new SqlParameter("@telefono", telefono));
                command.Parameters.Add(new SqlParameter("@direccion", direccion));
                command.Parameters.Add(new SqlParameter("@montoPagar", montoPagar));
                command.Parameters.Add(new SqlParameter("@descuento", descuento));
                command.Parameters.Add(new SqlParameter("@subTotal", subTotal));
                command.Parameters.Add(new SqlParameter("@iva", iva));
                command.Parameters.Add(new SqlParameter("@total", total));
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                existe = true;
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return existe;
        }

        public static void Calculo()
        {
            SetSubTotal(montoPagar - descuento);
            SetIVA((float)(GetSubTotal() * 0.13));
            SetTotal(GetSubTotal() + GetIVA());
        }

        public static void codSer()
        {
            if (codServicio == 1)
            {
                tipServ = "Electricidad";
            }
            else if (codServicio == 2)
            {
                tipServ = "Agua";
            }
            else if (codServicio==3)
            {
                tipServ = "Cable";
            }
            else if (codServicio==4)
            {
                tipServ = "Teléfono";
            }
        }
    }
}
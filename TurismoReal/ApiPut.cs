using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal
{
    public class ApiPut
    {

        public dynamic Modificar(string url, string json, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.PUT);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }

                IRestResponse response = client.Execute(request);

                dynamic datos = JsonConvert.DeserializeObject(response.Content);

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //public dynamic Modificar(string url, int id, string direccion, string zona, int banos, int dormitorios, bool estado_mantencion, int precio, int metros)
        //{
        //    try
        //    {
        //        var client = new RestClient(url);
        //        var request = new RestRequest($"departamentos/{id}/", Method.PUT);
        //        //request.AddHeader("content-type", "application/json");

        //        request.AddParameter("direccion", direccion);
        //        request.AddParameter("zona", zona);
        //        request.AddParameter("banos", banos);
        //        request.AddParameter("dormitorios", dormitorios);
        //        request.AddParameter("estado_mantencion", estado_mantencion);
        //        request.AddParameter("precio", precio); 
        //        request.AddParameter("metros_cuadrados", metros);


        //        //if (autorizacion != null)
        //        //{
        //        //    request.AddHeader("Authorization", autorizacion);
        //        //}
        //        var response = client.Execute(request);
        //        //IRestResponse response = client.Execute(request);

        //        dynamic datos = JsonConvert.DeserializeObject(response.Content);

        //        return datos;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}
    }
}

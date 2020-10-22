using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://departamentos.pythonanywhere.com/api/";
        public static string LectorJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        #region API DEPARTAMENTOS
        //---BTN MOSTRAR DEPTOS---
        public static async Task<string> MostrarDepto()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "departamentos"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;
        }

        //---BTN BUSCAR DEPTOS---
        public static async Task<string> BuscarDepto(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "departamentos/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        //---BTN AGREGAR DEPTOS---

        //public void AgregarDepto(string direccion, string zona, int banos, int dormitorios, bool estado_mantencion, int precio, int metros)
            

        //public static async Task<string> AgregarDepto(string direccion, string zona, int banos, int dormitorios, bool estado_mantencion, int precio, int metros)
        //{

        //    //var inputData = new Dictionary<int, Departamento>()
        //    //{
        //    //    {1, new Departamento { direccion= direccion ,
        //    //    zona = zona ,
        //    //    banos = banos ,
        //    //    dormitorios = dormitorios ,
        //    //    estado_mantencion = estado_mantencion ,
        //    //    precio = precio ,
        //    //    metros_cuadrados = metros } }
        //    //};


        //    //var inputData = new Dictionary<string,string>
        //    //{
        //    //     { "direccion", direccion },
        //    //    { "zona", zona },
        //    //    { "banos", banos },
        //    //    { "dormitorios", dormitorios },
        //    //    { "estado_mantencion", mantencion },
        //    //    { "precio", precio },
        //    //    { "metros_cuadrados", metros }
        //    //};
        //    var input = new FormUrlEncodedContent(new[]{
        //        new KeyValuePair<string,string>("direccion",direccion),
        //        new KeyValuePair<string, string>("zona",zona),
        //        new KeyValuePair<string, int>("banos",banos),

        //    });
        //    using (HttpClient client = new HttpClient())
        //    {
        //        using (HttpResponseMessage res = await client.PostAsync(baseURL + "departamentos/", input))
        //        {
        //            using (HttpContent content = res.Content)
        //            {
        //                string data = await content.ReadAsStringAsync();
        //                if (data != null)
        //                {
        //                    return data;
        //                }
        //            }
        //        }
        //    }
        //    return string.Empty;
        //}
        #endregion

        #region API FUNCIONARIOS
        //---BTN MOSTRAR FUNCIONARIOS---
        public static async Task<string> MostrarFunc()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "usuarios"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;
        }

        //---BTN BUSCAR FUNCIONARIOS---
        public static async Task<string> BuscarFunc(String id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "usuarios/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        #endregion
    }
}

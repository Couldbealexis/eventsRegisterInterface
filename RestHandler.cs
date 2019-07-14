using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eventsRegisterInterface
{
    public class RestHandler
    {
        protected static string url = "http://localhost:3000/api/v1/"; // Dev

        public static restResponse RESTData(string uri, string method, Dictionary<String, String> data)
        {
            restResponse resp = new restResponse();
            try
            {
                string route = url + uri;
                var request = HttpWebRequest.Create(route);
                request.Method = method;
                request.ContentType = "application/x-www-form-urlencoded";

                string sendData = makedata(data);
                byte[] byteArray = Encoding.UTF8.GetBytes(sendData);
                request.ContentLength = byteArray.Length;

                using (Stream dataStream = request.GetRequestStream())
                {
                    using (StreamWriter stmw = new StreamWriter(dataStream))
                    {
                        stmw.Write(sendData);
                    }
                }
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    dynamic json;
                    string read = reader.ReadToEnd();
                    json = JsonConvert.DeserializeObject(read);
                    resp.response = json.response;
                    resp.code = json.code;
                    resp.data = json.data;
                    resp.message = json.message;
                    resp.devMessage = json.devMessage;
                }
                return resp;
            } catch
            {
                resp.response = false;
                resp.code = 500;
                resp.message = "Error de servidor.";
                resp.devMessage = "Server is not up";
                return resp;
            }
            
        }

        public static restResponse RESTGETData(string uri, string method)
        {
            restResponse resp = new restResponse();
            string route = url + uri;
            var request = HttpWebRequest.Create(route);
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";

            //string sendData = makedata(data);
            //byte[] byteArray = Encoding.UTF8.GetBytes(sendData);
            //request.ContentLength = byteArray.Length;

            //using (Stream dataStream = request.GetRequestStream())
            //{
            //    using (StreamWriter stmw = new StreamWriter(dataStream))
            //    {
            //        stmw.Write(sendData);
            //    }
            //}
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                dynamic json;
                string read = reader.ReadToEnd();
                json = JsonConvert.DeserializeObject(read);
                resp.response = json.response;
                resp.code = json.code;
                resp.data = json.data;
                resp.message = json.message;
                resp.devMessage = json.devMessage;
            }
            return resp;
        }

        public static string makedata(Dictionary<String, String> data)
        {
            string myVal = "";
            foreach (KeyValuePair<string, string> item in data)
            {
                myVal += item.Key + "=" + item.Value + "&";
            }
            myVal = myVal.Substring(0, myVal.Length - 1);
            return myVal;
        }

        public class restResponse
        {
            public bool response { get; set; }
            public int code { get; set; }
            public dynamic data { get; set; }
            public string message { get; set; }
            public string devMessage { get; set; }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HostComSip
{
    class Program
    {
        //private static string port = "";
        //private static string uni_host = "http://35.190.172.58";
        //private static string port_statis = "11960";
        //private static string host_port = "/api/absen/port";


        static FirewallSip _security = new FirewallSip();
        static string pathHost = System.IO.Path.GetFullPath(System.IO.Path.GetDirectoryName(Application.ExecutablePath)) + @"\WebService\absen.sip";
       // static string pathDB = System.IO.Path.GetFullPath(System.IO.Path.GetDirectoryName(Application.ExecutablePath)) + @"\myconfig.ini";
        //static string _koneksi = "Server={0};Database={1};User Id={2};Password={3};";
        static void Main(string[] args)
        {

            //Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " start HostCommSip ..");
            //Console.WriteLine("");

            //var httpWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(uni_host + ":" + port_statis + "" + host_port);
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";
            //var httpResponse = (System.Net.HttpWebResponse)httpWebRequest.GetResponse();
            //string status = string.Empty;
            //using (var streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //    status = result;
            //}
            //if (status != string.Empty)
            //{
            //    var o = Newtonsoft.Json.Linq.JObject.Parse(status);
            //    status = o["status"].ToString();

            //    if (status == "00")
            //    {
            //        port = o["port"].ToString();
            //    }
            //    else
            //    {
            //        port = port_statis;
            //    }
            //}
            //else
            //{
            //    port = port_statis;
            //}
            
            //proses fungsi upload dipindah ke consoleform

            ConsoleForm cf = new ConsoleForm();
            cf.ShowDialog();
        }
        static string ReadURL()
        {
            using (StreamReader sr = new StreamReader(pathHost))
            {
                //Console.WriteLine(_security.Decrypt(sr.ReadToEnd(), true));
                //Console.ReadKey();
                return _security.Decrypt(sr.ReadToEnd(), true);
            }
        }
        
    }
}

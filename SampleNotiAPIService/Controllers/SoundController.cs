using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;

namespace SampleNotiAPIService.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SoundController : Controller
    {

        [HttpPost]
        public void Sound1()
        {
            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic MjhjZDc2ZjAtNTNlMC00Y2RjLWJkYmItZGIyOWFjNDhkMTU2");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                
                app_id = "453e86e6-ea43-4335-9073-860778c07f96",
                contents = new { en = "this is a sound1 test" },
                included_segments = new string[] { "All" },
                ios_sound = "sound1.wav",
                android_channel_id = "82d6ce24-ddf3-47b0-ad1e-0b79ece6e949",
                android_group = "sound1"
            };
            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }

            System.Diagnostics.Debug.WriteLine(responseContent);
        }

        [HttpPost]
        public void Sound2()
        {
            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic MjhjZDc2ZjAtNTNlMC00Y2RjLWJkYmItZGIyOWFjNDhkMTU2");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "453e86e6-ea43-4335-9073-860778c07f96",
                contents = new { en = "this is a sound2 test" },
                included_segments = new string[] { "All" },
                ios_sound = "sound2.wav",
                android_channel_id = "784aa0d3-49cf-4fc8-b482-b5693ef2217f",
                android_group = "sound2"
            };
            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }

            System.Diagnostics.Debug.WriteLine(responseContent);
        }

        [HttpPost]
        public void Sound3()
        {
            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic MjhjZDc2ZjAtNTNlMC00Y2RjLWJkYmItZGIyOWFjNDhkMTU2");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "453e86e6-ea43-4335-9073-860778c07f96",
                contents = new { en = "this is a sound3 test" },
                included_segments = new string[] { "All" },
                ios_sound = "sound3.wav",
                android_channel_id = "bba6ab8d-5e04-491a-884f-48a88ae020b0",
                android_group = "sound3"

            };
            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }

            System.Diagnostics.Debug.WriteLine(responseContent);
        }

    }
}
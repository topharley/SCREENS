using System;
using System.IO;
using System.Net;

namespace Screens
{
    class Shortener
    {
        public static string Shorten(string url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.googleapis.com/urlshortener/v1/url?key=AIzaSyBzhflLmDnhZe5uzD1fVXQ9wdlxLp94yIY");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"longUrl\":\"" + url + "\"}";
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var responseStream = httpResponse.GetResponseStream();
            if (responseStream == null) throw new Exception("Failed to get stream.");
            using (var streamReader = new StreamReader(responseStream))
            {
                var responseText = streamReader.ReadToEnd();
                var match = System.Text.RegularExpressions.Regex.Match(responseText, "\"id\"\\s*:\\s*\"(.*?)\"");
                if (!match.Success) throw new Exception("Failed to shorten.");
                return match.Groups[1].Value;
            }
        }
    }
}

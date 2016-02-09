using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Screens.Uploaders
{
    class CloudinaryUploader : Uploader
    {
        private readonly string BOUNDARY = "---------------------------" + DateTime.Now.Ticks.ToString("x");
        private readonly string KEY = "878128618122386";
        private readonly string SECRET = "GlbKJvaunMHpGLwZOS8RINq3O4o";
        private readonly string URL = "https://api.cloudinary.com/v1_1/scrns/image/upload";

        public override string Upload(Bitmap bitmap)
        {
            HttpWebResponse resp = CallAPI(Clipper.GetPng(bitmap));
            var responseStream = resp.GetResponseStream();
            if (responseStream == null) throw new Exception("Failed to access cloudinary.com.");
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string response = reader.ReadToEnd();
                return ParseResponse(response);
            }
        }

        private string ParseResponse(string response)
        {
            Match respMatch = Regex.Match(response, "\"url\"\\s*:\\s*\"(.*?)\"");
            if (!respMatch.Success) return null;
            return respMatch.Groups[1].Value;
        }

        private HttpWebResponse CallAPI(byte[] image)
        {
            var parameters = new SortedDictionary<string, object>();
            var request = WebRequest.Create(URL) as HttpWebRequest;
            request.Method = "POST";
            request.UserAgent = "Screens-.1";
            request.SendChunked = true;
            request.ContentType = "multipart/form-data; boundary=" + BOUNDARY;

            FinalizeUploadParameters(parameters);

            using (Stream requestStream = request.GetRequestStream())
            {
                using (StreamWriter writer = new StreamWriter(requestStream))
                {
                    foreach (var param in parameters)
                        WriteParam(writer, param.Key, param.Value.ToString());
                    WriteFile(writer, image);
                    writer.Write("--{0}--", BOUNDARY);
                }
            }

            return (HttpWebResponse)request.GetResponse();
        }

        private void WriteLine(StreamWriter writer)
        {
            writer.Write("\r\n");
        }

        private void WriteLine(StreamWriter writer, string format)
        {
            writer.Write(format);
            writer.Write("\r\n");
        }

        private void WriteLine(StreamWriter writer, string format, Object val)
        {
            writer.Write(format, val);
            writer.Write("\r\n");
        }

        private void WriteParam(StreamWriter writer, string key, string value)
        {
            WriteLine(writer, "--{0}", BOUNDARY);
            WriteLine(writer, "Content-Disposition: form-data; name=\"{0}\"", key);
            WriteLine(writer);
            WriteLine(writer, value);
        }

        private void WriteFile(StreamWriter writer, byte[] file)
        {
            WriteLine(writer, "--{0}", BOUNDARY);
            WriteLine(writer, "Content-Disposition: form-data;  name=\"file\"; filename=\"image.png\"");
            WriteLine(writer, "Content-Type: application/octet-stream");
            WriteLine(writer);

            writer.Flush();
            writer.BaseStream.Write(file, 0, file.Length);
        }

        private string SignParameters(IDictionary<string, object> parameters)
        {
            StringBuilder signBase = new StringBuilder(String.Join("&", parameters
                .Where(pair => pair.Value != null)
                .Select(pair => String.Format("{0}={1}", pair.Key,
                    pair.Value is IEnumerable<string>
                    ? String.Join(",", ((IEnumerable<string>)pair.Value).ToArray())
                    : pair.Value.ToString()))
                .ToArray()));

            signBase.Append(SECRET);

            var hash = ComputeHash(signBase.ToString());
            StringBuilder sign = new StringBuilder();
            foreach (byte b in hash) sign.Append(b.ToString("x2"));

            return sign.ToString();
        }

        private byte[] ComputeHash(string s)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
        }

        private void FinalizeUploadParameters(IDictionary<string, object> parameters)
        {
            parameters.Add("timestamp", GetTime());
            parameters.Add("signature", SignParameters(parameters));
            parameters.Add("api_key", KEY);
        }

        private string GetTime()
        {
            return Convert.ToInt64(((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds)).ToString();
        }
    }
}

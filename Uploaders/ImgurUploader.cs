using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using System.Text;
using System.Xml;

namespace Screens.Uploaders
{
    class ImgurUploader : Uploader
    {
        public override string Upload(Bitmap bitmap)
        {
            using (var w = new WebClient())
            {
                w.Headers.Add("Authorization", "Client-ID c5a1babe9d94dba");
                var values = new NameValueCollection { { "image", Convert.ToBase64String(Clipper.GetPng(bitmap)) } };
                byte[] response = w.UploadValues("https://api.imgur.com/3/upload.xml", values);
                var doc = new XmlDocument { InnerXml = Encoding.UTF8.GetString(response) };
                string stat = doc.DocumentElement.Attributes["success"].Value;
                if (stat == "1") return doc.DocumentElement.SelectSingleNode("link").InnerText;
                return null;
            }
        }
    }
}

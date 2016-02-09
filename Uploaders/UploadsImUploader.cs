using System.Collections.Specialized;
using System.Drawing;
using System.Xml;

namespace Screens.Uploaders
{
    class UploadsImUploader : Uploader
    {
        public override string Upload(Bitmap bitmap)
        {
            var prms = new NameValueCollection();
            prms.Add("format", "xml");
            string response = HttpUploadFile("http://uploads.im/api", "upload", Clipper.GetPng(bitmap), prms);
            var doc = new XmlDocument { InnerXml = response };
            string stat = doc.SelectSingleNode("//status_code").InnerText;
            if (stat == "200") return doc.SelectSingleNode("//img_url").InnerText;
            return null;
        }
    }
}

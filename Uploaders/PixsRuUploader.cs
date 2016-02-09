using System.Collections.Specialized;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Screens.Uploaders
{
    class PixsRuUploader : Uploader
    {
        public override string Upload(Bitmap bitmap)
        {
            var prms = new NameValueCollection();
            string response = HttpUploadFile("http://pixs.ru/redirects/upload.php", "userfile", Clipper.GetPng(bitmap), prms);
            return ParseResponse(response);
        }

        private string ParseResponse(string response)
        {
            Match respMatch = Regex.Match(response, "\\[IMG\\](.*?)\\[/IMG\\]");
            if (!respMatch.Success) return null;
            return respMatch.Groups[1].Value;
        }
    }
}

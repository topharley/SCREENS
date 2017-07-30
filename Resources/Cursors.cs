using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Screens.Resources
{
    public static class Cursors
    {
        private const string ourNamespace = "Screens.Resources.Cursors";
        private static Assembly ourAssembly;

        static Cursors()
        {
            ourAssembly = Assembly.GetExecutingAssembly();
        }

        public static Stream GetResourceStream(string fileName)
        {
            string fullName = ourNamespace + "." + fileName;
            return ourAssembly.GetManifestResourceStream(fullName);
        }

        public static Cursor GenericToolCursor
        {
            get { return new Cursor(GetResourceStream("GenericToolCursor.cur")); }
        }

        public static Cursor EraserToolCursor
        {
            get { return new Cursor(GetResourceStream("EraserToolCursor.cur")); }
        }

        public static Cursor PencilToolCursor
        {
            get { return new Cursor(GetResourceStream("PencilToolCursor.cur")); }
        }

        public static Cursor RectangleToolCursor
        {
            get { return new Cursor(GetResourceStream("RectangleToolCursor.cur")); }
        }
    }
}

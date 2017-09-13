using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MSWord = Microsoft.Office.Interop.Word;
using System.IO;

namespace WordClassLibrary
{
    public class ProcessWord
    {
        private MSWord.Application app;
        private MSWord.Document doc;
        public void OpenApplication()
        {
            if (app == null)
                app = new MSWord.Application { Visible = false };//Visible为true时会启动word文档
        }

        public bool OpenDocument(object file)
        {
            if (!File.Exists(file.ToString()))
                return false;
            if (app == null)
                OpenApplication();
            if (doc != null)
                CloseDocument();
            doc = app.Documents.Open(ref file, ReadOnly: false, Visible: false);//Visible为true时会打开word文档
            doc.Activate();
            return true;
        }

        public void SaveAsDocx(object newFile)
        {
            if (doc != null)
                doc.SaveAs(ref newFile);
        }

        public void CloseDocument()
        {
            if (doc != null)
            {
                doc.Close();
                doc = null;
            }
        }

        public void QuitApplication()
        {
            if (app != null)
            {
                app.Quit();
                app = null;
            }
        }
        public void Replace(object findText, object replaceWithText)
        {
            if (app == null)
                return;
            MSWord.Find find = app.ActiveWindow.Selection.Find;
            find.ClearFormatting();
            find.Replacement.ClearFormatting();
            find.Forward = true;
            find.Wrap = MSWord.WdFindWrap.wdFindContinue;

            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;                     
            object replace = 2;
            object wrap = 1;
            
            find.Execute(ref findText, ref matchCase, ref matchWholeWord,
    ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace, ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);            
            
        }
    }
}

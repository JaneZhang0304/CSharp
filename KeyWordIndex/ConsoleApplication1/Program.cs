using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MSWord = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using WordClassLibrary;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object fileName = Path.Combine(Environment.CurrentDirectory,"test2.doc");
                object newFileName = Path.Combine(Environment.CurrentDirectory,"new.doc");

                if(!File.Exists(fileName.ToString()))
                {
                    Console.WriteLine("不存在：" + fileName);
                }

                ProcessWord pd = new ProcessWord();
                try
                {
                    pd.OpenApplication();
                    if (pd.OpenDocument(fileName))
                    {
                        pd.Replace("[发明领域]：（关键词）", "[发明领域（关键词）]：");
                        pd.SaveAsDocx(newFileName);
                        pd.CloseDocument();
                    }                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    pd.CloseDocument();
                    pd.QuitApplication();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }           

        }
    }
}

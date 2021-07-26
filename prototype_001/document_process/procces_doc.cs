using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Data;
using System.IO;
using System.Reflection;
using System.Security.Permissions; 

namespace document_process
{
    public class procces_doc
    {
        //public static string GetFullPath(string path);

        public Boolean createdoc(System.Data.DataTable dt, Boolean x)
        {
            Application application = new Application();

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;


            DataTransaction.Document_class.document_modul_class docmodul = new DataTransaction.Document_class.document_modul_class();

            try
            {
                System.Data.DataTable dtnew = new System.Data.DataTable(); 

               dtnew = docmodul.getContentTemplate(dt, "selectByID");
              

                //string path;
                //path = Path.GetFullPath(Properties.Resources.template1);
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                var docPath = Path.Combine(outPutDirectory, "Resources\\template1.docx");

                Document doc = application.Documents.Open(docPath.ToString());
                object missing = System.Reflection.Missing.Value;

                int count = doc.Words.Count;

                if (dtnew.Rows.Count != 0)
                {
                    if (count != 0)
                    {
                        doc.Activate();
                       
                        FindAndReplace(application, "{$tag$}", dtnew.Rows[0]["TITLE"].ToString());
                        //FindAndReplace(application, "{$title$}", dtnew.Rows[0]["CONTENT"].ToString()); 
                        List<string> subs = new List<string>();
                        int counter = 0;
                        while (counter <= dtnew.Rows[0]["CONTENT"].ToString().Length)
                        {
                            if (dtnew.Rows[0]["CONTENT"].ToString().Length < counter + 250)
                            {
                                subs.Add(dtnew.Rows[0]["CONTENT"].ToString().Substring(counter, dtnew.Rows[0]["CONTENT"].ToString().Length - counter));
                            }
                            else
                            {
                                subs.Add(dtnew.Rows[0]["CONTENT"].ToString().Substring(counter, 250) + "#r#");
                            }
                            counter += 250;
                        }

                        Find findObject = application.Selection.Find;
                        findObject.ClearFormatting();
                        for (int i = 0; i < subs.Count; i++)
                        {
                            findObject.Text = "{$content$}"+i;
                            findObject.Replacement.ClearFormatting();
                            findObject.Replacement.Text = subs[i];

                            object replaceAll = WdReplace.wdReplaceAll;
                            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing, ref missing, ref missing,
                                ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                        }
                        


                     

                       
                        //FindAndReplace(application, "{$content$}", dtnew.Rows[0]["CONTENT"].ToString());
                    }
                }

                //for (int i = 1; i <= count; i++)
                //{

                //    string text = doc.Words[i].Text;

                //    Microsoft.Office.Interop.Word.Paragraph para1 = doc.Content.Paragraphs.Add(ref missing);
                //    object styleHeading1 = "Heading 1";
                //    para1.Range.set_Style(ref styleHeading1);
                //    para1.Range.Text = "Para 1 text";
                //    para1.Range.InsertParagraphAfter();

                //    Console.WriteLine("Word {0} = {1}", i, text);



                //}

                string folderOut = "Export Data"; 

                var pathSave = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var pathExport = Path.Combine(pathSave, folderOut);
                bool folderExist = Directory.Exists(pathExport); 

                if (!folderExist)
                {
                    Directory.CreateDirectory(pathExport);
                }

                object filename = pathExport + folderOut + "export laporan"+DateTime.Now.ToString()+".docx";
                //object filename = @"C:\Users\ITD\Desktop\tmp\temp1.docx";
                //doc.Save();

                doc.SaveAs2(ref filename);
                x = true; 

                application.Quit();


            }
            catch (Exception)
            {
                //return x; 
                throw;
            }

            return x;


        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            //options
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
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
    }
}

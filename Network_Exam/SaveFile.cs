using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    static class SaveFile 
    {
        public async static void Save(string link)
        {
            SaveFileDialog sFile = new SaveFileDialog();
            sFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (sFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    WebRequest request = WebRequest.Create(link);
                    WebResponse response = request.GetResponse();
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            await Task.Factory.StartNew(() =>
                            {
                                using (StreamWriter sw = new StreamWriter(sFile.FileName, true, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(reader.ReadToEnd() + "\n");
                                }
                            });
                        }
                        response.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

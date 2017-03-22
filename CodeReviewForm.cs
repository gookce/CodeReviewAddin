using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gtp.Framework.ControlLibrary;
using Gtp.Framework;
using System.IO;
using OfficeOpenXml;

namespace CodeReviewAddin
{
    public partial class CodeReviewForm : Gtp.Framework.ControlLibrary.Form
    {
        public CodeReviewForm()
        {
            InitializeComponent();
        }

        private void CodeReviewForm_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            List<Questions> quetions = new List<Questions>()
            {
                new Questions(){QuestionNo = 1 ,Question = "Soru 1 : Üretilen fonksiyon analiz dokümanıyla uyumlu mu?",QuestionRow=22},
                new Questions(){QuestionNo = 2 ,Question= "Soru 2 : Gereksiz değişken veya fonksiyon kullanılmamasına dikkat edilmiş mi?",QuestionRow=28},
                new Questions(){QuestionNo = 3 ,Question = "Soru 3 : Değişken isimlerinde camel casing metod ve class, parametre isimlerinde capital casing mi?",QuestionRow=29},
                new Questions(){QuestionNo = 4 ,Question = "Soru 4 : Commentler yeterli ve doğru mu?",QuestionRow=30},
                new Questions(){QuestionNo = 5 ,Question = "Soru 5 : Runtime hatası verebilecek null kontrolleri yapıldı mı (Özellikle yeni GetParameter veya parametreler için)?",QuestionRow=31},
                new Questions(){QuestionNo = 6 ,Question = "Soru 6 : Runtime hatalarını önleyecek uygun exception handling yapılmış mı?",QuestionRow=32},
                new Questions(){QuestionNo = 7 ,Question = "Soru 7 : Değişkenler işlevlerini yansıtacak şekilde yazılmış mı?",QuestionRow=33},
                new Questions(){QuestionNo = 8 ,Question = "Soru 8 : Reuseable fonksiyonlar kullanılmış mı?",QuestionRow=34},
                new Questions(){QuestionNo = 9 ,Question = "Soru 9 : Metodların satır sayısının 50 satırı geçmemesine dikkat edilmiş mi?",QuestionRow=35},
                new Questions(){QuestionNo = 10 ,Question = "Soru 10 : Bir kuruma özel yapıldıysa uygun şekilde parametreye bağlanmış mı?",QuestionRow=36},
                new Questions(){QuestionNo = 11 ,Question = "Soru 11 : Veritabanını etkiliyorsa veritabanını etkileyecek komutlar doğru ve standartlara uygun mu?",QuestionRow=37},
                new Questions(){QuestionNo = 12 ,Question = "Soru 12 : Transaction kullanımı doğru mu?",QuestionRow=38},
                new Questions(){QuestionNo = 13 ,Question= "Soru 13 : Doğru proje ve class kullanılmış mı? Gerekliyse yeni class açılmış mı?",QuestionRow=39},
                new Questions(){QuestionNo = 14 ,Question = "Soru 14 : Kuruma özel çalışmalarda kurum ismi yerine parametrik yapı kullanılmış mı?",QuestionRow=40},
                new Questions(){QuestionNo = 15 ,Question = "Soru 15 : Veritabanı tarafında değişiklik varsa db scripti eklenmiş mi?",QuestionRow=41},
                new Questions(){QuestionNo = 16 ,Question = "Soru 16 : Db scripti hata vermeden tekrar tekrar çalışabilecek halde yazılmış mı?",QuestionRow=42},
                new Questions(){QuestionNo = 17 ,Question = "Soru 17 : Gereksiz değişken veya fonksiyon kullanılmamasına dikkat edilmiş mi?",QuestionRow=48},
                new Questions(){QuestionNo = 18 ,Question = "Soru 18 : Gereksiz 'using ifadesi'kullanılmamasına dikkat edilmiş mi",QuestionRow=49},
                new Questions(){QuestionNo = 19 ,Question = "Soru 19 : Gereksiz type casting veya type-conversion  yapılmamasına dikkat edilmiş mi?",QuestionRow=50},
                new Questions(){QuestionNo = 20 ,Question = "Soru 20 : İçiçe döngülerden veya içiçe 'if' lerden kaçınılmış mı?",QuestionRow=51},
                new Questions(){QuestionNo = 21 ,Question = "Soru 21 : Veritabanı tablolarında kolon tipleri uygun mu?",QuestionRow=57},
                new Questions(){QuestionNo = 22 ,Question = "Soru 22 : Index, constraint, foreign key'ler uygun mu?",QuestionRow=58},
                new Questions(){QuestionNo = 23 ,Question = "Soru 23 : NOLOCK, joinler vb sql ifadeleri doğru şekilde kullanılmış mı?",QuestionRow=59},
                new Questions(){QuestionNo = 24 ,Question = "Soru 24 : Performans açısından değerlendirildi mi?",QuestionRow=60},
                new Questions(){QuestionNo = 25 ,Question = "Soru 25 : Yeterli comment var mı?",QuestionRow=66},
                new Questions(){QuestionNo = 26 ,Question = "Soru 26 : Loglama yapılıyor mu?",QuestionRow=67},
                new Questions(){QuestionNo = 27 ,Question = "Soru 27 : İlişkili fonksiyonlar tespit edilip task'ta belirtildi mi?",QuestionRow=73},
                
            };

            GtpDataSet gds = new GtpDataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("Soru", typeof(string));
            dt.Columns.Add("Evet", typeof(bool));
            dt.Columns.Add("Hayır", typeof(bool));
            dt.Columns.Add("Açıklama", typeof(string));

            for (int i = 0; i <= quetions.Count-1; i++)
            {
                dt.Rows.Add(quetions[i].Question);
            }

            gds.Tables.Add(dt);

            grQuestions.LoadGtpDataSet(gds);
        }

        public bool BeforeSaveControl()
        {
            string msg = String.Empty;
            bool result = true;

            for (int i = 0 ; i <= grQuestions.Controls.Count-1; i++)
            {
                if (grQuestions.Controls[i] != null)
                {
                    //throm exception
                }
            }

            if (msg != String.Empty)
            {
                GtpMsgBox(msg, "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = false;
            }

            else
            {
                result = true;
            }

            return result;
        }

        public void GenerateExcelFile(int no)
        {
            string currFile = @"C:\Users\gokced\Documents\Visual Studio 2012\Projects\CodeReview\CodeReviewAddin\CodeReview.xlsx";

            if (File.Exists(currFile))
            {
                using (ExcelPackage xlWorkbook = new ExcelPackage(new FileInfo(currFile)))
                {
                    ExcelWorksheet ws = xlWorkbook.Workbook.Worksheets[1];

                    for (int i = grQuestions.Controls.Count - 1; i >= 0; i--)
                    {
                        if (grQuestions.Controls[i] != null)
                        {
                            //write value into row/cell 
                        }
                    }

                    xlWorkbook.SaveAs(new FileInfo(@"\\gtpapp\Portal\CodeReview\" + "CodeReview_" + no.ToString() + ".xlsx"));
                }
            }
            else
            {
                GtpMsgBox("'CodeReview_99999.xlsx' dosyasını bulamadık...", "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int number = rd.Next(0, 100);

            if (BeforeSaveControl())
            {
                GenerateExcelFile(number);
                this.Close();
            }
        }
            
    }
}

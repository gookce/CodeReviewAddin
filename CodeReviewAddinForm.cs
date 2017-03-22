using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Gtp.Framework.ControlLibrary;
using OfficeOpenXml;
using System.Configuration;

namespace CodeReviewAddin
{
    public partial class CodeReviewAddinForm : Gtp.Framework.ControlLibrary.Form
    {

        public CodeReviewAddinForm()
        {
            InitializeComponent();
        }

        private void CodeReviewAddinForm_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            Connection.SetQuestions();

            for (int i = Connection.questions.Count-1; i >= 0; i--)
            {
                CodeReviewQuestion codeReviewQuestion = new CodeReviewQuestion();
                {
                    codeReviewQuestion.QuestionNo = Connection.questions[i].QuestionNo;
                    codeReviewQuestion.Question = Connection.questions[i].Question;
                    codeReviewQuestion.QuestionRow = Connection.questions[i].QuestionRow;
                    codeReviewQuestion.Dock = DockStyle.Top;
                };
                mainPanel.Controls.Add(codeReviewQuestion);
            }
        }

        public bool BeforeSaveControl()
        {
            string msg = String.Empty;
            bool result = true;

            for (int i = mainPanel.Controls.Count - 1; i >= 0; i--)
            {
                CodeReviewQuestion questionControl = mainPanel.Controls[i] as CodeReviewQuestion;
                if (questionControl != null)
                {
                    if (!questionControl.ControlRequiredFields(ref msg))
                    {
                        result = false;
                        break;
                    }
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
            string currFile = ConfigurationSettings.AppSettings["ExcelFile"];

            if (File.Exists(currFile))
            {
                using (ExcelPackage xlWorkbook = new ExcelPackage(new FileInfo(currFile)))
                {
                    ExcelWorksheet ws = xlWorkbook.Workbook.Worksheets[1];

                    for (int i = mainPanel.Controls.Count - 1; i >= 0; i--)
                    {
                        CodeReviewQuestion questionControl = mainPanel.Controls[i] as CodeReviewQuestion;

                        if (questionControl != null)
                        {
                            if (questionControl.IsYes)
                            {
                                ws.Cells[questionControl.QuestionRow, 4].Value = "X";
                            }

                            if (questionControl.IsNo)
                            {
                                ws.Cells[questionControl.QuestionRow, 5].Value = "X";
                            }

                            if (!String.IsNullOrEmpty(questionControl.Description))
                            {
                                ws.Cells[questionControl.QuestionRow, 6].Value = questionControl.Description;
                            }
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


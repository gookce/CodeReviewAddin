using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReviewAddin
{
    public partial class CodeReviewQuestion : UserControl
    {
        public CodeReviewQuestion()
        {
            InitializeComponent();
        }

        public bool IsYes
        {
            get { return rbYes.Checked; }
            set { rbYes.Checked = value; }
        }

        public bool IsNo
        {
            get { return rbNo.Checked; }
            set { rbNo.Checked = value; }
        }

        public int QuestionNo { get; set; }

        public string Question
        {
            get { return gbQuestion.Text; }
            set { gbQuestion.Text = value; }
        }

        public int QuestionRow { get; set; }

        public string Description
        {
            get { return txInfo.Text; }
            set { txInfo.Text = value; }
        }

        public bool ControlRequiredFields(ref string msg) 
        {
            if (rbNo.Checked && string.IsNullOrEmpty(txInfo.Text))
            {
                msg = "Soru " + QuestionNo + " için açıklama alanı boş bırakılamaz...";
                return false;
            }
            else
            {
                msg = String.Empty;
                return true;
            }
        }
    }
}

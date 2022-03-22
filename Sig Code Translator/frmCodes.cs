using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sig_Code_Translator
{
   
    public partial class frmCodes : Form
    {
        String[] sig = new string[] { "qd", "bid","tid","qid", "qod", "qam", "qpm","qhs","qwk","ac","pc","c","hs","prn","ud",
            "app","aa","gtt","tbsp","tsp","oz","gm" };

        String[] converted = new String[] { "one time daily", "two times daily","three times daily","four times daily", "every other day",
        "every morning","every evening","every day at bedtime", "every week","before meals","after meals","with","at bedtime","as needed",
        "as directed","apply","to affected area(s)","drop(s)","tablespoon","teaspoon","ounce","gram"};

        public frmCodes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCodes_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < sig.Length; i++)
            {
                textBox2.Text += sig[i] + " = " + converted[i] + Environment.NewLine;
                
            }
        }
    }
}

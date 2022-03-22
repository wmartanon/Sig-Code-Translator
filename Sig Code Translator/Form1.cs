namespace Sig_Code_Translator
{
    public partial class Form1 : Form
    {

        String[] sig = new string[] { "qd", "bid","tid","qid", "qod", "qam", "qpm","qhs","qwk","ac","pc","c","hs","prn","ud",
            "app","aa","gtt","tbsp","tsp","oz","gm" };

        String[] converted = new String[] { "one time daily", "two times daily","three times daily","four times daily", "every other day",
        "every morning","every evening","every day at bedtime", "every week","before meals","after meals","with","at bedtime","as needed",
        "as directed","apply","to affected area(s)","drop(s)","tablespoon","teaspoon","ounce","gram"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            string[] input = txtInput.Text.Split(' ');
            for(int i = 0; i < input.Length; i++)
            {
                for (int o = 0; o < sig.Length; o++)
                {
                    if (sig[o] == input[i].ToLower())
                    {
                        txtOutput.Text += converted[o] + " ";
                        break;
                    }
                    if(o == sig.Length-1)
                    {
                        txtOutput.Text += input[i] + " ";
                    }
                }
            }
            
        }

        private void codeSupportedCurrentlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodes codes = new frmCodes();
            codes.Show();
        }
    }
}
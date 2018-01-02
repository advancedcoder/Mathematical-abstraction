using System;
using System.Windows.Forms;
using SetSpace;

namespace WFAbstraction
{
    public partial class Set : Form
    {
        SetClass set1 = new SetClass();
        SetClass set2 = new SetClass();
        
        public Set()
        {
            InitializeComponent();
            gbOperationChose.Enabled = false;
        }

        private void btnChangeSets_Click(object sender, EventArgs e)
        {
            string SetString1 = textBox1.Text;
            string SetString2 = textBox2.Text;

            string[] SetStringArray = SetString1.Split(',', ' ');

            set1.Fill(SetStringArray);

            SetStringArray = SetString2.Split(',', ' ');
            set2.Fill(SetStringArray);

            gbOperationChose.Enabled = true;
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            GetButton(rbUnion, set1 + "U" + set2 + " = " + (set1 + set2));
            GetButton(rbIntersection, set1 + "П" + set2 + " = " + set1 * set2);
            GetButton(rbDifference, set1 + "\\" + set2 + " = " + (set1 - set2));
            GetButton(rbLess, set1 < set2 ? "Set1 is less than Set2" : "Set1 is not less than Set2");
            GetButton(rbMore, set1 > set2 ? "Set1 is more than Set2" : "Set1 is not more than Set2");
            GetButton(rbEqual, set1 == set2 ? "Set1 is equal to Set2" : "Set1 is not equal to Set2");
            GetButton(rbNotEqual, set1 != set2 ? "Set1 is not equal to Set2" : "Set1 is equal to Set2");
            GetButton(rbMoreOrEqual, set1 >= set2 ? "Set1 is more than or equal to Set2" : "Set1 is less than Set2");
            GetButton(rbLessOrEqual, set1 <= set2 ? "Set1 is less than or equal to Set2" : "Set1 is more than Set2");
            GetButton(rbSum, $"Sum of elements of Set1 = {(double)set1}\nSum of elements of Set2 = {(double)set2}");
            GetButton(rbDisplaySet, "Set1 = " + set1 + "\nSet2 = " + set2);
        }

        private void GetButton(RadioButton button, string message)
        {
            if(button.Checked)
            {
                MessageBox.Show(message, "Message");
            }
        }
    }
}

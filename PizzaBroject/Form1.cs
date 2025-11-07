using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBroject
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        float CalculateCrustPrise()
        {
            if(rbCrustType_Thick.Checked)
            {
                return Convert.ToSingle(rbCrustType_Thick.Tag);
            }
            else
            {
                return Convert.ToSingle(rbCrustType_Thin.Tag);
            }
        }

        float CalculateToppingsPrice()
        {


            float ToppingsTotalPrice = 0;

            if (chkExtraChess.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChess.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTommatos.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTommatos.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }



            return ToppingsTotalPrice;



        }

        float CalculatePriceOfSizeGroub()
        {
            if(rbSmall_Size.Checked)
            {
                return Convert.ToSingle(rbSmall_Size.Tag);
            }
            else if (rbMedium_Size.Checked)
            {
                return Convert.ToSingle(rbMedium_Size.Tag);
            }
            else 
            {
                return Convert.ToSingle(rbLarge_Size.Tag);
            }
        }

        float CalculateTotalPrice()
        {
            return CalculateCrustPrise() + CalculateToppingsPrice() + CalculatePriceOfSizeGroub(); 
        }


        void UpdateTotalPrise()
        {
            labPrise.Text = CalculateTotalPrice().ToString() + " $ ";
        }

        void UpdateCrust()
        {
            UpdateTotalPrise();

            if (rbCrustType_Thin.Checked)
                labCrustType.Text = rbCrustType_Thin.Text;
            if(rbCrustType_Thick.Checked)
                labCrustType.Text = rbCrustType_Thick.Text;

        }
        void UpdateSize()
        {
            UpdateTotalPrise();

            if(rbSmall_Size.Checked)
            {
                labSizeLabel.Text = rbSmall_Size.Text;
            }
            if(rbLarge_Size.Checked)
            {
                labSizeLabel.Text = rbLarge_Size.Text;
            }
            if(rbMedium_Size.Checked)
            {
                labSizeLabel.Text = rbMedium_Size.Text;
            }

        }

        private void UpdateToppingsSummary()
        {
            UpdateTotalPrise();

            List<string> selectedItems = new List<string>();

            if(chkExtraChess.Checked)
                selectedItems.Add("Extra Cheese");
            if (chkMushrooms.Checked)
                selectedItems.Add("Mushrooms");
            if (chkTommatos.Checked)
                selectedItems.Add("Tomatoes");
            if (chkOnion.Checked)
                selectedItems.Add("Onion");
            if (chkOlives.Checked)
                selectedItems.Add("Olives");
            if (chkGreenPeppers.Checked)
                selectedItems.Add("Green Peppers");

            //if items inside list > 0 show all elements by joining them in a string 
            //labToppingsSummary.Text = selectedItems.Count > 0 ? string.Join(",", selectedItems) : string.Empty; 

            string lineOfToppingsLabel = " ";

            for (int i = 0; i < selectedItems.Count; i++)
            {
                lineOfToppingsLabel += selectedItems[i].ToString();
                if ((i + 1) % 3 == 0)
                    lineOfToppingsLabel += "\n";

                //put {,} after every single elememt but test after the third elements we but  -1 because we start from i = 0
                if(i < selectedItems.Count - 1)
                    lineOfToppingsLabel+= ", ";
            }

            labToppingsSummary.Text = lineOfToppingsLabel;
        }

        private void CalculatePrice()
        {
            int Price = 0;

            if (chkExtraChess.Checked)
                Price += 5;
            if (chkMushrooms.Checked)
                Price += 5;
            if (chkTommatos.Checked)
                Price += 5;
            if (chkOnion.Checked)
                Price += 5;
            if (chkOlives.Checked)
                Price += 5;
            if (chkGreenPeppers.Checked)
                Price += 5;
            if(rbSmall_Size.Checked)
                Price += 10;
            if(rbMedium_Size.Checked)
                Price += 10;
            if(rbLarge_Size.Checked)
                Price += 10;
            if(rbCrustType_Thick.Checked)
                Price += 10;
            if(rbCrustType_Thin.Checked)
                Price += 10;
            if(rbToEat_Inside.Checked)
                Price += 10;
            if(rbToEat_OutSide.Checked)
                Price += 10;


            labPrise.Text = Price.ToString() + " $";
        }        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order" ,"Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Done Successfully","Done",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                btnOrder.Enabled = false;
                grbCrustType.Enabled = false;
                grbPlaseOfEating.Enabled = false;
                grbSize.Enabled = false;
                grbToppings.Enabled = false;
            }
        }

        void ResetForm()
        {

            //reset Groups
            grbSize.Enabled = true;
            grbToppings.Enabled = true;
            grbPlaseOfEating.Enabled = true;
            grbCrustType.Enabled = true;

            //reset Size
            rbMedium_Size.Checked = true;

            //reset Toppings.
            chkExtraChess.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTommatos.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbCrustType_Thin.Checked = true;

            //reset Where to Eat
            rbToEat_Inside.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           ResetForm();
        }

        private void rbMedium_Size_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbCrustType_Thin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbCrustType_Thick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbToEat_Inside_CheckedChanged(object sender, EventArgs e)
        {
            if(rbToEat_Inside.Checked)
                labWhereToEat.Text = rbToEat_Inside.Text;
        }

        private void rbToEat_OutSide_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToEat_OutSide.Checked)
                labWhereToEat.Text =rbToEat_OutSide.Text;
        }

        private void chkExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();
        }

        private void chkTommatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();
        }

        void UpdateForm()
        {
            UpdateSize();
            UpdateCrust();
            UpdateTotalPrise();
            UpdateToppingsSummary();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}

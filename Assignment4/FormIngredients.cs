using System;
using System.Windows.Forms;

/// <summary>
/// 
/// Author: Tomas Perers
/// Created Date:   2017-10-20
/// Last Updated: 2017-11-03
/// </summary>
namespace Assignment4
{
    public partial class FormIngredients : Form
    {
        Recepie m_recepie;
        int count;

        /// <summary>
        /// Constructor receives a recepie object to perform work on.
        /// Updates the recepie name in the title.
        /// </summary>
        /// <param name="recepie"></param>
        public FormIngredients(Recepie recepie)
        {
            InitializeComponent();
            m_recepie = recepie;
            count = m_recepie.GetCurrentNumOfIngredients();

            if (String.IsNullOrEmpty(recepie.Name))
                this.Text = "No recepie Name";
            else
                this.Text = recepie.Name + " Add ingredients";
            InitializeGUI();
        }

        /// <summary>
        /// Initialize the form.
        /// Add already added ingredients to the listBox and update the count.
        /// </summary>
        public void InitializeGUI()
        {
            if (m_recepie.IngredientsArray == null)
                m_recepie.IngredientsArray = new string[m_recepie.MaxNumOfIngredients];
            lstIngredients.Items.Clear();
            for (int i = 0; i < m_recepie.IngredientsArray.Length; i ++)
            {
                if (m_recepie.IngredientsArray[i] != String.Empty)
                {
                    lstIngredients.Items.Add(m_recepie.IngredientsArray[i]);
                }
            }
            lblNumOfIngredients.Text = count.ToString();
        }

        /// <summary>
        /// Add an ingredient from the textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            lstIngredients.Items.Add(txtAddIngredient.Text);
            txtAddIngredient.Text = "";
            count++;
            lblNumOfIngredients.Text = count.ToString();
        }

        /// <summary>
        /// Edit an ingredient in the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;
            lstIngredients.Items.RemoveAt(index);
            lstIngredients.Items.Insert(index, txtAddIngredient.Text);
            txtAddIngredient.Text = "";
        }

        /// <summary>
        /// Remove an ingredient from the list and update the count.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstIngredients.Items.RemoveAt(lstIngredients.SelectedIndex);
            txtAddIngredient.Text = "";
            count--;
            lblNumOfIngredients.Text = count.ToString();
        }

        /// <summary>
        /// Clean the list in m_recepie object and then add everything that is listed in lstIngredients.
        /// Exit the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Empty the list to add them all again so not to have doubles when editing.
            // TODO: Find a better solution :)
            m_recepie.RemoveAllIngredients();
            foreach (var item in lstIngredients.Items)
            {
                m_recepie.AddIngredients(item.ToString());
            }
            
        }
    }
}

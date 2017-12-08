using System;
using System.Windows.Forms;

/// <summary>
/// Main form for the program
/// Author: Tomas Perers
/// Created Date:   2017-10-20
/// Last Updated: 2017-11-03
/// </summary>
namespace Assignment4
{
    public partial class FormMain : Form
    {
        private const int maxNumOfIngredients = 20; // Max number of ingredients 
        private const int maxNumOfElements = 50; // Max number of recepies
        // Create objects of Recepie and RecepieManager to be used.
        Recepie currRecepie = new Recepie(maxNumOfIngredients); 
        RecepieManager recepieManager = new RecepieManager(maxNumOfElements);

        /// <summary>
        /// Default constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initalize the GUI
        /// </summary>
        private void InitializeGUI()
        {
            lstRecepies.Text = "";
            txtDescription.Text = "";
            txtNameOfRecepie.Text = "";
            foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
            {
                cboxCategory.Items.Add(category);
            }
            
        }
        /// <summary>
        /// Button acation for addign ingredients i.e. Opening a new form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            currRecepie.Name = txtNameOfRecepie.Text.Trim();
            currRecepie.Description = txtDescription.Text.Trim();
            FormIngredients dlg = new FormIngredients(currRecepie);
            DialogResult dlgResult = dlg.ShowDialog();
            
            if (dlgResult == DialogResult.OK)
            {
                if (currRecepie.GetCurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specefied!");
                }
            }
        }

        /// <summary>
        /// Update the GUI after actions.
        /// </summary>
        private void UpdateGUI()
        {
            string[] recepieListStrings = recepieManager.RecepieListToString();
            lstRecepies.Items.Clear();
            if (recepieListStrings != null)
            {
                lstRecepies.Items.AddRange(recepieListStrings);
            }
            txtNameOfRecepie.Text = "";
            InitializeOutput();
        }

        /// <summary>
        /// Fix the output 
        /// </summary>
        private void InitializeOutput()
        {
            txtDescription.Text = "";
            txtNameOfRecepie.Text = "";
            cboxCategory.SelectedIndex = -1;
        }

        /// <summary>
        /// Action for add recepie button. Add recepie to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecepie_Click(object sender, EventArgs e)
        {
            // If the user clicked a recepie and then choose to edit the text we need to create a new recepie first and make sure that the user will 
            // add ingredients.
            if (recepieManager.IsRecepieAdded(currRecepie))
            {
                MessageBox.Show("Copied selected recepie! Remeber to add ingredients");
                Recepie previousRecepie = currRecepie;
                currRecepie = new Recepie(maxNumOfIngredients);
            }

            FoodCategory theType = (FoodCategory)cboxCategory.SelectedIndex;
            cboxCategory.SelectedIndex = (int)FoodCategory.Meat;


            cboxCategory.SelectedIndex = (int)FoodCategory.Meat;

            if (!CheckInput())
                return;
            currRecepie.Category = (FoodCategory)cboxCategory.SelectedIndex;
            currRecepie.Name = txtNameOfRecepie.Text.Trim();
            currRecepie.Description = txtDescription.Text.Trim();

            if (!recepieManager.Add(currRecepie))
            {
                MessageBox.Show("No space to store recepie!");
            }

            UpdateGUI();
            currRecepie = new Recepie(maxNumOfIngredients);
            currRecepie.DefaultValue();
        }

        /// <summary>
        /// Validate input, make sure everything has been filled in. 
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            bool returnValue = false;
            if (cboxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("No category selected!");
                returnValue = false;
            }
            else if (txtDescription.Text.Length < 1)
            {
                MessageBox.Show("No description added");
                returnValue = false;
            }
            else if (txtNameOfRecepie.Text.Length < 1)
            {
                MessageBox.Show("No recepie name");
                returnValue = false;
            }
            else if (currRecepie.GetCurrentNumOfIngredients() == 0 )
            {
                MessageBox.Show("No ingredients added");
                returnValue = false;
            }
            else
                returnValue = true;

            return returnValue;
        }

        /// <summary>
        /// Action fo Edit recepie button. Changes the receie on selected index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRecepie_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            currRecepie.Category = (FoodCategory)cboxCategory.SelectedIndex;
            currRecepie.Name = txtNameOfRecepie.Text.Trim();
            currRecepie.Description = txtDescription.Text.Trim();

            if (!recepieManager.ChangeElement(lstRecepies.SelectedIndex, currRecepie))
            {
                MessageBox.Show("Failed to edit recepie");
            }

            UpdateGUI();
            currRecepie = new Recepie(maxNumOfElements);
            currRecepie.DefaultValue();
        }

        /// <summary>
        /// Delete recepie action, deletes the index from recepie manager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!recepieManager.DeleteElement(lstRecepies.SelectedIndex))
            {
                MessageBox.Show("Failed to delete recepie");
            }
            UpdateGUI();
            currRecepie = new Recepie(maxNumOfElements);
            currRecepie.DefaultValue();
        }

        /// <summary>
        /// Action for selecting a new item in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstRecepies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecepies.SelectedIndex > -1)
            {
                currRecepie = recepieManager.GetRecepie(lstRecepies.SelectedIndex);
                txtDescription.Text = currRecepie.Description;
                txtNameOfRecepie.Text = currRecepie.Name;
                cboxCategory.SelectedIndex = cboxCategory.FindStringExact(currRecepie.Category.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14Assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            //use the table adapter in this form to pass the textbox text into the method that will use the sql query to make the searchByName
            this.employeeTableAdapter.SearchByName(this.employeeDataSet.Employee, txtBoxEmployeeSearch.Text);

        }

        private void btnShowAllItems_Click(object sender, EventArgs e)
        {
            //show all the data of the table //like reset button
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}

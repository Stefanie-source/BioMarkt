using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioMarkt
{
    public partial class ProductScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stefa\Desktop\C#\ProNatur-Biomarkt Gmbh.mdf;Integrated Security=True;Connect Timeout=30");
        private int lastSelectedProductKey;
        public ProductScreen()
        {
            InitializeComponent();

            ShowProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }

            string query = string.Format("delete from Products where Id={0};", lastSelectedProductKey);
            ExecuteQuery(query);

            ClearAllFields();
            ShowProducts();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == ""
                || txtProductBrand.Text == ""
                || txtProductPrice.Text == ""
                || cmbProductCategory.Text == ""
                   || txtProductPrice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");

                return;
            }

            string productName = txtProductName.Text;
            string productBrand = txtProductBrand.Text;
            string productCategory = cmbProductCategory.Text;
            string productPrice = txtProductPrice.Text;

            string query = string.Format("INSERT INTO Products values ('{0}','{1}','{2}',{3})", productName, productBrand, productCategory, productPrice);

            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();
        }
        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }

            string productName = txtProductName.Text;
            string productBrand = txtProductBrand.Text;
            string productCategory = cmbProductCategory.Text;
            string productPrice = txtProductPrice.Text;

            string query = string.Format("update Products set Name='{0}', Brand='{1}', Category='{2}', Price='{3}' where Id={4}"
                , productName, productBrand, productCategory, productPrice, lastSelectedProductKey);

            ExecuteQuery(query);

            ShowProducts();
        }

        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void ShowProducts()
        {
            databaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];

            productsDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void ClearAllFields()
        {
            txtProductName.Text = "";
            txtProductBrand.Text = "";
            txtProductPrice.Text = "";
            cmbProductCategory.Text = "";
            cmbProductCategory.SelectedItem = null;
        }

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            cmbProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}
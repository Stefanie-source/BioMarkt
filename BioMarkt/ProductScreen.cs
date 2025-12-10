using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            if (string.IsNullOrWhiteSpace(txtProductName.Text)
                || string.IsNullOrWhiteSpace(txtProductBrand.Text)
                || string.IsNullOrWhiteSpace(txtProductPrice.Text)
                || string.IsNullOrWhiteSpace(cmbProductCategory.Text))
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");
                return;
            }

            if (!decimal.TryParse(txtProductPrice.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("de-DE"), out decimal priceValue))
            {
                MessageBox.Show("Preis ungültig.");
                return;
            }

            string sql = "INSERT INTO Products (Name, Brand, Category, Price) VALUES (@name, @brand, @category, @price)";
            using (var conn = new SqlConnection(databaseConnection.ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtProductName.Text;
                cmd.Parameters.Add("@brand", SqlDbType.NVarChar).Value = txtProductBrand.Text;
                cmd.Parameters.Add("@category", SqlDbType.NVarChar).Value = cmbProductCategory.Text;
                var p = cmd.Parameters.Add("@price", SqlDbType.Decimal);
                p.Value = priceValue;
                p.Precision = 18;
                p.Scale = 2;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            ClearAllFields();
            ShowProducts();
        }
        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0) { MessageBox.Show("Bitte wähle zuerst ein Produkt aus."); return; }

            if (!decimal.TryParse(txtProductPrice.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("de-DE"), out decimal priceValue))
            {
                MessageBox.Show("Preis ungültig."); return;
            }

            string sql = "UPDATE Products SET Name=@name, Brand=@brand, Category=@category, Price=@price WHERE Id=@id";
            using (var conn = new SqlConnection(databaseConnection.ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtProductName.Text;
                cmd.Parameters.Add("@brand", SqlDbType.NVarChar).Value = txtProductBrand.Text;
                cmd.Parameters.Add("@category", SqlDbType.NVarChar).Value = cmbProductCategory.Text;
                var p = cmd.Parameters.Add("@price", SqlDbType.Decimal);
                p.Value = priceValue;
                p.Precision = 18; p.Scale = 2;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = lastSelectedProductKey;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

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

        private void productsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                txtProductName.Text = productsDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtProductBrand.Text = productsDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                cmbProductCategory.Text = productsDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();

                // Preis als decimal lesen und in deutscher Form anzeigen (Komma)
                var priceObj = productsDGV.Rows[e.RowIndex].Cells[4].Value;
                if (priceObj != null && decimal.TryParse(priceObj.ToString(), out decimal priceValue))
                {
                    txtProductPrice.Text = priceValue.ToString("0.00", CultureInfo.GetCultureInfo("de-DE"));
                }
                else
                {
                    txtProductPrice.Text = "";
                }

                lastSelectedProductKey = Convert.ToInt32(productsDGV.Rows[e.RowIndex].Cells[0].Value);
            }
        }   
    }
}
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

using System.Globalization;


namespace BioMarkt
{
    public partial class BillScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stefa\Desktop\C#\ProNatur-Biomarkt Gmbh.mdf;Integrated Security=True;Connect Timeout=30");
        private int lastSelectedBillsKey;
        public BillScreen()
        {
            InitializeComponent();

            ShowBills();
        }
      

        private void btnBillSave_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtCustomer.Text)
        || string.IsNullOrWhiteSpace(cmbProductCategoryBills.Text)
        || string.IsNullOrWhiteSpace(txtBillsAmount.Text)
        || string.IsNullOrWhiteSpace(txtTotalPrice.Text))
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");
                return;
            }

            if (!int.TryParse(txtBillsAmount.Text, out int amount))
            {
                MessageBox.Show("Menge ungültig.");
                return;
            }

            if (!decimal.TryParse(txtTotalPrice.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("de-DE"), out decimal totalPrice))
            {
                MessageBox.Show("Gesamtbetrag ungültig.");
                return;
            }

            string sql = "INSERT INTO Bills (Customer, Products, Amount, [Total Price]) VALUES (@customer, @products, @amount, @price)";

            using (var conn = new SqlConnection(databaseConnection.ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@customer", SqlDbType.NVarChar).Value = txtCustomer.Text;
                cmd.Parameters.Add("@products", SqlDbType.NVarChar).Value = cmbProductCategoryBills.Text;
                cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
                var p = cmd.Parameters.Add("@price", SqlDbType.Decimal);
                p.Value = totalPrice;
                p.Precision = 18;
                p.Scale = 2;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            ClearAllFields();
            ShowBills();
        }

        private void btnBillEdit_Click(object sender, EventArgs e)
        {

            if (lastSelectedBillsKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Rechnung aus.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomer.Text)
                || string.IsNullOrWhiteSpace(cmbProductCategoryBills.Text)
                || string.IsNullOrWhiteSpace(txtBillsAmount.Text)
                || string.IsNullOrWhiteSpace(txtTotalPrice.Text))
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");
                return;
            }

            if (!int.TryParse(txtBillsAmount.Text, out int amount))
            {
                MessageBox.Show("Menge ungültig.");
                return;
            }

            if (!decimal.TryParse(txtTotalPrice.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("de-DE"), out decimal totalPrice))
            {
                MessageBox.Show("Gesamtbetrag ungültig.");
                return;
            }

            string sql = "UPDATE Bills SET Customer = @customer, Products = @products, Amount = @amount, [Total Price] = @price WHERE Id = @id";

            using (var conn = new SqlConnection(databaseConnection.ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@customer", SqlDbType.NVarChar).Value = txtCustomer.Text;
                cmd.Parameters.Add("@products", SqlDbType.NVarChar).Value = cmbProductCategoryBills.Text;
                cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
                var p = cmd.Parameters.Add("@price", SqlDbType.Decimal);
                p.Value = totalPrice;
                p.Precision = 18;
                p.Scale = 2;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = lastSelectedBillsKey;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            ClearAllFields();
            ShowBills();
        }

        private void btnBillClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnBillDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedBillsKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }

            string queryDelete = $"DELETE FROM Bills WHERE Id={lastSelectedBillsKey}";
            ExecuteQuery(queryDelete);
            ClearAllFields();
            ShowBills();
        }

        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void ShowBills()
        {
            databaseConnection.Open();

            string query = "select * from Bills";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            BillsDGV.DataSource = dataSet.Tables[0];

            BillsDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void ClearAllFields()
        {
            txtCustomer.Text = "";
            cmbProductCategoryBills.Text = "";
            cmbProductCategoryBills.SelectedItem = null;
            txtBillsAmount.Text = "";
            txtTotalPrice.Text = "";
            
            
           
        }
        private void BillsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // besser Rows[e.RowIndex] statt SelectedRows
            lastSelectedBillsKey = Convert.ToInt32(BillsDGV.Rows[e.RowIndex].Cells[0].Value);
            txtCustomer.Text = BillsDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
            cmbProductCategoryBills.Text = BillsDGV.Rows[e.RowIndex].Cells[2].Value?.ToString(); // Products
            txtBillsAmount.Text = BillsDGV.Rows[e.RowIndex].Cells[3].Value?.ToString(); // Amount
            txtTotalPrice.Text = Convert.ToDecimal(BillsDGV.Rows[e.RowIndex].Cells[4].Value)
                                    .ToString("0.00", CultureInfo.GetCultureInfo("de-DE")); // Total Price

        }
    }
}

using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirebirdEntityFrameworkDemo
{
    class ProductDal
    {
        //SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");


        FbConnection connection;

        public ProductDal()
        {
            string connectionString = new FbConnectionStringBuilder
            {
                Database = @"data\db.fdb",
                ServerType = FbServerType.Embedded,
                UserID = "SYSDBA",
                Password = "masterkey",
                ClientLibrary = @"lib\fbclient.dll"
            }.ToString();

            this.connection = new FbConnection(connectionString);

            //CreateDatabase();
        }

        private void CreateDatabase()
        {
            FbConnectionStringBuilder builder = new FbConnectionStringBuilder();
            //builder.DataSource = "COMPUTER_WITH_DATABASE";
            builder.UserID = "SYSDBA";
            builder.Password = "masterkey";
            builder.Database = @"database.fdb";
            builder.ServerType = FbServerType.Embedded;
            builder.ClientLibrary = @"lib\fbclient.dll";
            builder.Charset = FbCharset.Utf8.ToString();

            this.connection = new FbConnection(builder.ConnectionString);

            if (!File.Exists(builder.Database))
            {
                FbConnection.CreateDatabase(builder.ConnectionString);
            }
        }

        public List<Product> GetAll()
        {
            ConnectionControl();

            FbCommand command = new FbCommand("select * from Products", connection);
            FbDataReader reader = command.ExecuteReader();


            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            connection.Close();

            return products;
        }
        public void Add(Product product)
        {
            ConnectionControl();
            FbCommand command = new FbCommand("insert into Products (NAME,UNITPRICE,STOCKAMOUNT) values(@name,@unitPrice,@stockAmount)", connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            FbCommand command = new FbCommand("update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            FbCommand command = new FbCommand("delete from Products where Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            connection.Close();
        }



        public DataTable GetAll2()
        {
            ConnectionControl();
            FbCommand command = new FbCommand("select * from Products", connection);
            FbDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            connection.Close();

            return dataTable;
        }

        private void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }
        }
    }
}

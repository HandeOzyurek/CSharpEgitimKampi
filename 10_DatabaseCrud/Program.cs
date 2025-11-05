using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> create,read,uptade,delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection= new SqlConnection("Data Source=MSI;initial catalog=EgitimKampiDb;integrated security=true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert Into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //Console.Write("Kategori başarıyla eklendi");
            //connection.Close();
            #endregion

            #region Ürün Ekleme İşlemi

            //string ProductName;
            //decimal ProductPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //ProductName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //ProductPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=MSI; initial catalog=EgitimKampiDb;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@ProductName,@ProductPrice,@ProductStatus)", connection);
            //command.Parameters.AddWithValue("@ProductName", ProductName);
            //command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
            //command.Parameters.AddWithValue("@ProductStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data source=MSI; initial catalog=EgitimKampiDb;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data source=MSI; initial catalog=EgitimKampiDb;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();


            //connection.Close();
            //Console.WriteLine("Silme işlemi tamamlandı");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int ProductId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string ProductName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal ProductPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data source=MSI; initial catalog=EgitimKampiDb;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@ProductName, ProductPrice=@ProductPrice where ProductId=@ProductId", connection);
            //command.Parameters.AddWithValue("@ProductName", ProductName);
            //command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
            //command.Parameters.AddWithValue("@ProductId", ProductId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı");

            #endregion

        }
    }
}

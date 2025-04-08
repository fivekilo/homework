using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderUI
{
    internal class DataBase
    {
        private static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=password;database=my_db;charset=utf8");
            connection.Open();
            return connection;
        }
        public List<Order> LoadOrders()
        {
            using(MySqlConnection connection = GetConnection())
            {
                string stm = "SELECT * FROM orders";
                using(MySqlCommand cmd=new MySqlCommand(stm,connection))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Order> orders = new List<Order>();
                        while(reader.Read())
                        {
                            int ID=reader.GetInt32(0);
                            string customer=reader.GetString(1);
                            string[] goods=reader.GetString(2).Split();
                            Dictionary<string, int> goods_price = new Dictionary<string, int>();
                            for (int i = 0; i < goods.Length / 2; i++)
                            {
                                goods_price[goods[2 * i]] = int.Parse(goods[2 * i + 1]);
                            }
                            Order o = new Order();
                            o.ID = ID;
                            o.Details.customer = customer;
                            o.Details.goods_price = goods_price;
                            orders.Add(o);
                        }
                        return orders;
                    }
                }
            }
        }
        public void AddOrder(Order o)
        {
            using(MySqlConnection conn = GetConnection())
            {
                string stm = "INSERT INTO orders (ID,customer,goods_price) VALUES(@id,@customer,@goods)";
                using (MySqlCommand cmd = new MySqlCommand(stm, conn))
                {
                    cmd.Parameters.AddWithValue("@id", o.ID);
                    cmd.Parameters.AddWithValue("@customer",o.Details.customer);
                    cmd.Parameters.AddWithValue("@goods", o.Details.goods);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DelOrder(int ID)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string stm = "DELETE FROM orders where ID=@id";
                using (MySqlCommand cmd = new MySqlCommand(stm, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpDateOrder(Order o)
        {
            using( MySqlConnection conn = GetConnection())
            {
                string stm = "UPDATE orders SET customer=@customer,goods_price=@goods WHERE ID=@id";
                using(MySqlCommand cmd = new MySqlCommand( stm, conn))
                {
                    cmd.Parameters.AddWithValue("@id", o.ID);
                    cmd.Parameters.AddWithValue("@customer", o.Details.customer);
                    cmd.Parameters.AddWithValue("@goods", o.Details.goods);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

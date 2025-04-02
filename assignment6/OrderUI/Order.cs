using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderUI
{
    public class Order
    {
        public int ID { get; set; }
        public OrderDetails Details = new OrderDetails();
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Order other = obj as Order;
            if (other == null) return false;
            return (other.ID == this.ID && other.Details == this.Details);
        }
        public override string ToString()
        {
            return $"订单号:{ID}\n" + Details.ToString();
        }
    }

    public class OrderDetails
    {
        public Dictionary<string, int> goods_price = new Dictionary<string, int>();
        public string customer { get; set; }
        public string goods { get
            {
                string s = "";
                foreach (var pair in goods_price)
                {
                    s += $"{pair.Key} {pair.Value}\n";
                }
                return s;
            }
        }
        public int price
        {
            get
            {
                int sum = 0;
                foreach (var x in goods_price.Values)
                {
                    sum += x;
                }
                return sum;
            }
        }
        public override string ToString()
        {
            string s = $"客户:{customer}\n";
            foreach (var pair in goods_price)
            {
                s += $"{pair.Key} {pair.Value}\n";
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            OrderDetails other = obj as OrderDetails;
            if (other == null) return false;
            return (other.goods_price == this.goods_price && other.customer == this.customer);
        }
    }

    public class OrderService
    {
        bool flag = true;
        private List<Order> query = new List<Order>();
        private List<Order> orders = new List<Order>();
        public List<Order> Orders { get { return flag?orders:query; } }
        public void AddOrder(Order o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("订单不能为空");
            }
            else if (orders.Contains(o) || orders.Any(x => x.ID == o.ID))//不能有相同订单号
            {
                throw new ArgumentException("该订单已存在");
            }
            else
            {
                orders.Add(o);
                flag = true;
                return;
            }
        }
        public void RemoveOrder(int ID)
        {
            if (!orders.Any(x => x.ID == ID))
            {
                throw new ArgumentException("订单不存在");
            }
            else
            {
                Order o = orders.First(x => x.ID == ID);
                orders.Remove(o);
                flag = true;
            }
        }
        public void ModifyOrder(Order o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("订单不能为空");
            }
            if (!orders.Any(x => x.ID == o.ID))
            {
                throw new ArgumentException("订单不存在");
            }
            else
            {
                RemoveOrder(o.ID);
                AddOrder(o);
                flag = true;
            }
        }
        public List<Order> QuerybyID(int ID)
        {
            if (!orders.Any(x => x.ID == ID))
            {
                throw new ArgumentException("订单不存在");
            }
            else
            {
                Order o = orders.First(x => x.ID == ID);
                List<Order> list = new List<Order>();
                list.Add(o);
                flag = false;
                query = list;
                return list;
            }
        }
        public List<Order> QuerybyName(string Name)
        {
            var list = orders.Where(x => x.Details.goods_price.Any(y => y.Key == Name))
                .OrderBy(x => x.Details.price).ToList();
            if (query == null)
            {
                throw new ArgumentException("未找到包含该商品的订单");
            }
            flag = false;
            query = list;
            return query;
        }
        public List<Order> QuerybyCustomer(string Name)
        {
            var list = orders.Where(x => x.Details.customer == Name)
                .OrderBy(x => x.Details.price).ToList();
            if (query == null)
            {
                throw new ArgumentException("未找到该顾客的订单");
            }
            flag = false;
            query = list;
            return query;
        }
        public void QueryAll()
        {
            flag = true;
        }
        public void SortOrders(Comparison<Order> comparison = null)
        {
            if (comparison == null)
            {
                orders.Sort((x, y) => x.ID.CompareTo(y.ID));
            }
            else
            {
                orders.Sort(comparison);
            }
        }
    }
}

namespace order
{
    public class Order
    {
        public int ID { get; set; }
        public OrderDetails Details=new OrderDetails();
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Order other = obj as Order;
            if (other == null) return false;
            return (other.ID == this.ID && other.Details == this.Details);
        }
        public override string ToString()
        {
            return $"订单号:{ID}\n"+Details.ToString();
        }
    }

    public class OrderDetails
    {
        public Dictionary<string, int> goods_price=new Dictionary<string, int>();
        public string customer="";
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
            foreach(var pair in goods_price)
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
        private List<Order> orders=new List<Order>();
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
                return list;
            }
        }
        public List<Order> QuerybyName(string Name)
        {
            var query = orders.Where(x => x.Details.goods_price.Any(y => y.Key == Name))
                .OrderBy(x => x.Details.price).ToList();
            if (query == null)
            {
                throw new ArgumentException("未找到包含该商品的订单");
            }
            return query;
        }
        public List<Order> QuerybyCustomer(string Name)
        {
            var query = orders.Where(x => x.Details.customer == Name)
                .OrderBy(x => x.Details.price).ToList();
            if (query == null)
            {
                throw new ArgumentException("未找到该顾客的订单");
            }
            return query;
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
    public class Program
    {
        static Order inputOrder()
        {
            Order o = new Order();
            o.Details=new OrderDetails();
            o.Details.goods_price = new Dictionary<string, int>();
            Console.WriteLine("请输入订单号");
            int ID = int.Parse(Console.ReadLine());
            o.ID = ID;
            Console.WriteLine("请输入用户名");
            string customer = Console.ReadLine();
            o.Details.customer = customer;
            Console.WriteLine("请输入商品名");
            string[] goods = Console.ReadLine().Split();
            Console.WriteLine("请对应价格");
            string[] prices= Console.ReadLine().Split();
            for (int i = 0; i < goods.Length; i++)
            {
                o.Details.goods_price.Add(goods[i], int.Parse(prices[i]));
            }
            return o;
        }
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            while (true)
            {
                Console.WriteLine("1. 添加订单\r\n2. 删除订单\r\n3. 修改订单\r\n4. 查询订单\r\n   4.1 按订单号查询\r\n   4.2 按商品名称查询\r\n   4.3 按客户查询\r\n5. 显示所有订单\r\n6. 退出");
                string input=Console.ReadLine();
                try
                {
                    Order o=new Order();
                    int id=0;
                    string Name = "";
                    List<Order>list=new List<Order>();
                    switch (input)
                    {
                        case "1":
                            o = inputOrder();
                            os.AddOrder(o);
                            break;
                        case "2":
                            Console.WriteLine("请输入订单号");
                            id = int.Parse(Console.ReadLine());
                            os.RemoveOrder(id);
                            break;
                        case "3":
                            o=inputOrder();
                            os.ModifyOrder(o);
                            break;
                        case "4.1":
                            Console.WriteLine("请输入订单号");
                            id = int.Parse(Console.ReadLine());
                            list=os.QuerybyID(id);
                            list.ForEach(x => Console.WriteLine(x));
                            break;
                        case "4.2":
                            Console.WriteLine("请输入商品名");
                            Name=Console.ReadLine();
                            list=os.QuerybyName(Name);
                            list.ForEach(x => Console.WriteLine(x));
                            break;
                        case "4.3":
                            Console.WriteLine("请输入客户名");
                            Name = Console.ReadLine();
                            list=os.QuerybyCustomer(Name);
                            list.ForEach(x => Console.WriteLine(x));
                            break;
                        case "6":
                            return;
                        default: 
                            return;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
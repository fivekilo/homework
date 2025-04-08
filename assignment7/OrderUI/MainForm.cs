namespace OrderUI
{
    public partial class MainForm : Form
    {
        private int index = 0;
        private OrderService orderService = new OrderService();
        private BindingSource orderB = new BindingSource();
        private BindingSource stateB = new BindingSource();
        private BindingSource detailsB = new BindingSource();
        private DataBase dataBase = new DataBase();
        private string state
        {
            get { return $"{index + 1}/{orderService.Orders.Count}"; }
        }
        public MainForm()
        {
            InitializeComponent();

            orderB.DataSource = typeof(Order);
            ID.DataBindings.Add("Text", orderB, "ID");
            detailsB.DataSource = typeof(OrderDetails);
            Customer.DataBindings.Add("Text", detailsB, "customer");
            Goods.DataBindings.Add("Text", detailsB, "goods");

            stateB.DataSource = typeof(string);
            stateB.Add("0/0");
            StateLabel.DataBindings.Add("Text", stateB, "");

            //加载订单
            dataBase.LoadOrders().ForEach(o => { orderService.AddOrder(o); });
            update();
        }
        private void update()
        {
            if (orderService.Orders.Count == 0)
            {
                orderB.DataSource = new Order();
                detailsB.DataSource = new OrderDetails();
                stateB[0] = "0/0";
            }
            else
            {
                orderB.DataSource = orderService.Orders[index];
                detailsB.DataSource = orderService.Orders[index].Details;
                stateB[0] = state;
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (index - 1 < 0)
            {
                MessageBox.Show("超出范围");
            }
            else
            {
                index--;
                update();
            }
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (index + 1 >= orderService.Orders.Count)
            {
                MessageBox.Show("超出范围");
            }
            else
            {
                index++;
                update();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Dialog D = new Dialog();
            D.Confirm += orderService.AddOrder;
            D.Confirm += dataBase.AddOrder;
            D.ShowDialog();
            index = 0;
            update();
        }
        private void RemoveBtn_Click(Object sender, EventArgs e)
        {
            string Input = Microsoft.VisualBasic.Interaction.InputBox("请输入删除的订单ID:","删除订单","");
            try
            {
                int.TryParse(Input, out int num);
                orderService.RemoveOrder(num);
                dataBase.DelOrder(num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            index = 0;
            update();
        }
        private void ModifyBtn_Click(Object obj, EventArgs e)
        {
            Dialog D = new Dialog();
            D.Confirm += orderService.ModifyOrder;
            D.Confirm += dataBase.UpDateOrder;
            D.ShowDialog();
            index = 0;
            update();
        }
        private void QueryBtn_Click(Object sender, EventArgs e)
        {
            int flag = comboBox1.SelectedIndex;
            string Input;
            switch (flag)
            {
                case 0:
                    orderService.QueryAll();
                    index = 0;
                    update(); 
                    break;
                case 1:
                    Input = Microsoft.VisualBasic.Interaction.InputBox("请输入查询的订单ID:","查询订单","");
                    try
                    {
                        int.TryParse(Input, out int num);
                        orderService.QuerybyID(num);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    index = 0;
                    update();
                    break;
                case 2:
                    Input = Microsoft.VisualBasic.Interaction.InputBox("请输入查询的客户名:", "查询订单", "");
                    try
                    {
                        orderService.QuerybyCustomer(Input);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    index = 0;
                    update();
                    break;
                case 3:
                    Input = Microsoft.VisualBasic.Interaction.InputBox("请输入查询的商品名:", "查询订单", "");
                    try
                    {
                        orderService.QuerybyName(Input);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    index = 0;
                    update();
                    break;
            }
        }
    }
}
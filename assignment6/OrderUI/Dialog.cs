using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderUI
{
    public partial class Dialog : Form
    {
        public event Action<Order> Confirm;
        public event Action AddCancel;
        public Dialog()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ID.Text == null)
                {
                    throw new Exception("ID不可为空");
                }
                int ID = int.Parse(this.ID.Text);
                if (this.Customer.Text == null)
                {
                    throw new Exception("用户不可为空");
                }
                string customer = this.Customer.Text;
                if (this.Goods.Text == null)
                {
                    throw new Exception("商品列表不可为空");
                }
                string[] goods = this.Goods.Text.Split();
                if (goods.Length % 2 != 0)
                {
                    throw new Exception("商品列表输入格式不正确");
                }
                Dictionary<string, int> goods_price = new Dictionary<string, int>();
                for (int i = 0; i < goods.Length / 2; i++)
                {
                    goods_price[goods[2 * i]] = int.Parse(goods[2 * i + 1]);
                }
                Order o = new Order();
                o.ID = ID;
                o.Details.customer = customer;
                o.Details.goods_price = goods_price;
                Confirm?.Invoke(o);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误：{ex.Message}");
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

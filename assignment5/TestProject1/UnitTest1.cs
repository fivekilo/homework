namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOrderEqual()
        {
            order.Order o1=new order.Order();
            order.Order o2 = new order.Order();
            o1.ID = 1;
            o1.Details.customer = "Li";
            o1.Details.goods_price.Add("�ֻ�", 600);
            o2.ID = 2;
            o2.Details.customer = "Zhang";
            o2.Details.goods_price.Add("ѩ��", 4);
            Assert.AreEqual(o1,o1);
            Assert.AreEqual(o2,o1);
        }
    }
}
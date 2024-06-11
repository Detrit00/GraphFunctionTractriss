namespace WinFormsKR3.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Tractrix_1_07_returned_0181()
        {
            double a = 1;
            double y = 0.7;
            double expected = 0.181;
            double actual = TractrixClass.EquationTractrix(a, y);
            Assert.AreEqual(expected, actual);
        }

    }
}
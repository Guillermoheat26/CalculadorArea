using GeometricShapes;

namespace CalculadorAreaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            
            double radius = 5;
            Circle circle = new Circle(radius);

           
            double result = circle.CalculateArea();

            
            double expected = Math.PI * radius * radius;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RectangleAreaTest()
        {
            
            Rectangle rectangle = new Rectangle(2.0, 3.0);
            double expectedArea = 2.0 * 3.0;

            
            double actualArea = rectangle.CalculateArea();

            
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
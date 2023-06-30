using Triangle.Services;

namespace TriangleTests.Tests
{
    public class TriangleServiceTesting
    {
        [Fact]
        public void SimpleArray_Ok()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9235 },
                new int[] {9096,637 },
                new int[] {973,3269,7039 }
            } ;


            // Act
            int maxTotal = triangleService.ComputeMaxTotal(triangle);

            // Assert
            Assert.Equal(21600, maxTotal);
        }

        [Fact]
        public void OneElementArray_Ok()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9235 }
            };

            // Act
            int maxTotal = triangleService.ComputeMaxTotal(triangle);

            // Assert
            Assert.Equal(9235, maxTotal);
        }

        [Fact]
        public void EmptyElementArray_Ok()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]{};

            // Act
            int maxTotal = triangleService.ComputeMaxTotal(triangle);

            // Assert
            Assert.Equal(0, maxTotal);
        }
    }
}
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

        [Fact]
        public void ArrayWithResultAllInFirstColum_Ok()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9235 },
                new int[] {9096,6370 },
                new int[] {8973,3269,7039 },
                new int[] {6973,3269,7039, 1050 },
                new int[] {1973,1326,1703, 1050, 3500 }
            };


            // Act
            int maxTotal = triangleService.ComputeMaxTotal(triangle);

            // Assert
            Assert.Equal(36250, maxTotal);
        }


        [Fact]
        public void ArrayWithResultAllInLastColum_Ok()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9235 },
                new int[] {9096,6370 },
                new int[] {8973,3269,7039 },
                new int[] {6973,3269,7039, 4050 },
                new int[] {1973,1326,1703, 1050, 3500 },
                new int[] {3973,2326,2703, 1173, 1526, 7555 },
                new int[] {1521,2454,3296, 2050, 2500, 1555, 6655 }
            };


            // Act
            int maxTotal = triangleService.ComputeMaxTotal(triangle);

            // Assert
            Assert.Equal(44404, maxTotal);
        }

        [Fact]
        public void ArrayWithResultAllInLastColumExceptLast_Ok()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9235 },
                new int[] {9096,6370 },
                new int[] {8973,3269,7039 },
                new int[] {6973,3269,7039, 4050 },
                new int[] {1973,1326,1703, 1050, 3500 },
                new int[] {3973,2326,2703, 1173, 1526, 7555 },
                new int[] {1521,2454,3296, 2050, 7501, 1555, 6655 }
            };


            // Act
            int maxTotal = triangleService.ComputeMaxTotal(triangle);

            // Assert
            Assert.Equal(45250, maxTotal);
        }

        [Fact]
        public void InvalidTriangle1_ShouldFail()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9096,6370 },
                new int[] {8973,3269,7039 },
                new int[] {6973,3269,7039, 4050 },
                new int[] {1973,1326,1703, 1050, 3500 },
                new int[] {3973,2326,2703, 1173, 1526, 7555 },
                new int[] {1521,2454,3296, 2050, 7501, 1555, 6655 }
            };


            // Act
            Action act = () => triangleService.ComputeMaxTotal(triangle);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Invalid triangle structure", exception.Message);
        }

        [Fact]
        public void InvalidTriangle2_ShouldFail()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9096 },
                new int[] {9096,6370 },
                new int[] {8973,3269,7039 },
                new int[] {6973,3269,7039, 4050 },
                new int[] {6973,3269,7039, 4050 },
                new int[] {1973,1326,1703, 1050, 3500 },
                new int[] {3973,2326,2703, 1173, 1526, 7555 },
                new int[] {1521,2454,3296, 2050, 7501, 1555, 6655 }
            };


            // Act
            Action act = () => triangleService.ComputeMaxTotal(triangle);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Invalid triangle structure", exception.Message);
        }

        [Fact]
        public void InvalidTriangle3_ShouldFail()
        {
            // Arrange
            var triangleService = new TriangleService();
            var triangle = new int[][]
            {
                new int[] {9096 },
                new int[] {9096,6370 },
                new int[] {8973,3269,7039 },
                new int[] {1521,2454,3296, 2050, 7501, 1555, 6655 },
                new int[] {6973,3269,7039, 4050 },
                new int[] {1973,1326,1703, 1050, 3500 },
                new int[] {3973,2326,2703, 1173, 1526, 7555 },
            };


            // Act
            Action act = ()=> triangleService.ComputeMaxTotal(triangle);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Invalid triangle structure", exception.Message);
        }
    }
}
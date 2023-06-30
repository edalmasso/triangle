namespace Triangle.Services
{
    public class TriangleService: ITriangleService
    {
        /// <summary>
        /// It will compute each node weight top down based on the previous row on + - 1 column and update the value in the same triangle array
        /// </summary>
        /// <returns></returns>
        public int ComputeMaxTotal(int[][]? triangle = null)
        {
            if (triangle == null)
            {
                triangle = LoadTriangleFromFile();
            }

            // If the triangle is empty return 0
            if(triangle.Length == 0)
            {
                return 0;
            }

            // Go top down from row 1 as 0 will never change
            for (int row = 1; row < triangle.Length; row++)
            {
                for (
                    int col = 0; col < triangle[row].Length; col++)
                {
                    int currentValue = triangle[row][col];

                    int previousCol = 0;
                    if (col - 1 >= 0)
                        previousCol = triangle[row - 1][col - 1];

                    int currentCol = 0;
                    if (triangle[row - 1].Length > col)
                        currentCol = triangle[row - 1][col];

                    int nextCol = 0;
                    if (triangle[row - 1].Length > col + 1)
                        nextCol = triangle[row - 1][col + 1];

                    // get the highest value from the previous row
                    int max = Math.Max(previousCol, Math.Max(currentCol, nextCol));

                    // Update the current node with the max value
                    triangle[row][col] = currentValue + max;
                }
            }
            // Return the highest value in the last row
            return triangle[triangle.Length - 1].Max();
        }

        private int[][] LoadTriangleFromFile()
        {
            int[][] triangle;
            // Assuming the triangle.txt file is in the same directory as the code
            string filePath = "Assets/Triangle.txt";

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Initialize the array to store the triangle
            triangle = new int[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                // Split each line into numbers
                string[] numbers = lines[i].Trim().Split(' ');

                // Convert the numbers to integers and store them in the current row of the triangle
                triangle[i] = Array.ConvertAll(numbers, int.Parse);
            }
            return triangle;
        }
    }
}

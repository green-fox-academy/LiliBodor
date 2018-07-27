using Ma3x.Models;
using Ma3x.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ma3x.Services
{
    public class MatrixService
    {
        private MatrixRepository matrixRepository;

        public MatrixService(MatrixRepository matrixRepository)
        {
            this.matrixRepository = matrixRepository;
        }

        public List<Matrix> GetMatrices()
        {
            return matrixRepository.GetMatrices();
        }

        private static List<List<string>> GetTheMatrixNumbers(string input)
        {
            List<List<string>> rows = new List<List<string>>();
            string[] matrixRows = input.Split("\n");
            foreach (string rawNumbers in matrixRows)
            {
                string[] matrixNumbers = rawNumbers.Split(" ");
                try
                {
                    List<string> rowsNumbers = new List<string>();
                    foreach (var theActualNumbers in matrixNumbers)
                    {
                        rowsNumbers.Add(theActualNumbers);
                    }
                    rows.Add(new List<string>(rowsNumbers));
                }
                catch (FormatException)
                {
                    Console.WriteLine("This format is not acceptable");
                }
            }
            return rows;
        }

        public static bool IsSquare(List<List<string>> rows)
        {
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows.Count != rows[i].Count)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsIncreasing(List<List<string>> rows)
        {
            if (IsSquare(rows))
            {
                for (int i = 1; i < rows.Count; i++)
                {
                    for (int j = 0; j < rows.Count; j++)
                    {
                        if (Int32.Parse(rows[i - 1][j]) >= Int32.Parse(rows[i][j]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public string AddNewMatrix(string inputMatrix)
        {
            List<List<string>> goodMatrices = GetTheMatrixNumbers(inputMatrix);
            if (!IsIncreasing(goodMatrices))
            {
                return "This matrix is not increasing! Please try again!";
            }
            else if (!IsSquare(goodMatrices) && !IsIncreasing(goodMatrices))
            {
                return "This matrix is not square and also not increasing! Please try again!";
            }
            matrixRepository.AddNewMatrix(new Matrix() { MatrixNumbers = inputMatrix, CurrentDateTime = DateTime.Now });
            return "The matrix is increasing!";
        }
    }
}

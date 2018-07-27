using Ma3x.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ma3x.Repositories
{
    public class MatrixRepository
    {
        private MatrixDbContext matrixDbContext;
        private List<List<string>> matrix;

        public object MatrixDbContext { get; internal set; }

        public MatrixRepository(MatrixDbContext matrixDbContext)
        {
            this.matrixDbContext = matrixDbContext;
            matrix = new List<List<string>>();
        }

        public List<Matrix> GetMatrices()
        {
            return matrixDbContext.Matrices.ToList();
        }

        public void AddNewMatrix(Matrix matrix)
        {
            matrixDbContext.Matrices.Add(matrix);
            matrixDbContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3x.Models
{
    public class Matrix
    {
        public int Id { get; set; }
        public string MatrixNumbers { get; set; }
        public DateTime CurrentDateTime { get; set; }

        public Matrix()
        {
            CurrentDateTime = DateTime.Now;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public interface IMatrix<T> : IEnumerable<T>
    {
        int MatrixAddNumberOfRows {set; }
        int MatrixAddNumberOfColumns { set; }
        int ExtendRankOfTheMatrix { set; }

        //Arr 
    }
}

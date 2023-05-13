using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> // IResult'ın içindeki Success ve Message'yi burada da kullanabilmek için Result'ı miras aldık.
    {
        public DataResult(T data, bool success, string message) : base(success, message) // base = Result
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success) // base = Result
        {
            Data = data;
        }

        public DataResult(T data) : base(true) // base = Result
        {
            Data = data;
        }
        public DataResult() : base(true) // base = Result
        {
        }
        public T Data { get; }
    }

}

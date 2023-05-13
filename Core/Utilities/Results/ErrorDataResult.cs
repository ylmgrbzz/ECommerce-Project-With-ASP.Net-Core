using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult
    {
        public class ErrorDataResult<T> : DataResult<T>
        {
            //public ErrorDataResult() : base(false) // base = Result
            //{
            //}
            public ErrorDataResult(T data, string message) : base(data, false, message) // base = Result
            {
                //Data = data;
            }
            public ErrorDataResult(T data) : base(data, false) // base = Result
            {
                //Data = data;
            }
            public ErrorDataResult(string message) : base(default, false, message) // base = Result
            {
            }
            public ErrorDataResult() : base(default, false) // base = Result
            {
            }
            //public object Data { get; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //public SuccessDataResult() : base(true) // base = Result
        //{
        //}
        public SuccessDataResult(T data, string message) : base(data, true, message) // base = Result
        {
            //Data = data;
        }
        public SuccessDataResult(T data) : base(data, true) // base = Result
        {
            //Data = data;
        }
        public SuccessDataResult(string message) : base(default, true, message) // base = Result
        {
        }
        public SuccessDataResult() : base(default, true) // base = Result
        {
        }
        //public object Data { get; }
    }

}

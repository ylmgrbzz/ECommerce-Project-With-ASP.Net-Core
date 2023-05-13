using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result // IResult'ın içindeki Success ve Message'yi burada da kullanabilmek için Result'ı miras aldık.
    {
        //public ErrorResult() : base(false) // base = Result
        //{
        //}
        public ErrorResult(string message) : base(false, message) // base = Result
        {
        }
        public ErrorResult() : base(false) // base = Result
        {
        }
    }
}

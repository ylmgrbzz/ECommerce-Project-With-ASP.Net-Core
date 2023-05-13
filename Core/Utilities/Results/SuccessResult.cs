using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result // IResult'ın içindeki Success ve Message'yi burada da kullanabilmek için Result'ı miras aldık.
    {
        //public SuccessResult() : base(true) // base = Result
        //{
        //}
        public SuccessResult(string message) : base(true, message) // base = Result
        {
        }
        public SuccessResult() : base(true) // base = Result
        {
        }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult // IResult'ın içindeki Success ve Message'yi burada da kullanabilmek için Result'ı miras aldık.
    {
        T Data { get; }
    }

}

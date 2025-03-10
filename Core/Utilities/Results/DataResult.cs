﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessResult<T> : Result, IDataResult<T>
    {
        public SuccessResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public SuccessResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }  
    }
}


using System;
using System.Collections.Generic;
using WhatShouldWeEat.Entities.ErrorMessages;

namespace WhatShouldWeEat.Business.Results
{
    public class BusinessResult<T> where T : class
    {
        public List<ErrorMessagesObject> Errors { get; set; }
        public T Result { get; set; }

        public BusinessResult()
        {
            Errors = new List<ErrorMessagesObject>();
        }

        public void AddError(ErrorMessages error, string message)
        {
            Errors.Add(new ErrorMessagesObject() { Code = error, Messages = message });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.DTO
{
    public class BaseResponse<T>
    {
        public BaseResponse(T _value, ResponseStatus _status)
        {
            Value = _value;
            Status = _status;
        }

        public T Value { get; set; }
        public ResponseStatus Status { get; set; }
    }
}

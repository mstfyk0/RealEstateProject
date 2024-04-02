﻿using Application.Queries;

namespace Domain.Common.Wrapper
{
    public class PagedResponse<T> : Response<T>
    {
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
        public PagedResponse(T data, BasePageQuery basePageQuery)
        {
            pageNumber = basePageQuery.pageNumber;
            pageSize = basePageQuery.pageSize;
            this.data = data;
            message = null;
            apiResultType = Enums.ApiResultEnum.Success;
        }
    }
}

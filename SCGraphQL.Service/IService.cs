using SCGraphQL.Model;
using System;
using System.Collections.Generic;

namespace SCGraphQL.Service
{
    public interface IService<TDto> : IScopedDependency
     where TDto : class, IDto, new()
    {
        public TDto GetById(Guid id);
        public IList<TDto> GetList();
        public TDto Insert(TDto dto);
    }
}

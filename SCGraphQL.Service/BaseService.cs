using SCGraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCGraphQL.Service
{
    public abstract class BaseService<TDto> : IService<TDto>
      where TDto : class, IDto, new()
    {
        public static List<TDto> DummyList { get; set; }
        public virtual TDto GetById(Guid id)
        {
            return DummyList.FirstOrDefault(v => v.Id == id);
        }
        public virtual IList<TDto> GetList()
        {
            return DummyList;
        }
        public virtual TDto Insert(TDto dto)
        {
            DummyList.Add(dto);
            return dto;
        }
    }
}

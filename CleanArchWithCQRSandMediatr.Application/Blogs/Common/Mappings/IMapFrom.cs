using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRSandMediatr.Application.Blogs.Common.Mappings
{
    public interface IMapFrom<T>
    {
        // T - generic, so I may use any entity
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}

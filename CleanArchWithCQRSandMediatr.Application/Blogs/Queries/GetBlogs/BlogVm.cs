using CleanArchWithCQRSandMediatr.Application.Blogs.Common.Mappings;
using CleanArchWithCQRSandMediatr.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRSandMediatr.Application.Blogs.Queries.GetBlogs
{
    public class BlogVm : IMapFrom<Blog>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
     //   public string ImageUrl { get; set; }

    }
}

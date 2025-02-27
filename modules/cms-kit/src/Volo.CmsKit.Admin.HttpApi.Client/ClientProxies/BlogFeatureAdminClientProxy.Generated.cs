// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.CmsKit.Admin.Blogs;
using System.Collections.Generic;
using Volo.CmsKit.Blogs;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Admin.Blogs.ClientProxies
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IBlogFeatureAdminAppService), typeof(BlogFeatureAdminClientProxy))]
    public partial class BlogFeatureAdminClientProxy : ClientProxyBase<IBlogFeatureAdminAppService>, IBlogFeatureAdminAppService
    {
        public virtual async Task<List<BlogFeatureDto>> GetListAsync(Guid blogId)
        {
            return await RequestAsync<List<BlogFeatureDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
            {
                { typeof(Guid), blogId }
            });
        }

        public virtual async Task SetAsync(Guid blogId, BlogFeatureInputDto dto)
        {
            await RequestAsync(nameof(SetAsync), new ClientProxyRequestTypeValue
            {
                { typeof(Guid), blogId },
                { typeof(BlogFeatureInputDto), dto }
            });
        }
    }
}

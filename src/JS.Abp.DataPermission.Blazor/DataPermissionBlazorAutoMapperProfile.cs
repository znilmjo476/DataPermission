using JS.Abp.DataPermission.Demos;
using Volo.Abp.AutoMapper;
using JS.Abp.DataPermission.PermissionExtensions;
using AutoMapper;

namespace JS.Abp.DataPermission.Blazor;

public class DataPermissionBlazorAutoMapperProfile : Profile
{
    public DataPermissionBlazorAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<PermissionExtensionDto, PermissionExtensionUpdateDto>();

        CreateMap<DemoDto, DemoUpdateDto>();
    }
}
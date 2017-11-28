
using CTX.Entities;
using HTActive.Core.Repository;
namespace CTX.Repository
{
    public partial interface IClaimRepository : IBaseRepository<Claim>
    {
    }

    public partial interface IImageRepository : IBaseRepository<Image>
    {
    }

    public partial interface IRoleRepository : IBaseRepository<Role>
    {
    }

    public partial interface IRoleClaimRepository : IBaseRepository<RoleClaim>
    {
    }

    public partial interface IUserRepository : IBaseRepository<User>
    {
    }

    public partial interface IUserLoginTokenRepository : IBaseRepository<UserLoginToken>
    {
    }

    public partial interface IUserProfileRepository : IBaseRepository<UserProfile>
    {
    }

    public partial interface IUserRoleRepository : IBaseRepository<UserRole>
    {
    }
}
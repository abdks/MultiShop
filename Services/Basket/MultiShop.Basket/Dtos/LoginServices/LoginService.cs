namespace MultiShop.Basket.Dtos.LoginServices
{
    public class LoginService : ILoginService
    {
        private readonly IHttpContextAccessor _httpcontextAccessor;

        public LoginService(IHttpContextAccessor contextAccessor)
        {
            _httpcontextAccessor = contextAccessor;
        }
        //kullanıcının ıdsini yakalma yeri 
        public string GetUserId => _httpcontextAccessor.HttpContext.User.FindFirst("sub").Value;
    }
}

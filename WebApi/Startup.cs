namespace WebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure DbContext
            //services.AddDbContext<AppDbContext>(options =>
            //    options.UseSqlServer("Server=<localhost>;Database=<TemplateHexagonaAPIDB>;User=<sa>;Password=<Password1>"));

            //services.AddControllersWithViews();


            // Configure DI


        }
    }
}

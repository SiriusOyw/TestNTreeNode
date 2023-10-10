using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Xml;

namespace TestNTreeNode
{
    internal class Program
    {
        /// <summary>
        /// 应用程序配置对象
        /// </summary>
        public static IConfigurationRoot Configuration { get; private set; }

        /// <summary>
        /// 数据库配置对象
        /// </summary>
        public static DbContextOptions<TestNTreeNodeDbContext> DbContextOptions { get; private set; }

        /// <summary>
        /// 获取实体上下文
        /// </summary>
        public static TestNTreeNodeDbContext DbContext => new TestNTreeNodeDbContext(DbContextOptions);
        
        static void Main(string[] args)
        {
            // 初始化
            Configuration = InitConfiguration();
            DbContextOptions = InitDatabase(Configuration);



            Console.ReadKey();
        }

        /// <summary>
        /// 初始化应用程序配置文件
        /// </summary>
        /// <returns></returns>
        public static IConfigurationRoot InitConfiguration()
        {
            var basePath = Directory.GetCurrentDirectory();
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            var configuration = configBuilder.Build();

            return configuration;
        }

        /// <summary>
        /// 初始化数据库配置
        /// </summary>
        /// <param name="configuration">应用程序配置</param>
        /// <returns></returns>
        public static DbContextOptions<TestNTreeNodeDbContext> InitDatabase(IConfigurationRoot configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<TestNTreeNodeDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var dbContextOptions = optionsBuilder.Options;

            Console.WriteLine(connectionString);

            return dbContextOptions;
        }
    }
}
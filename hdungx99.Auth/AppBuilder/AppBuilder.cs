namespace hdungx99.Auth.AppBuilder
{
    public static class AppBuilder
    {
        public static void UseBuilder(this IApplicationBuilder builder, bool isDev)
        {
            if(isDev)
            {
                builder.UseDeveloperExceptionPage();
            }

            builder.UseIdentityServer();
        }
    }
}

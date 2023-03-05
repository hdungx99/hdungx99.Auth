namespace hdungx99.Auth.AppBuilder
{
    public static class AppBuilder
    {
        public static void UseBuilder(this IApplicationBuilder builder, bool isDev)
        {
            if (isDev)
            {
                builder.UseDeveloperExceptionPage();
            }
            builder.UseStaticFiles();
            builder.UseRouting();
            builder.UseIdentityServer();
            builder.UseAuthorization();
            builder.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}

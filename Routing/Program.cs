using Routing.CustomConstraints;

namespace Routing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRouting(options =>
            {
                options.ConstraintMap.Add("alphanumeric", typeof(AlphaNumericContraint));
            });
            var app = builder.Build();


            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/products/{id:int:range(10,1000)}", async(context) =>
                {
                    var id = (context.Request.RouteValues["ID"]);

                    if(id != null)
                    {
                        id = Convert.ToInt32(id);
                        await context.Response.WriteAsync("This is Product in ID " + id);
                    }
                    else
                    {
                        await context.Response.WriteAsync("You are in the product page!");
                    }
                });

                endpoints.MapGet("/books/author/{authorname:alpha:length(8)}/{bookid?}", async (context) =>
                {
                    var Bookid = (context.Request.RouteValues["bookid"]);
                    var AuthorName = Convert.ToString(context.Request.RouteValues["authorname"]);

                    if (Bookid != null)
                    {
                        await context.Response.WriteAsync($"This is the book authored by {AuthorName} and book ID is {Bookid}");
                    }
                    else
                    {
                        await context.Response.WriteAsync($"Following are the list of books authored by {AuthorName}");
                    }

                });

                endpoints.MapGet("/monthly-reports/{month:regex(^([1-9]|1[012])$)}", async (context) =>
                {
                    int monthNumber = Convert.ToInt32(context.Request.RouteValues["month"]);
                    
                    await context.Response.WriteAsync($"This is the monthly report for month number {monthNumber}");
                });

                endpoints.MapGet("/user/{username:alphanumeric}", async (context) =>
                {
                    string username = Convert.ToString(context.Request.RouteValues["username"]);
                    await context.Response.WriteAsync($"Welcome {username}");
                });
            });


            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("The URL wich you are looking for is not found");
            });




            app.Run();
        }
    }
}
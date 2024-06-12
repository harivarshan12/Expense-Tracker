using System;
namespace Expense_Tracker.Models
{
	public class AppDbInitializer
	{
		public AppDbInitializer()
		{
		}
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

				context!.Database.EnsureCreated();

				if (!context.Category.Any())
				{
					context.Category.AddRange(new List<Category>()
					{
						new Category(){
							Title="Travel",
							Icon = "🚂",
							Type = "Expense"
						},
						new Category(){
							Title="Salary",
							Icon = "👨‍💻",
							Type = "Income"
						},
						new Category(){
							Title="Entertainment",
							Icon = "🍿",
							Type = "Expense"
						},
						new Category(){
							Title="Grocery",
							Icon = "🛒",
							Type = "Expense"
						},
						new Category(){
							Title="Stocks",
							Icon = "📈",
							Type = "Income"
						},
						new Category(){
							Title="Health",
							Icon = "🩺",
							Type = "Expense"
						},
						new Category(){
							Title="Open Balance",
							Icon = "🔑",
							Type = "Income"
						},
						new Category(){
							Title="Education",
							Icon = "📚",
							Type = "Expense"
						},
						new Category(){
							Title="Garments",
							Icon = "🥼",
							Type = "Expense"
						},
					});
					context.SaveChanges();
				}
			}
		}
	}
}


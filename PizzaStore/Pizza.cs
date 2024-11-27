using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
	public class PizzaEhod
	{
		public int IdEhod { get; set; }
		public string? NomEhod { get; set; }
		public string? DescriptionEhod { get; set; }
	}

	class PizzaDb : DbContext
	{
		public PizzaDb(DbContextOptions options) : base(options) { }
		public DbSet<Pizza> Pizzas { get; set; } = null!;
	}
}
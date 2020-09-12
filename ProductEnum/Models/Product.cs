using System.ComponentModel.DataAnnotations;

namespace ProductEnum.Models
{
	public enum CategoryType
	{
		Electronicos = 10,
		Alimenticios = 20,
		Moda = 30,
		Belleza = 40,
		Automotriz = 60,
		Libros = 60
	};

	public class Product
	{
		[Key]
		public int ProductId { get; set; }

		[Display(Name = "Nombre del producto")]
		[Required(ErrorMessage = "Debe ingresar el nombre del producto")]
		public string Name { get; set; }

		[Display(Name = "Categoria")]
		[Required(ErrorMessage = "Debe ingresar la categoría del producto")]
		public CategoryType Category { get; set; }
	}
}
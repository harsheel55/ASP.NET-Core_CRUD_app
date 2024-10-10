using System.ComponentModel.DataAnnotations;

public class Employee
{
	public int Id { get; set; }

	[Required]
	public string Name { get; set; }

	[Required]
	public string Position { get; set; }

	[Required]
	[DataType(DataType.Currency)]
	public decimal Salary { get; set; }

	public string Email { get; set; }
}

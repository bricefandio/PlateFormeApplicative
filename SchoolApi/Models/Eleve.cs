namespace SchoolApi.Models
{
	public class Eleve
	{

		public int Id { get; set; }

		public string Nom { get; set; }

		public string Prenom { get; set; }

		public string Email { get; set; }
		public string INE { get; set; }
		public string Telephone { get; set; }
		public string Password { get; set; }
		public string Description { get; set; }
		public Groupe Groupe { get; set; }
		public Promotion Promotion  { get; set; }
		
	}
}

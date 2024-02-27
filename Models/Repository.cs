using System;
namespace BookApp.Models
{
	public static class Repository
	{
		private static List<Book> aplications = new(); //listeye bakarak yanıt vericek

		public static IEnumerable<Book> Aplications => aplications; // her defasında örnek dönebilir.

		public static void Add(Book book)
		{
			aplications.Add(book);
		}
	}
}


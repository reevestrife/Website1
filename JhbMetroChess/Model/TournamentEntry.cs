using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JhbMetroChess.Model
{
	public class TournamentEntry
	{
		public int TournamentId { get; set; }
		public int SectionId { get; set; }
		public string ChessaId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Union { get; set; }
		public string Club { get; set; }
		public string ClubOther { get; set; }
		public string Gender { get; set; }
		public string DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string EntryComment { get; set; }
	}
}
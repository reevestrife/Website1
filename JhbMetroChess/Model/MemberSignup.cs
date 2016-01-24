using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JhbMetroChess.Model
{
	public class MemberSignup
	{
		public string Surname { get; set; }
		public string FirstName { get; set; }
		public string ChessaId { get; set; }
		public string DateOfBirth { get; set; }
		public string Gender { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string Club { get; set; }
		public string Section { get; set; }
		public string Note { get; set; }
		public DateTime DateofEntry { get; set; }
	}
}
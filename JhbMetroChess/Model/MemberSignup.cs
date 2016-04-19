using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JhbMetroChess.Model
{
	public class MemberSignup
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string PreferedName { get; set; }
		public string Club { get; set; }
		public string ChessaId { get; set; }
		public string Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public string ParentName { get; set; }
		public string ParentEmail { get; set; }
		public string ParentEmployer { get; set; }
		public string ParentPhone { get; set; }
		
		//public string Section { get; set; }
		public string Note { get; set; }
		public DateTime DateofEntry { get; set; }
	}
}
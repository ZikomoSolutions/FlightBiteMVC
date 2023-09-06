using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBite.Data.Models
{
	public class ClientTermsModel
	{
		public int ClientMasterModelId { get; set; }
		public ClientMasterModel? ClientMasterModel { get; set; }

		public int TermMasterModelId { get; set; }
		public TermMasterModel? TermMasterModel { get; set; }
	}
}

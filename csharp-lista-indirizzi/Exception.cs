using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exception
{
	public Exception() {}
	

	public class WrongListingException : Exception
	{
		public WrongListingException(string message) : base(message) {}
	}
}

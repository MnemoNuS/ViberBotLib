using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ViberBotLib.Enums
{
	/// <summary>
	/// Chat member role.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChatMemberRole
	{
		/// <summary>
		/// Role "admin".
		/// </summary>
		Admin = 1,

		/// <summary>
		/// Role "participant".
		/// </summary>
		Participant = 2
	}
}

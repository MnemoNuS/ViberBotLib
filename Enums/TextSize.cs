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
	/// Text size.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TextSize
	{
		/// <summary>
		/// Size 'small'.
		/// </summary>
		[EnumMember(Value = "small")]
		Small = 1,

		/// <summary>
		/// Size 'regular'.
		/// </summary>
		[EnumMember(Value = "regular")]
		Regular = 2,

		/// <summary>
		/// Size 'large'.
		/// </summary>
		[EnumMember(Value = "large")]
		Large = 3
	}
}

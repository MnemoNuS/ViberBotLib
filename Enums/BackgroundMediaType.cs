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
	/// Type of the background media.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BackgroundMediaType
	{
		/// <summary>
		/// JPEG and PNG files.
		/// </summary>
		[EnumMember(Value = "picture")]
		Picture = 1,

		/// <summary>
		/// GIF files.
		/// </summary>
		[EnumMember(Value = "gif")]
		Gif = 2
	}
}

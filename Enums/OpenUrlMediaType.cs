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
	/// Determine the url media type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OpenUrlMediaType
	{
		/// <summary>
		/// Force browser usage.
		/// </summary>
		[EnumMember(Value = "not-media")]
		NotMedia = 1,

		/// <summary>
		/// Will be opened via media player.
		/// </summary>
		[EnumMember(Value = "video")]
		Video = 2,

		/// <summary>
		/// Client will play the gif in full screen mode.
		/// </summary>
		[EnumMember(Value = "gif")]
		Gif = 3,

		/// <summary>
		/// Client will open the picture in full screen mode.
		/// </summary>
		[EnumMember(Value = "picture")]
		Picture = 4,
	}
}

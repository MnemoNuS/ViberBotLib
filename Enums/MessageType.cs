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
	///he API supports a variety of message types: text, picture, video, file, location, sticker, contact, carousel content and URL.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessageType
	{
		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "text")]
		Text = 1,

		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "picture")]
		Picture = 2,

		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "video")]
		Video = 3,

		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "file")]
		File = 4,

		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "location")]
		Location = 5,

		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "contact")]
		Contact = 6,

		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "sticker")]
		Sticker = 7,

				/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "carousel content")]
		CarouselContent = 8,

		/// <summary>
		/// Success.
		/// </summary>
		[EnumMember(Value = "URL")]
		Url = 9

	}
}

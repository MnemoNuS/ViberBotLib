using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViberBotLib.Enums;

namespace ViberBotLib.Models
{
	/// <summary>
	/// Text message
	/// </summary>
	public class TextMessage : MessageBase
	{
		public TextMessage() : base(MessageType.Text)
		{
		}

		/// <summary>
		/// Unique Viber user id
		/// Required, subscribed valid user id
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

	}
}

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
	public class LinkMessage : MessageBase
	{
		public LinkMessage() : base(MessageType.Url)
		{
		}
		/// <summary>
		/// Unique Viber user id
		/// Required, subscribed valid user id
		/// </summary>
		[JsonProperty("media")]
		public string Media { get; set; }
	}
}

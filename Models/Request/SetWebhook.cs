using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViberBotLib.Enums;

namespace ViberBotLib.Models.Request
{
	/// <summary>
	/// Resource URL
	/// https://chatapi.viber.com/pa/set_webhook
	/// </summary>
	public class SetWebhook
	{
		/// <summary>
		/// required. Account webhook URL to receive callbacks & messages from users.
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
		/// <summary>
		/// optional. Indicates the types of Viber events that the account owner would like to be notified about. 
		/// Don’t include this parameter in your request to get all events
		/// </summary>
		[JsonProperty("event_types")]
		public ICollection<EventType> EventTypes { get; set; }
		/// <summary>
		/// optional. Indicates whether or not the bot should receive the user name. Default false.
		/// </summary>
		[JsonProperty("send_name")]
		public bool SendName { get; set; }
		/// <summary>
		/// optional. Indicates whether or not the bot should receive the user photo. Default false.
		/// </summary>
		[JsonProperty("send_photo")]
		public bool SendPhoto { get; set; }
	}
}

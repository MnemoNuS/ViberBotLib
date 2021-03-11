using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViberBotLib.Enums;

namespace ViberBotLib.Models.Response
{
	public class WebhookResponse : BaseResponse
	{
		/// <summary>
		/// List of event types you will receive a callback for. Should return the same values sent in the request
		/// delivered, seen, failed, subscribed, unsubscribed  and conversation_started
		/// </summary>
		[JsonProperty("event_types")]
		public ICollection<EventType> EventTypes { get; set; }
	}
}

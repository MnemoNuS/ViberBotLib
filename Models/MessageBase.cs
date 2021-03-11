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
	/// The send_message API allows accounts to send messages to Viber users who subscribe to the account. 
	/// Maximum total JSON size of the request is 30kb.
	/// Resource URL https://chatapi.viber.com/pa/send_message
	/// </summary>
	public abstract class MessageBase
	{
		public MessageBase(MessageType type)
		{
			Type = type;
		}
		/// <summary>
		/// Unique Viber user id
		/// Required, subscribed valid user id
		/// </summary>
		[JsonProperty("receiver")]
		public string Receiver { get; set; }
		/// <summary>
		/// Message type
		/// Required. 
		/// Available message types: text, picture, video, file, location, contact, sticker, carousel content and url
		/// </summary>
		[JsonProperty("type")]
		public MessageType Type { get; set; }

		/// <summary>
		/// The sender data.
		/// </summary>
		[JsonProperty("sender")]
		public UserBase Sender { get; set; }

		/// <summary>
		/// Allow the account to track messages and user’s replies. Sent tracking_data value will be passed back with user’s reply.
		/// Optional. max 4000 characters.
		/// </summary>
		[JsonProperty("tracking_data")]
		public string TrackingData { get; set; }

		/// <summary>
		/// Minimal API version required by clients for this message (default 1)
		/// Optional. client version support the API version. Certain features may not work as expected if set to a number that’s below their requirements.
		/// </summary>
		[JsonProperty("min_api_version")]
		public double MinApiVersion { get; set; } = 1;

	}
}

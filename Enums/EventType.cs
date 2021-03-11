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
	/// Possible values: delivered, seen, failed, subscribed, unsubscribed  and conversation_started
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventType
	{
		[EnumMember(Value = "delivered")]
		Delivered,
		[EnumMember(Value = "seen")]
		Seen,
		[EnumMember(Value = "failed")]
		Failed,
		[EnumMember(Value = "subscribed")]
		Subscribed,
		[EnumMember(Value = "unsubscribed")]
		Unsubscribed,
		[EnumMember(Value = "conversation_started")]
		ConversationStarted,
		[EnumMember(Value = "webhook")]
		Webhook,
		[EnumMember(Value = "client_status")]
		ClientStatus,
		[EnumMember(Value = "action")]
		Action,
		[EnumMember(Value = "message")]
		Message
	}
}

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ViberBotLib.Enums;

namespace ViberBotLib.Models
{/// <summary>
 /// Keyboard message.
 /// </summary>
	public class KeyboardMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KeyboardMessage"/> class.
		/// </summary>
		public KeyboardMessage()
			: base(MessageType.Text)
		{
		}

		/// <summary>
		/// The text of the message.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Keyboard object.
		/// </summary>
		[JsonProperty("keyboard")]
		public Keyboard Keyboard { get; set; }
	}
}

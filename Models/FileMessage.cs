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
	public class FileMessage : MessageBase
	{
		public FileMessage() : base(MessageType.File)
		{
		}

		/// <summary>
		/// Unique Viber user id
		/// Required, subscribed valid user id
		/// </summary>
		[JsonProperty("media")]
		public string Media { get; set; }

		[JsonProperty("size")]
		public string Size { get; set; }

		[JsonProperty("file_name")]
		public string FileName { get; set; }
	}
}

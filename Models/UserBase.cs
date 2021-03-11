using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViberBotLib.Models
{
	public class UserBase
	{
		/// <summary>
		/// The sender’s name to display.
		/// Required. Max 28 characters.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The sender’s avatar URL.
		/// Optional. Avatar size should be no more than 100 kb. Recommended 720x720.
		/// </summary>
		[JsonProperty("avatar")]
		public string Avatar { get; set; }
	}
}

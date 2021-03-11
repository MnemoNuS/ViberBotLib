using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViberBotLib.Enums;
using ViberBotLib.Models;

namespace ViberBotLib.Models
{
	class ViberBotClient : IViberClient
	{
		public Task<ICollection<EventType>> SetWebhookAsync(string url, ICollection<EventType> eventTypes = null)
		{
			throw new NotImplementedException();
		}

		public bool ValidateWebhookHash(string signatureHeader, string jsonMessage)
		{
			throw new NotImplementedException();
		}
	}
}

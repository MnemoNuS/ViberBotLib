using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViberBotLib.Enums;

namespace ViberBotLib.Models
{
	public interface IViberClient
	{
		/// <summary>
		/// Setting the webhook.
		/// </summary>
		/// <param name="url">Account webhook URL to receive callbacks &amp; messages from users.</param>
		/// <param name="eventTypes">Indicates the types of Viber events that the account owner would like to be notified about. Don’t include this parameter in your request to get all events.</param>
		/// <returns>Collection of <see cref="EventType"/>.</returns>
		Task<ICollection<EventType>> SetWebhookAsync(string url, ICollection<EventType> eventTypes = null);
		/// <summary>
		/// Validate hash.
		/// </summary>
		/// <param name="signatureHeader">Value of "X-Viber-Content-Signature" header.</param>
		/// <param name="jsonMessage">JSON message.</param>
		/// <returns><c>true</c> if valid.</returns>
		bool ValidateWebhookHash(string signatureHeader, string jsonMessage);
	}
}

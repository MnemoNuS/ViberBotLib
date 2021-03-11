using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViberBotLib.Enums;

namespace ViberBotLib.Models.Response
{
	/// <summary>
	/// Base API response.
	/// </summary>
	public abstract class BaseResponse
	{
		/// <summary>
		/// Action result.
		/// 0 for success. In case of failure – appropriate failure status number. See error codes table for additional information
		/// </summary>
		[JsonProperty("status")]
		public ErrorCode Status { get; set; }
		/// <summary>
		/// Ok or failure reason.
		/// Success: ok. Failure: invalidUrl, invalidAuthToken, badData, missingData and failure. See error codes table for additional information
		/// </summary>
		[JsonProperty("status_message")]
		public string StatusMessage { get; set; }
	}
}

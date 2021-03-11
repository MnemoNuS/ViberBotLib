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
	/// Keyboard input field state.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum KeyboardInputFieldState
	{
		/// <summary>
		/// Display regular size input field.
		/// </summary>
		[EnumMember(Value = "regular")]
		Regular = 1,

		/// <summary>
		/// Display input field minimized by default.
		/// </summary>
		[EnumMember(Value = "minimized")]
		Minimized = 2,

		/// <summary>
		/// Hide the input field.
		/// </summary>
		[EnumMember(Value = "hidden")]
		Hidden = 3
	}
}

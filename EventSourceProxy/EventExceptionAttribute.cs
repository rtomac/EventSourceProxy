﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourceProxy
{
	/// <summary>
	/// Specifies the EventLevel for an exception generated by a method.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method, AllowMultiple = false)]
	public sealed class EventExceptionAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the EventExceptionAttribute class.
		/// </summary>
		/// <param name="eventLevel">The EventLevel to use for exceptions generated by a method.</param>
		public EventExceptionAttribute(EventLevel eventLevel)
		{
			EventLevel = eventLevel;
		}

		/// <summary>
		/// Gets the EventLevel to use for exceptions generated by a method.
		/// </summary>
		public EventLevel EventLevel { get; private set; }
	}
}

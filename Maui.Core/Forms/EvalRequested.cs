﻿using System.ComponentModel;
using System.Threading.Tasks;

namespace System.Maui
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public delegate Task<string> EvaluateJavaScriptDelegate(string script);

	[EditorBrowsable(EditorBrowsableState.Never)]
	public class EvalRequested : EventArgs
	{
		public string Script { get; }

		public EvalRequested(string script)
		{
			Script = script;
		}
	}
}
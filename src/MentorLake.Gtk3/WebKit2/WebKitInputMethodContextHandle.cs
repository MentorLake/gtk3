namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Base class for input method contexts.
/// </para>
/// <para>
/// WebKitInputMethodContext defines the interface to implement WebKit input methods.
/// The input methods are used by WebKit, when editable content is focused, to map from
/// key events to Unicode character strings.
/// </para>
/// <para>
/// An input method may consume multiple key events in sequence and finally
/// output the composed result. This is called preediting, and an input method
/// may provide feedback about this process by displaying the intermediate
/// composition states as preedit text.
/// </para>
/// </summary>

public class WebKitInputMethodContextHandle : GObjectHandle
{
}
public static class WebKitInputMethodContextHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a complete input sequence has been entered by the user.
/// This can be a single character immediately after a key press or the
/// final result of preediting.
/// </para>
/// </summary>

	public static IObservable<WebKitInputMethodContextHandleSignalStructs.CommittedSignal> Signal_Committed(this WebKitInputMethodContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitInputMethodContextHandleSignalStructs.CommittedSignal> obs) =>
		{
			WebKitInputMethodContextHandleSignalDelegates.committed handler = ( MentorLake.WebKit2.WebKitInputMethodContextHandle self,  string text,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitInputMethodContextHandleSignalStructs.CommittedSignal()
				{
					Self = self, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "committed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted when the input method wants to delete the context surrounding the cursor.
/// If @offset is a negative value, it means a position before the cursor.
/// </para>
/// </summary>

	public static IObservable<WebKitInputMethodContextHandleSignalStructs.DeleteSurroundingSignal> Signal_DeleteSurrounding(this WebKitInputMethodContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitInputMethodContextHandleSignalStructs.DeleteSurroundingSignal> obs) =>
		{
			WebKitInputMethodContextHandleSignalDelegates.delete_surrounding handler = ( MentorLake.WebKit2.WebKitInputMethodContextHandle self,  int offset,  uint n_chars,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitInputMethodContextHandleSignalStructs.DeleteSurroundingSignal()
				{
					Self = self, Offset = offset, NChars = n_chars, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-surrounding", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted whenever the preedit sequence currently being entered has changed.
/// It is also emitted at the end of a preedit sequence, in which case
/// webkit_input_method_context_get_preedit() returns the empty string.
/// </para>
/// </summary>

	public static IObservable<WebKitInputMethodContextHandleSignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this WebKitInputMethodContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitInputMethodContextHandleSignalStructs.PreeditChangedSignal> obs) =>
		{
			WebKitInputMethodContextHandleSignalDelegates.preedit_changed handler = ( MentorLake.WebKit2.WebKitInputMethodContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitInputMethodContextHandleSignalStructs.PreeditChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preedit-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted when a preediting sequence has been completed or canceled.
/// </para>
/// </summary>

	public static IObservable<WebKitInputMethodContextHandleSignalStructs.PreeditFinishedSignal> Signal_PreeditFinished(this WebKitInputMethodContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitInputMethodContextHandleSignalStructs.PreeditFinishedSignal> obs) =>
		{
			WebKitInputMethodContextHandleSignalDelegates.preedit_finished handler = ( MentorLake.WebKit2.WebKitInputMethodContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitInputMethodContextHandleSignalStructs.PreeditFinishedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preedit-finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted when a new preediting sequence starts.
/// </para>
/// </summary>

	public static IObservable<WebKitInputMethodContextHandleSignalStructs.PreeditStartedSignal> Signal_PreeditStarted(this WebKitInputMethodContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitInputMethodContextHandleSignalStructs.PreeditStartedSignal> obs) =>
		{
			WebKitInputMethodContextHandleSignalDelegates.preedit_started handler = ( MentorLake.WebKit2.WebKitInputMethodContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitInputMethodContextHandleSignalStructs.PreeditStartedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preedit-started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitInputMethodContextHandleSignalStructs
{

public class CommittedSignal
{

	public MentorLake.WebKit2.WebKitInputMethodContextHandle Self;
/// <summary>
/// <para>
/// the string result
/// </para>
/// </summary>

	public string Text;

	public IntPtr UserData;
}

public class DeleteSurroundingSignal
{

	public MentorLake.WebKit2.WebKitInputMethodContextHandle Self;
/// <summary>
/// <para>
/// the character offset from the cursor position of the text to be deleted.
/// </para>
/// </summary>

	public int Offset;
/// <summary>
/// <para>
/// the number of characters to be deleted
/// </para>
/// </summary>

	public uint NChars;

	public IntPtr UserData;
}

public class PreeditChangedSignal
{

	public MentorLake.WebKit2.WebKitInputMethodContextHandle Self;

	public IntPtr UserData;
}

public class PreeditFinishedSignal
{

	public MentorLake.WebKit2.WebKitInputMethodContextHandle Self;

	public IntPtr UserData;
}

public class PreeditStartedSignal
{

	public MentorLake.WebKit2.WebKitInputMethodContextHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitInputMethodContextHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a complete input sequence has been entered by the user.
/// This can be a single character immediately after a key press or the
/// final result of preediting.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="text">
/// the string result
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void committed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle self, string text, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the input method wants to delete the context surrounding the cursor.
/// If @offset is a negative value, it means a position before the cursor.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="offset">
/// the character offset from the cursor position of the text to be deleted.
/// </param>
/// <param name="n_chars">
/// the number of characters to be deleted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle self, int offset, uint n_chars, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted whenever the preedit sequence currently being entered has changed.
/// It is also emitted at the end of a preedit sequence, in which case
/// webkit_input_method_context_get_preedit() returns the empty string.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a preediting sequence has been completed or canceled.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a new preediting sequence starts.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle self, IntPtr user_data);

}


public static class WebKitInputMethodContextHandleExtensions
{
/// <summary>
/// <para>
/// Allow @key_event to be handled by the input method.
/// </para>
/// <para>
/// If %TRUE is returned, then no further processing should be
/// done for the key event.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <param name="key_event">
/// the key event to filter
/// </param>
/// <return>
/// %TRUE if the key event was handled, or %FALSE otherwise
/// </return>

	public static bool FilterKeyEvent(this MentorLake.WebKit2.WebKitInputMethodContextHandle context, MentorLake.Gdk.GdkEventKeyHandle key_event)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		return WebKitInputMethodContextHandleExterns.webkit_input_method_context_filter_key_event(context, key_event);
	}

/// <summary>
/// <para>
/// Get the value of the #WebKitInputMethodContext:input-hints property.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <return>
/// the #WebKitInputHints of the input associated with @context
/// </return>

	public static MentorLake.WebKit2.WebKitInputHints GetInputHints(this MentorLake.WebKit2.WebKitInputMethodContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		return WebKitInputMethodContextHandleExterns.webkit_input_method_context_get_input_hints(context);
	}

/// <summary>
/// <para>
/// Get the value of the #WebKitInputMethodContext:input-purpose property.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <return>
/// the #WebKitInputPurpose of the input associated with @context
/// </return>

	public static MentorLake.WebKit2.WebKitInputPurpose GetInputPurpose(this MentorLake.WebKit2.WebKitInputMethodContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		return WebKitInputMethodContextHandleExterns.webkit_input_method_context_get_input_purpose(context);
	}

/// <summary>
/// <para>
/// Get the pre-edit string and a list of WebKitInputMethodUnderline.
/// </para>
/// <para>
/// Get the current pre-edit string for the @context, and a list of WebKitInputMethodUnderline to apply to the string.
/// The string will be displayed inserted at @cursor_offset.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <param name="text">
/// location to store the preedit string
/// </param>
/// <param name="underlines">
/// location to store the underlines as a #GList of #WebKitInputMethodUnderline
/// </param>
/// <param name="cursor_offset">
/// location to store the position of cursor in preedit string
/// </param>

	public static T GetPreedit<T>(this T context, out string text, out MentorLake.GLib.GListHandle underlines, out uint cursor_offset) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_get_preedit(context, out text, out underlines, out cursor_offset);
		return context;
	}

/// <summary>
/// <para>
/// Notify @context that cursor area changed in input associated.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <param name="x">
/// the x coordinate of cursor location
/// </param>
/// <param name="y">
/// the y coordinate of cursor location
/// </param>
/// <param name="width">
/// the width of cursor area
/// </param>
/// <param name="height">
/// the height of cursor area
/// </param>

	public static T NotifyCursorArea<T>(this T context, int x, int y, int width, int height) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_notify_cursor_area(context, x, y, width, height);
		return context;
	}

/// <summary>
/// <para>
/// Notify @context that input associated has gained focus.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>

	public static T NotifyFocusIn<T>(this T context) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_notify_focus_in(context);
		return context;
	}

/// <summary>
/// <para>
/// Notify @context that input associated has lost focus.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>

	public static T NotifyFocusOut<T>(this T context) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_notify_focus_out(context);
		return context;
	}

/// <summary>
/// <para>
/// Notify @context that the context surrounding the cursor has changed.
/// </para>
/// <para>
/// If there&apos;s no selection @selection_index is the same as @cursor_index.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <param name="text">
/// text surrounding the insertion point
/// </param>
/// <param name="length">
/// the length of @text, or -1 if @text is nul-terminated
/// </param>
/// <param name="cursor_index">
/// the byte index of the insertion cursor within @text.
/// </param>
/// <param name="selection_index">
/// the byte index of the selection cursor within @text.
/// </param>

	public static T NotifySurrounding<T>(this T context, string text, int length, uint cursor_index, uint selection_index) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_notify_surrounding(context, text, length, cursor_index, selection_index);
		return context;
	}

/// <summary>
/// <para>
/// Reset the @context.
/// </para>
/// <para>
/// This will typically cause the input to clear the preedit state.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>

	public static T Reset<T>(this T context) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_reset(context);
		return context;
	}

/// <summary>
/// <para>
/// Set whether @context should enable preedit to display feedback.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <param name="enabled">
/// whether to enable preedit
/// </param>

	public static T SetEnablePreedit<T>(this T context, bool enabled) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_set_enable_preedit(context, enabled);
		return context;
	}

/// <summary>
/// <para>
/// Set the value of the #WebKitInputMethodContext:input-hints property.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <param name="hints">
/// a #WebKitInputHints
/// </param>

	public static T SetInputHints<T>(this T context, MentorLake.WebKit2.WebKitInputHints hints) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_set_input_hints(context, hints);
		return context;
	}

/// <summary>
/// <para>
/// Set the value of the #WebKitInputMethodContext:input-purpose property.
/// </para>
/// </summary>

/// <param name="context">
/// a #WebKitInputMethodContext
/// </param>
/// <param name="purpose">
/// a #WebKitInputPurpose
/// </param>

	public static T SetInputPurpose<T>(this T context, MentorLake.WebKit2.WebKitInputPurpose purpose) where T : WebKitInputMethodContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (WebKitInputMethodContextHandle)");
		WebKitInputMethodContextHandleExterns.webkit_input_method_context_set_input_purpose(context, purpose);
		return context;
	}

}

internal class WebKitInputMethodContextHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_input_method_context_filter_key_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle key_event);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitInputHints webkit_input_method_context_get_input_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitInputPurpose webkit_input_method_context_get_input_purpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_get_preedit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context, out string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] out MentorLake.GLib.GListHandle underlines, out uint cursor_offset);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_notify_cursor_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context, int x, int y, int width, int height);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_notify_focus_in([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_notify_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_notify_surrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context, string text, int length, uint cursor_index, uint selection_index);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_set_enable_preedit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context, bool enabled);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_set_input_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context, MentorLake.WebKit2.WebKitInputHints hints);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_input_method_context_set_input_purpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context, MentorLake.WebKit2.WebKitInputPurpose purpose);

}

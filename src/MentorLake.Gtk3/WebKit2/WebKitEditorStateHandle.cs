namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Web editor state.
/// </para>
/// <para>
/// WebKitEditorState represents the state of a #WebKitWebView editor.
/// Use webkit_web_view_get_editor_state() to get the WebKitEditorState
/// of a #WebKitWebView.
/// </para>
/// </summary>

public class WebKitEditorStateHandle : GObjectHandle
{
}
public static class WebKitEditorStateHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the #WebKitEdtorState is changed.
/// </para>
/// </summary>

	public static IObservable<WebKitEditorStateHandleSignalStructs.ChangedSignal> Signal_Changed(this WebKitEditorStateHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitEditorStateHandleSignalStructs.ChangedSignal> obs) =>
		{
			WebKitEditorStateHandleSignalDelegates.changed handler = ( MentorLake.WebKit2.WebKitEditorStateHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitEditorStateHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitEditorStateHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.WebKit2.WebKitEditorStateHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitEditorStateHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the #WebKitEdtorState is changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))] MentorLake.WebKit2.WebKitEditorStateHandle self, IntPtr user_data);

}


public static class WebKitEditorStateHandleExtensions
{
/// <summary>
/// <para>
/// Gets the typing attributes at the current cursor position.
/// </para>
/// <para>
/// If there is a selection, this returns the typing attributes
/// of the selected text. Note that in case of a selection,
/// typing attributes are considered active only when they are
/// present throughout the selection.
/// </para>
/// </summary>

/// <param name="editor_state">
/// a #WebKitEditorState
/// </param>
/// <return>
/// a bitmask of #WebKitEditorTypingAttributes flags
/// </return>

	public static uint GetTypingAttributes(this MentorLake.WebKit2.WebKitEditorStateHandle editor_state)
	{
		if (editor_state.IsInvalid) throw new Exception("Invalid handle (WebKitEditorStateHandle)");
		return WebKitEditorStateHandleExterns.webkit_editor_state_get_typing_attributes(editor_state);
	}

/// <summary>
/// <para>
/// Gets whether a copy command can be issued.
/// </para>
/// </summary>

/// <param name="editor_state">
/// a #WebKitEditorState
/// </param>
/// <return>
/// %TRUE if copy is currently available
/// </return>

	public static bool IsCopyAvailable(this MentorLake.WebKit2.WebKitEditorStateHandle editor_state)
	{
		if (editor_state.IsInvalid) throw new Exception("Invalid handle (WebKitEditorStateHandle)");
		return WebKitEditorStateHandleExterns.webkit_editor_state_is_copy_available(editor_state);
	}

/// <summary>
/// <para>
/// Gets whether a cut command can be issued.
/// </para>
/// </summary>

/// <param name="editor_state">
/// a #WebKitEditorState
/// </param>
/// <return>
/// %TRUE if cut is currently available
/// </return>

	public static bool IsCutAvailable(this MentorLake.WebKit2.WebKitEditorStateHandle editor_state)
	{
		if (editor_state.IsInvalid) throw new Exception("Invalid handle (WebKitEditorStateHandle)");
		return WebKitEditorStateHandleExterns.webkit_editor_state_is_cut_available(editor_state);
	}

/// <summary>
/// <para>
/// Gets whether a paste command can be issued.
/// </para>
/// </summary>

/// <param name="editor_state">
/// a #WebKitEditorState
/// </param>
/// <return>
/// %TRUE if paste is currently available
/// </return>

	public static bool IsPasteAvailable(this MentorLake.WebKit2.WebKitEditorStateHandle editor_state)
	{
		if (editor_state.IsInvalid) throw new Exception("Invalid handle (WebKitEditorStateHandle)");
		return WebKitEditorStateHandleExterns.webkit_editor_state_is_paste_available(editor_state);
	}

/// <summary>
/// <para>
/// Gets whether a redo command can be issued.
/// </para>
/// </summary>

/// <param name="editor_state">
/// a #WebKitEditorState
/// </param>
/// <return>
/// %TRUE if redo is currently available
/// </return>

	public static bool IsRedoAvailable(this MentorLake.WebKit2.WebKitEditorStateHandle editor_state)
	{
		if (editor_state.IsInvalid) throw new Exception("Invalid handle (WebKitEditorStateHandle)");
		return WebKitEditorStateHandleExterns.webkit_editor_state_is_redo_available(editor_state);
	}

/// <summary>
/// <para>
/// Gets whether an undo command can be issued.
/// </para>
/// </summary>

/// <param name="editor_state">
/// a #WebKitEditorState
/// </param>
/// <return>
/// %TRUE if undo is currently available
/// </return>

	public static bool IsUndoAvailable(this MentorLake.WebKit2.WebKitEditorStateHandle editor_state)
	{
		if (editor_state.IsInvalid) throw new Exception("Invalid handle (WebKitEditorStateHandle)");
		return WebKitEditorStateHandleExterns.webkit_editor_state_is_undo_available(editor_state);
	}

}

internal class WebKitEditorStateHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_editor_state_get_typing_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))] MentorLake.WebKit2.WebKitEditorStateHandle editor_state);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_editor_state_is_copy_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))] MentorLake.WebKit2.WebKitEditorStateHandle editor_state);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_editor_state_is_cut_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))] MentorLake.WebKit2.WebKitEditorStateHandle editor_state);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_editor_state_is_paste_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))] MentorLake.WebKit2.WebKitEditorStateHandle editor_state);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_editor_state_is_redo_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))] MentorLake.WebKit2.WebKitEditorStateHandle editor_state);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_editor_state_is_undo_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))] MentorLake.WebKit2.WebKitEditorStateHandle editor_state);

}

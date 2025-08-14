namespace MentorLake.Gtk;


public class GtkEntryAccessibleHandle : GtkWidgetAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkEditableTextHandle, AtkTextHandle
{
}
public static class GtkEntryAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkEntryAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkEntryAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkEntryAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryAccessibleHandleSignalStructs.BoundsChangedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bounds-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "text-attributes-changed" signal is emitted when the text
/// attributes of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

	public static IObservable<GtkEntryAccessibleHandleSignalStructs.TextAttributesChangedSignal> Signal_TextAttributesChanged(this GtkEntryAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryAccessibleHandleSignalStructs.TextAttributesChangedSignal> obs) =>
		{
			GtkEntryAccessibleHandleSignalDelegates.text_attributes_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryAccessibleHandleSignalStructs.TextAttributesChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-attributes-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "text-caret-moved" signal is emitted when the caret
/// position of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

	public static IObservable<GtkEntryAccessibleHandleSignalStructs.TextCaretMovedSignal> Signal_TextCaretMoved(this GtkEntryAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryAccessibleHandleSignalStructs.TextCaretMovedSignal> obs) =>
		{
			GtkEntryAccessibleHandleSignalDelegates.text_caret_moved handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryAccessibleHandleSignalStructs.TextCaretMovedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-caret-moved", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "text-changed" signal is emitted when the text of the
/// object which implements the AtkText interface changes, This
/// signal will have a detail which is either "insert" or
/// "delete" which identifies whether the text change was an
/// insertion or a deletion.
/// </para>
/// </summary>

	public static IObservable<GtkEntryAccessibleHandleSignalStructs.TextChangedSignal> Signal_TextChanged(this GtkEntryAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryAccessibleHandleSignalStructs.TextChangedSignal> obs) =>
		{
			GtkEntryAccessibleHandleSignalDelegates.text_changed handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryAccessibleHandleSignalStructs.TextChangedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "text-insert" signal is emitted when a new text is
/// inserted. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the "system" detail should be
/// included.
/// </para>
/// </summary>

	public static IObservable<GtkEntryAccessibleHandleSignalStructs.TextInsertSignal> Signal_TextInsert(this GtkEntryAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryAccessibleHandleSignalStructs.TextInsertSignal> obs) =>
		{
			GtkEntryAccessibleHandleSignalDelegates.text_insert handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryAccessibleHandleSignalStructs.TextInsertSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, Arg3 = arg3, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-insert", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "text-remove" signal is emitted when a new text is
/// removed. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the "system" detail should be
/// included.
/// </para>
/// </summary>

	public static IObservable<GtkEntryAccessibleHandleSignalStructs.TextRemoveSignal> Signal_TextRemove(this GtkEntryAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryAccessibleHandleSignalStructs.TextRemoveSignal> obs) =>
		{
			GtkEntryAccessibleHandleSignalDelegates.text_remove handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryAccessibleHandleSignalStructs.TextRemoveSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, Arg3 = arg3, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-remove", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "text-selection-changed" signal is emitted when the
/// selected text of an object which implements AtkText changes.
/// </para>
/// </summary>

	public static IObservable<GtkEntryAccessibleHandleSignalStructs.TextSelectionChangedSignal> Signal_TextSelectionChanged(this GtkEntryAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryAccessibleHandleSignalStructs.TextSelectionChangedSignal> obs) =>
		{
			GtkEntryAccessibleHandleSignalDelegates.text_selection_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryAccessibleHandleSignalStructs.TextSelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkEntryAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{

	public MentorLake.Atk.AtkComponentHandle Self;
/// <summary>
/// <para>
/// The AtkRectangle giving the new position and size.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkRectangleHandle Arg1;

	public IntPtr UserData;
}

public class TextAttributesChangedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;

	public IntPtr UserData;
}

public class TextCaretMovedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The new position of the text caret.
/// </para>
/// </summary>

	public int Arg1;

	public IntPtr UserData;
}

public class TextChangedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The position (character offset) of the insertion or deletion.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The length (in characters) of text inserted or deleted.
/// </para>
/// </summary>

	public int Arg2;

	public IntPtr UserData;
}

public class TextInsertSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The position (character offset) of the insertion.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The length (in characters) of text inserted.
/// </para>
/// </summary>

	public int Arg2;
/// <summary>
/// <para>
/// The new text inserted
/// </para>
/// </summary>

	public string Arg3;

	public IntPtr UserData;
}

public class TextRemoveSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The position (character offset) of the removal.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The length (in characters) of text removed.
/// </para>
/// </summary>

	public int Arg2;
/// <summary>
/// <para>
/// The old text removed
/// </para>
/// </summary>

	public string Arg3;

	public IntPtr UserData;
}

public class TextSelectionChangedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;

	public IntPtr UserData;
}
}

public static class GtkEntryAccessibleHandleSignalDelegates
{

/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The AtkRectangle giving the new position and size.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The "text-attributes-changed" signal is emitted when the text
/// attributes of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_attributes_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The "text-caret-moved" signal is emitted when the caret
/// position of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The new position of the text caret.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_caret_moved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The "text-changed" signal is emitted when the text of the
/// object which implements the AtkText interface changes, This
/// signal will have a detail which is either "insert" or
/// "delete" which identifies whether the text change was an
/// insertion or a deletion.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The position (character offset) of the insertion or deletion.
/// </param>
/// <param name="arg2">
/// The length (in characters) of text inserted or deleted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The "text-insert" signal is emitted when a new text is
/// inserted. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the "system" detail should be
/// included.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The position (character offset) of the insertion.
/// </param>
/// <param name="arg2">
/// The length (in characters) of text inserted.
/// </param>
/// <param name="arg3">
/// The new text inserted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


/// <summary>
/// <para>
/// The "text-remove" signal is emitted when a new text is
/// removed. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the "system" detail should be
/// included.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The position (character offset) of the removal.
/// </param>
/// <param name="arg2">
/// The length (in characters) of text removed.
/// </param>
/// <param name="arg3">
/// The old text removed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


/// <summary>
/// <para>
/// The "text-selection-changed" signal is emitted when the
/// selected text of an object which implements AtkText changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);

}


public static class GtkEntryAccessibleHandleExtensions
{
}

internal class GtkEntryAccessibleHandleExterns
{
}

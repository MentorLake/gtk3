namespace MentorLake.Gtk;


public class GtkLabelAccessibleHandle : GtkWidgetAccessibleHandle, AtkComponentHandle, AtkHypertextHandle, AtkTextHandle
{
}
public static class GtkLabelAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.BoundsChangedSignal()
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
/// The &quot;link-selected&quot; signal is emitted by an AtkHyperText
/// object when one of the hyperlinks associated with the object
/// is selected.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.LinkSelectedSignal> Signal_LinkSelected(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.LinkSelectedSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.link_selected handler = ( MentorLake.Atk.AtkHypertextHandle self,  int arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.LinkSelectedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "link-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;text-attributes-changed&quot; signal is emitted when the text
/// attributes of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.TextAttributesChangedSignal> Signal_TextAttributesChanged(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.TextAttributesChangedSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.text_attributes_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.TextAttributesChangedSignal()
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
/// The &quot;text-caret-moved&quot; signal is emitted when the caret
/// position of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.TextCaretMovedSignal> Signal_TextCaretMoved(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.TextCaretMovedSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.text_caret_moved handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.TextCaretMovedSignal()
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
/// The &quot;text-changed&quot; signal is emitted when the text of the
/// object which implements the AtkText interface changes, This
/// signal will have a detail which is either &quot;insert&quot; or
/// &quot;delete&quot; which identifies whether the text change was an
/// insertion or a deletion.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.TextChangedSignal> Signal_TextChanged(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.TextChangedSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.text_changed handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.TextChangedSignal()
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
/// The &quot;text-insert&quot; signal is emitted when a new text is
/// inserted. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
/// included.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.TextInsertSignal> Signal_TextInsert(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.TextInsertSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.text_insert handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.TextInsertSignal()
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
/// The &quot;text-remove&quot; signal is emitted when a new text is
/// removed. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
/// included.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.TextRemoveSignal> Signal_TextRemove(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.TextRemoveSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.text_remove handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.TextRemoveSignal()
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
/// The &quot;text-selection-changed&quot; signal is emitted when the
/// selected text of an object which implements AtkText changes.
/// </para>
/// </summary>

	public static IObservable<GtkLabelAccessibleHandleSignalStructs.TextSelectionChangedSignal> Signal_TextSelectionChanged(this GtkLabelAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLabelAccessibleHandleSignalStructs.TextSelectionChangedSignal> obs) =>
		{
			GtkLabelAccessibleHandleSignalDelegates.text_selection_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelAccessibleHandleSignalStructs.TextSelectionChangedSignal()
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

public static class GtkLabelAccessibleHandleSignalStructs
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

public class LinkSelectedSignal
{

	public MentorLake.Atk.AtkHypertextHandle Self;
/// <summary>
/// <para>
/// the index of the hyperlink which is selected
/// </para>
/// </summary>

	public int Arg1;

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

public static class GtkLabelAccessibleHandleSignalDelegates
{

/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
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
/// The &quot;link-selected&quot; signal is emitted by an AtkHyperText
/// object when one of the hyperlinks associated with the object
/// is selected.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// the index of the hyperlink which is selected
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void link_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle self, int arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;text-attributes-changed&quot; signal is emitted when the text
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
/// The &quot;text-caret-moved&quot; signal is emitted when the caret
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
/// The &quot;text-changed&quot; signal is emitted when the text of the
/// object which implements the AtkText interface changes, This
/// signal will have a detail which is either &quot;insert&quot; or
/// &quot;delete&quot; which identifies whether the text change was an
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
/// The &quot;text-insert&quot; signal is emitted when a new text is
/// inserted. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
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
/// The &quot;text-remove&quot; signal is emitted when a new text is
/// removed. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
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
/// The &quot;text-selection-changed&quot; signal is emitted when the
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


public static class GtkLabelAccessibleHandleExtensions
{
}

internal class GtkLabelAccessibleHandleExterns
{
}

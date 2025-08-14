namespace MentorLake.Gtk;


public class GtkSpinButtonAccessibleHandle : GtkEntryAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkEditableTextHandle, AtkTextHandle, AtkValueHandle
{
}
public static class GtkSpinButtonAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.BoundsChangedSignal()
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

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.TextAttributesChangedSignal> Signal_TextAttributesChanged(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.TextAttributesChangedSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.text_attributes_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.TextAttributesChangedSignal()
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

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.TextCaretMovedSignal> Signal_TextCaretMoved(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.TextCaretMovedSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.text_caret_moved handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.TextCaretMovedSignal()
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

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.TextChangedSignal> Signal_TextChanged(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.TextChangedSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.text_changed handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.TextChangedSignal()
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

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.TextInsertSignal> Signal_TextInsert(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.TextInsertSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.text_insert handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.TextInsertSignal()
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

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.TextRemoveSignal> Signal_TextRemove(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.TextRemoveSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.text_remove handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.TextRemoveSignal()
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

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.TextSelectionChangedSignal> Signal_TextSelectionChanged(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.TextSelectionChangedSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.text_selection_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.TextSelectionChangedSignal()
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
/// <summary>
/// <para>
/// The 'value-changed' signal is emitted when the current value
/// that represent the object changes. @value is the numerical
/// representation of this new value.  @text is the human
/// readable text alternative of @value, and can be NULL if it is
/// not available. Note that if there is a textual description
/// associated with the new numeric value, that description
/// should be included regardless of whether or not it has also
/// changed.
/// </para>
/// <para>
/// Example: a password meter whose value changes as the user
/// types their new password. Appropiate value text would be
/// "weak", "acceptable" and "strong".
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonAccessibleHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkSpinButtonAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonAccessibleHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkSpinButtonAccessibleHandleSignalDelegates.value_changed handler = ( MentorLake.Atk.AtkValueHandle self,  double value,  string text,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonAccessibleHandleSignalStructs.ValueChangedSignal()
				{
					Self = self, Value = value, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "value-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkSpinButtonAccessibleHandleSignalStructs
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

public class ValueChangedSignal
{

	public MentorLake.Atk.AtkValueHandle Self;
/// <summary>
/// <para>
/// the new value in a numerical form.
/// </para>
/// </summary>

	public double Value;
/// <summary>
/// <para>
/// human readable text alternative (also called
/// description) of this object. NULL if not available.
/// </para>
/// </summary>

	public string Text;

	public IntPtr UserData;
}
}

public static class GtkSpinButtonAccessibleHandleSignalDelegates
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


/// <summary>
/// <para>
/// The 'value-changed' signal is emitted when the current value
/// that represent the object changes. @value is the numerical
/// representation of this new value.  @text is the human
/// readable text alternative of @value, and can be NULL if it is
/// not available. Note that if there is a textual description
/// associated with the new numeric value, that description
/// should be included regardless of whether or not it has also
/// changed.
/// </para>
/// <para>
/// Example: a password meter whose value changes as the user
/// types their new password. Appropiate value text would be
/// "weak", "acceptable" and "strong".
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the new value in a numerical form.
/// </param>
/// <param name="text">
/// human readable text alternative (also called
/// description) of this object. NULL if not available.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle self, double value, string text, IntPtr user_data);

}


public static class GtkSpinButtonAccessibleHandleExtensions
{
}

internal class GtkSpinButtonAccessibleHandleExterns
{
}

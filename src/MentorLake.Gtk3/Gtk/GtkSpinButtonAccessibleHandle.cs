namespace MentorLake.Gtk;

public class GtkSpinButtonAccessibleHandle : GtkEntryAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkEditableTextHandle, AtkTextHandle, AtkValueHandle
{
}
public static class GtkSpinButtonAccessibleHandleSignalExtensions
{

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
	public int Arg1;
	public IntPtr UserData;
}

public class TextChangedSignal
{
	public MentorLake.Atk.AtkTextHandle Self;
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class TextInsertSignal
{
	public MentorLake.Atk.AtkTextHandle Self;
	public int Arg1;
	public int Arg2;
	public string Arg3;
	public IntPtr UserData;
}

public class TextRemoveSignal
{
	public MentorLake.Atk.AtkTextHandle Self;
	public int Arg1;
	public int Arg2;
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
	public double Value;
	public string Text;
	public IntPtr UserData;
}
}

public static class GtkSpinButtonAccessibleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_attributes_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_caret_moved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle self, double value, string text, IntPtr user_data);

}


public static class GtkSpinButtonAccessibleHandleExtensions
{
}

internal class GtkSpinButtonAccessibleHandleExterns
{
}

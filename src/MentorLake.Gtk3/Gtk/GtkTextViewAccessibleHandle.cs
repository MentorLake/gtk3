namespace MentorLake.Gtk;

public class GtkTextViewAccessibleHandle : GtkContainerAccessibleHandle, AtkComponentHandle, AtkEditableTextHandle, AtkStreamableContentHandle, AtkTextHandle
{
}
public static class GtkTextViewAccessibleHandleSignalExtensions
{

	public static IObservable<GtkTextViewAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkTextViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkTextViewAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewAccessibleHandleSignalStructs.BoundsChangedSignal()
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

	public static IObservable<GtkTextViewAccessibleHandleSignalStructs.TextAttributesChangedSignal> Signal_TextAttributesChanged(this GtkTextViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewAccessibleHandleSignalStructs.TextAttributesChangedSignal> obs) =>
		{
			GtkTextViewAccessibleHandleSignalDelegates.text_attributes_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewAccessibleHandleSignalStructs.TextAttributesChangedSignal()
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

	public static IObservable<GtkTextViewAccessibleHandleSignalStructs.TextCaretMovedSignal> Signal_TextCaretMoved(this GtkTextViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewAccessibleHandleSignalStructs.TextCaretMovedSignal> obs) =>
		{
			GtkTextViewAccessibleHandleSignalDelegates.text_caret_moved handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewAccessibleHandleSignalStructs.TextCaretMovedSignal()
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

	public static IObservable<GtkTextViewAccessibleHandleSignalStructs.TextChangedSignal> Signal_TextChanged(this GtkTextViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewAccessibleHandleSignalStructs.TextChangedSignal> obs) =>
		{
			GtkTextViewAccessibleHandleSignalDelegates.text_changed handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewAccessibleHandleSignalStructs.TextChangedSignal()
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

	public static IObservable<GtkTextViewAccessibleHandleSignalStructs.TextInsertSignal> Signal_TextInsert(this GtkTextViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewAccessibleHandleSignalStructs.TextInsertSignal> obs) =>
		{
			GtkTextViewAccessibleHandleSignalDelegates.text_insert handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewAccessibleHandleSignalStructs.TextInsertSignal()
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

	public static IObservable<GtkTextViewAccessibleHandleSignalStructs.TextRemoveSignal> Signal_TextRemove(this GtkTextViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewAccessibleHandleSignalStructs.TextRemoveSignal> obs) =>
		{
			GtkTextViewAccessibleHandleSignalDelegates.text_remove handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewAccessibleHandleSignalStructs.TextRemoveSignal()
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

	public static IObservable<GtkTextViewAccessibleHandleSignalStructs.TextSelectionChangedSignal> Signal_TextSelectionChanged(this GtkTextViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewAccessibleHandleSignalStructs.TextSelectionChangedSignal> obs) =>
		{
			GtkTextViewAccessibleHandleSignalDelegates.text_selection_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewAccessibleHandleSignalStructs.TextSelectionChangedSignal()
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

public static class GtkTextViewAccessibleHandleSignalStructs
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
}

public static class GtkTextViewAccessibleHandleSignalDelegates
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

}


public static class GtkTextViewAccessibleHandleExtensions
{
}

internal class GtkTextViewAccessibleHandleExterns
{
}

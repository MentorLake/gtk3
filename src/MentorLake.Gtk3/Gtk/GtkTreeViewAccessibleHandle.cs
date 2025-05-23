namespace MentorLake.Gtk;

public class GtkTreeViewAccessibleHandle : GtkContainerAccessibleHandle, AtkComponentHandle, AtkSelectionHandle, AtkTableHandle, GtkCellAccessibleParentHandle
{
}
public static class GtkTreeViewAccessibleHandleSignalExtensions
{

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.BoundsChangedSignal()
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

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.selection_changed handler = ( MentorLake.Atk.AtkSelectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.ColumnDeletedSignal> Signal_ColumnDeleted(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.ColumnDeletedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.column_deleted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.ColumnDeletedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "column-deleted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.ColumnInsertedSignal> Signal_ColumnInserted(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.ColumnInsertedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.column_inserted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.ColumnInsertedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "column-inserted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.ColumnReorderedSignal> Signal_ColumnReordered(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.ColumnReorderedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.column_reordered handler = ( MentorLake.Atk.AtkTableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.ColumnReorderedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "column-reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.ModelChangedSignal> Signal_ModelChanged(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.ModelChangedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.model_changed handler = ( MentorLake.Atk.AtkTableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.ModelChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "model-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.RowDeletedSignal> Signal_RowDeleted(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.RowDeletedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.row_deleted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.RowDeletedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-deleted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.RowInsertedSignal> Signal_RowInserted(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.RowInsertedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.row_inserted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.RowInsertedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-inserted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTreeViewAccessibleHandleSignalStructs.RowReorderedSignal> Signal_RowReordered(this GtkTreeViewAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewAccessibleHandleSignalStructs.RowReorderedSignal> obs) =>
		{
			GtkTreeViewAccessibleHandleSignalDelegates.row_reordered handler = ( MentorLake.Atk.AtkTableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewAccessibleHandleSignalStructs.RowReorderedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTreeViewAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{
	public MentorLake.Atk.AtkComponentHandle Self;
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}

public class SelectionChangedSignal
{
	public MentorLake.Atk.AtkSelectionHandle Self;
	public IntPtr UserData;
}

public class ColumnDeletedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class ColumnInsertedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class ColumnReorderedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public IntPtr UserData;
}

public class ModelChangedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public IntPtr UserData;
}

public class RowDeletedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class RowInsertedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class RowReorderedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTreeViewAccessibleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void model_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);

}


public static class GtkTreeViewAccessibleHandleExtensions
{
}

internal class GtkTreeViewAccessibleHandleExterns
{
}

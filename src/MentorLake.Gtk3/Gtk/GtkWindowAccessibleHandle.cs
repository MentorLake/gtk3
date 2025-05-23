namespace MentorLake.Gtk;

public class GtkWindowAccessibleHandle : GtkContainerAccessibleHandle, AtkComponentHandle, AtkWindowHandle
{
}
public static class GtkWindowAccessibleHandleSignalExtensions
{

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.BoundsChangedSignal()
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

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.activate handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.CreateSignal> Signal_Create(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.CreateSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.create handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.CreateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.DeactivateSignal> Signal_Deactivate(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.DeactivateSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.deactivate handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.DeactivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "deactivate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.DestroySignal> Signal_Destroy(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.DestroySignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.destroy handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.DestroySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "destroy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.MaximizeSignal> Signal_Maximize(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.MaximizeSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.maximize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.MaximizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "maximize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.MinimizeSignal> Signal_Minimize(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.MinimizeSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.minimize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.MinimizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "minimize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.MoveSignal> Signal_Move(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.MoveSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.move handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.MoveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.ResizeSignal> Signal_Resize(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.ResizeSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.resize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.ResizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWindowAccessibleHandleSignalStructs.RestoreSignal> Signal_Restore(this GtkWindowAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWindowAccessibleHandleSignalStructs.RestoreSignal> obs) =>
		{
			GtkWindowAccessibleHandleSignalDelegates.restore handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWindowAccessibleHandleSignalStructs.RestoreSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "restore", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkWindowAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{
	public MentorLake.Atk.AtkComponentHandle Self;
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}

public class ActivateSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class CreateSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class DeactivateSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class DestroySignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class MaximizeSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class MinimizeSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class MoveSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class ResizeSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}

public class RestoreSignal
{
	public MentorLake.Atk.AtkWindowHandle Self;
	public IntPtr UserData;
}
}

public static class GtkWindowAccessibleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void maximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void minimize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void restore([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);

}


public static class GtkWindowAccessibleHandleExtensions
{
}

internal class GtkWindowAccessibleHandleExterns
{
}

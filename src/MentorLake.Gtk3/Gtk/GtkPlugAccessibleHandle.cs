namespace MentorLake.Gtk;


public class GtkPlugAccessibleHandle : GtkWindowAccessibleHandle, AtkComponentHandle, AtkWindowHandle
{
}
public static class GtkPlugAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The 'bounds-changed" signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.BoundsChangedSignal()
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
/// The signal #AtkWindow::activate is emitted when a window
/// becomes the active window of the application or session.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.activate handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.ActivateSignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::create is emitted when a new window
/// is created.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.CreateSignal> Signal_Create(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.CreateSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.create handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.CreateSignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::deactivate is emitted when a window is
/// no longer the active window of the application or session.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.DeactivateSignal> Signal_Deactivate(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.DeactivateSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.deactivate handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.DeactivateSignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::destroy is emitted when a window is
/// destroyed.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.DestroySignal> Signal_Destroy(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.DestroySignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.destroy handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.DestroySignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::maximize is emitted when a window
/// is maximized.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.MaximizeSignal> Signal_Maximize(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.MaximizeSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.maximize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.MaximizeSignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::minimize is emitted when a window
/// is minimized.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.MinimizeSignal> Signal_Minimize(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.MinimizeSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.minimize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.MinimizeSignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::move is emitted when a window
/// is moved.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.MoveSignal> Signal_Move(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.MoveSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.move handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.MoveSignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::resize is emitted when a window
/// is resized.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.ResizeSignal> Signal_Resize(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.ResizeSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.resize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.ResizeSignal()
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
/// <summary>
/// <para>
/// The signal #AtkWindow::restore is emitted when a window
/// is restored.
/// </para>
/// </summary>

	public static IObservable<GtkPlugAccessibleHandleSignalStructs.RestoreSignal> Signal_Restore(this GtkPlugAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugAccessibleHandleSignalStructs.RestoreSignal> obs) =>
		{
			GtkPlugAccessibleHandleSignalDelegates.restore handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugAccessibleHandleSignalStructs.RestoreSignal()
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

public static class GtkPlugAccessibleHandleSignalStructs
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

public static class GtkPlugAccessibleHandleSignalDelegates
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
/// The signal #AtkWindow::activate is emitted when a window
/// becomes the active window of the application or session.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::create is emitted when a new window
/// is created.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::deactivate is emitted when a window is
/// no longer the active window of the application or session.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::destroy is emitted when a window is
/// destroyed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::maximize is emitted when a window
/// is maximized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void maximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::minimize is emitted when a window
/// is minimized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void minimize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::move is emitted when a window
/// is moved.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::resize is emitted when a window
/// is resized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::restore is emitted when a window
/// is restored.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void restore([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);

}


public static class GtkPlugAccessibleHandleExtensions
{

/// <param name="plug">
/// </param>

	public static string GetId(this MentorLake.Gtk.GtkPlugAccessibleHandle plug)
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugAccessibleHandle)");
		return GtkPlugAccessibleHandleExterns.gtk_plug_accessible_get_id(plug);
	}

}

internal class GtkPlugAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_plug_accessible_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugAccessibleHandle>))] MentorLake.Gtk.GtkPlugAccessibleHandle plug);

}

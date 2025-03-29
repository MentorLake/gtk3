namespace MentorLake.Gio;

public class GCancellableHandle : GObjectHandle
{
	public static MentorLake.Gio.GCancellableHandle New()
	{
		return GCancellableHandleExterns.g_cancellable_new();
	}

	public static MentorLake.Gio.GCancellableHandle GetCurrent()
	{
		return GCancellableHandleExterns.g_cancellable_get_current();
	}

}
public static class GCancellableHandleSignalExtensions
{

	public static IObservable<GCancellableHandleSignalStructs.CancelledSignal> Signal_Cancelled(this GCancellableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GCancellableHandleSignalStructs.CancelledSignal> obs) =>
		{
			GCancellableHandleSignalDelegates.cancelled handler = ( MentorLake.Gio.GCancellableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GCancellableHandleSignalStructs.CancelledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancelled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GCancellableHandleSignalStructs
{

public struct CancelledSignal
{
	public MentorLake.Gio.GCancellableHandle Self;
	public IntPtr UserData;
}
}

public static class GCancellableHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle self, IntPtr user_data);

}


public static class GCancellableHandleExtensions
{
	public static T Cancel<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_cancel(cancellable);
		return cancellable;
	}

	public static ulong Connect(this MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GCallback callback, IntPtr data, MentorLake.GLib.GDestroyNotify data_destroy_func)
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_connect(cancellable, callback, data, data_destroy_func);
	}

	public static T Disconnect<T>(this T cancellable, ulong handler_id) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_disconnect(cancellable, handler_id);
		return cancellable;
	}

	public static int GetFd(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_get_fd(cancellable);
	}

	public static bool IsCancelled(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_is_cancelled(cancellable);
	}

	public static bool MakePollfd(this MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GLib.GPollFDHandle pollfd)
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_make_pollfd(cancellable, pollfd);
	}

	public static T PopCurrent<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_pop_current(cancellable);
		return cancellable;
	}

	public static T PushCurrent<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_push_current(cancellable);
		return cancellable;
	}

	public static T ReleaseFd<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_release_fd(cancellable);
		return cancellable;
	}

	public static T Reset<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_reset(cancellable);
		return cancellable;
	}

	public static bool SetErrorIfCancelled(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		var externCallResult = GCancellableHandleExterns.g_cancellable_set_error_if_cancelled(cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GSourceHandle SourceNew(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid || cancellable.IsClosed) throw new Exception("Invalid or closed handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_source_new(cancellable);
	}

}

internal class GCancellableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GCancellableHandle g_cancellable_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_cancellable_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GCallback callback, IntPtr data, MentorLake.GLib.GDestroyNotify data_destroy_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, ulong handler_id);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_cancellable_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_cancellable_is_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_cancellable_make_pollfd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle pollfd);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_pop_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_push_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_release_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_cancellable_set_error_if_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_cancellable_source_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GCancellableHandle g_cancellable_get_current();

}

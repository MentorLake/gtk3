namespace MentorLake.Gtk3.Gio;

public class GCancellableHandle : GObjectHandle
{
	public static GCancellableHandle New()
	{
		return GCancellableExterns.g_cancellable_new();
	}

	public static GCancellableHandle GetCurrent()
	{
		return GCancellableExterns.g_cancellable_get_current();
	}

}

public static class GCancellableSignalExtensions
{

	public static IObservable<GCancellableSignalStructs.CancelledSignal> Signal_Cancelled(this GCancellableHandle instance)
	{
		return Observable.Create((IObserver<GCancellableSignalStructs.CancelledSignal> obs) =>
		{
			GCancellableSignalDelegates.cancelled handler = (GCancellableHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GCancellableSignalStructs.CancelledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancelled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GCancellableSignalStructs
{

public struct CancelledSignal
{
	public GCancellableHandle Self;
	public IntPtr UserData;
}
}

public static class GCancellableSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GCancellableHandle>))] GCancellableHandle self, IntPtr user_data);

}


public static class GCancellableHandleExtensions
{
	public static T Cancel<T>(this T cancellable) where T : GCancellableHandle
	{
		GCancellableExterns.g_cancellable_cancel(cancellable);
		return cancellable;
	}

	public static ulong Connect(this GCancellableHandle cancellable, IntPtr callback, IntPtr data, GDestroyNotify data_destroy_func)
	{
		return GCancellableExterns.g_cancellable_connect(cancellable, callback, data, data_destroy_func);
	}

	public static T Disconnect<T>(this T cancellable, ulong handler_id) where T : GCancellableHandle
	{
		GCancellableExterns.g_cancellable_disconnect(cancellable, handler_id);
		return cancellable;
	}

	public static int GetFd(this GCancellableHandle cancellable)
	{
		return GCancellableExterns.g_cancellable_get_fd(cancellable);
	}

	public static bool IsCancelled(this GCancellableHandle cancellable)
	{
		return GCancellableExterns.g_cancellable_is_cancelled(cancellable);
	}

	public static bool MakePollfd(this GCancellableHandle cancellable, GPollFDHandle pollfd)
	{
		return GCancellableExterns.g_cancellable_make_pollfd(cancellable, pollfd);
	}

	public static T PopCurrent<T>(this T cancellable) where T : GCancellableHandle
	{
		GCancellableExterns.g_cancellable_pop_current(cancellable);
		return cancellable;
	}

	public static T PushCurrent<T>(this T cancellable) where T : GCancellableHandle
	{
		GCancellableExterns.g_cancellable_push_current(cancellable);
		return cancellable;
	}

	public static T ReleaseFd<T>(this T cancellable) where T : GCancellableHandle
	{
		GCancellableExterns.g_cancellable_release_fd(cancellable);
		return cancellable;
	}

	public static T Reset<T>(this T cancellable) where T : GCancellableHandle
	{
		GCancellableExterns.g_cancellable_reset(cancellable);
		return cancellable;
	}

	public static bool SetErrorIfCancelled(this GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GCancellableExterns.g_cancellable_set_error_if_cancelled(cancellable, out error);
	}

	public static GSourceHandle SourceNew(this GCancellableHandle cancellable)
	{
		return GCancellableExterns.g_cancellable_source_new(cancellable);
	}

}

internal class GCancellableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GCancellableHandle g_cancellable_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_cancel(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern ulong g_cancellable_connect(GCancellableHandle cancellable, IntPtr callback, IntPtr data, GDestroyNotify data_destroy_func);

	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_disconnect(GCancellableHandle cancellable, ulong handler_id);

	[DllImport(Libraries.Gio)]
	internal static extern int g_cancellable_get_fd(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_cancellable_is_cancelled(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_cancellable_make_pollfd(GCancellableHandle cancellable, GPollFDHandle pollfd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_pop_current(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_push_current(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_release_fd(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_reset(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_cancellable_set_error_if_cancelled(GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSourceHandle g_cancellable_source_new(GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern GCancellableHandle g_cancellable_get_current();

}

namespace MentorLake.Gtk3.Gtk3;

public class GtkSocketHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkSocketHandle New()
	{
		return GtkSocketExterns.gtk_socket_new();
	}

}

public static class GtkSocketSignalExtensions
{

	public static IObservable<GtkSocketSignalStructs.PlugAddedSignal> Signal_PlugAdded(this GtkSocketHandle instance)
	{
		return Observable.Create((IObserver<GtkSocketSignalStructs.PlugAddedSignal> obs) =>
		{
			GtkSocketSignalDelegates.plug_added handler = (GtkSocketHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSocketSignalStructs.PlugAddedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "plug_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSocketSignalStructs.PlugRemovedSignal> Signal_PlugRemoved(this GtkSocketHandle instance)
	{
		return Observable.Create((IObserver<GtkSocketSignalStructs.PlugRemovedSignal> obs) =>
		{
			GtkSocketSignalDelegates.plug_removed handler = (GtkSocketHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSocketSignalStructs.PlugRemovedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "plug_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkSocketSignalStructs
{

public struct PlugAddedSignal
{
	public GtkSocketHandle Self;
	public IntPtr UserData;
}

public struct PlugRemovedSignal
{
	public GtkSocketHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkSocketSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void plug_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSocketHandle>))] GtkSocketHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool plug_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSocketHandle>))] GtkSocketHandle self, IntPtr user_data);

}


public static class GtkSocketHandleExtensions
{
	public static GtkSocketHandle AddId(this GtkSocketHandle socket_, IntPtr window)
	{
		GtkSocketExterns.gtk_socket_add_id(socket_, window);
		return socket_;
	}

	public static IntPtr GetId(this GtkSocketHandle socket_)
	{
		return GtkSocketExterns.gtk_socket_get_id(socket_);
	}

	public static GdkWindowHandle GetPlugWindow(this GtkSocketHandle socket_)
	{
		return GtkSocketExterns.gtk_socket_get_plug_window(socket_);
	}

}

internal class GtkSocketExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSocketHandle gtk_socket_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_socket_add_id(GtkSocketHandle socket_, IntPtr window);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_socket_get_id(GtkSocketHandle socket_);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_socket_get_plug_window(GtkSocketHandle socket_);

}

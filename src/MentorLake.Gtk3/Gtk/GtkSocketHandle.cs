namespace MentorLake.Gtk;

public class GtkSocketHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkSocketHandle New()
	{
		return GtkSocketHandleExterns.gtk_socket_new();
	}

}
public static class GtkSocketHandleSignalExtensions
{

	public static IObservable<GtkSocketHandleSignalStructs.PlugAddedSignal> Signal_PlugAdded(this GtkSocketHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSocketHandleSignalStructs.PlugAddedSignal> obs) =>
		{
			GtkSocketHandleSignalDelegates.plug_added handler = ( MentorLake.Gtk.GtkSocketHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSocketHandleSignalStructs.PlugAddedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "plug-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkSocketHandleSignalStructs.PlugRemovedSignal> Signal_PlugRemoved(this GtkSocketHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSocketHandleSignalStructs.PlugRemovedSignal> obs) =>
		{
			GtkSocketHandleSignalDelegates.plug_removed handler = ( MentorLake.Gtk.GtkSocketHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSocketHandleSignalStructs.PlugRemovedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "plug-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkSocketHandleSignalStructs
{

public class PlugAddedSignal
{
	public MentorLake.Gtk.GtkSocketHandle Self;
	public IntPtr UserData;
}

public class PlugRemovedSignal
{
	public MentorLake.Gtk.GtkSocketHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkSocketHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void plug_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool plug_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle self, IntPtr user_data);

}


public static class GtkSocketHandleExtensions
{
	public static T AddId<T>(this T socket_, MentorLake.xlib.Window window) where T : GtkSocketHandle
	{
		if (socket_.IsInvalid || socket_.IsClosed) throw new Exception("Invalid or closed handle (GtkSocketHandle)");
		GtkSocketHandleExterns.gtk_socket_add_id(socket_, window);
		return socket_;
	}

	public static MentorLake.xlib.Window GetId(this MentorLake.Gtk.GtkSocketHandle socket_)
	{
		if (socket_.IsInvalid || socket_.IsClosed) throw new Exception("Invalid or closed handle (GtkSocketHandle)");
		return GtkSocketHandleExterns.gtk_socket_get_id(socket_);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetPlugWindow(this MentorLake.Gtk.GtkSocketHandle socket_)
	{
		if (socket_.IsInvalid || socket_.IsClosed) throw new Exception("Invalid or closed handle (GtkSocketHandle)");
		return GtkSocketHandleExterns.gtk_socket_get_plug_window(socket_);
	}

}

internal class GtkSocketHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSocketHandle gtk_socket_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_socket_add_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle socket_, MentorLake.xlib.Window window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.xlib.Window gtk_socket_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle socket_);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_socket_get_plug_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle socket_);

}

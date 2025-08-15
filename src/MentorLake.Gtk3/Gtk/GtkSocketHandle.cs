namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Together with #GtkPlug, #GtkSocket provides the ability to embed
/// widgets from one process into another process in a fashion that
/// is transparent to the user. One process creates a #GtkSocket widget
/// and passes that widget’s window ID to the other process, which then
/// creates a #GtkPlug with that window ID. Any widgets contained in the
/// #GtkPlug then will appear inside the first application’s window.
/// </para>
/// <para>
/// The socket’s window ID is obtained by using gtk_socket_get_id().
/// Before using this function, the socket must have been realized,
/// and for hence, have been added to its parent.
/// </para>
/// <para>
/// ## Obtaining the window ID of a socket.
/// </para>
/// <code>
/// GtkWidget *socket = gtk_socket_new ();
/// GtkWidget *socket = gtk_socket_new ();
/// gtk_widget_show (socket);
/// gtk_container_add (GTK_CONTAINER (parent), socket);
/// 
/// // The following call is only necessary if one of
/// // the ancestors of the socket is not yet visible.
/// gtk_widget_realize (socket);
/// g_print (&quot;The ID of the sockets window is %#x\n&quot;,
///          gtk_socket_get_id (socket));
/// </code>
/// <para>
/// Note that if you pass the window ID of the socket to another
/// process that will create a plug in the socket, you must make
/// sure that the socket widget is not destroyed until that plug
/// is created. Violating this rule will cause unpredictable
/// consequences, the most likely consequence being that the plug
/// will appear as a separate toplevel window. You can check if
/// the plug has been created by using gtk_socket_get_plug_window().
/// If it returns a non-%NULL value, then the plug has been
/// successfully created inside of the socket.
/// </para>
/// <para>
/// When GTK+ is notified that the embedded window has been destroyed,
/// then it will destroy the socket as well. You should always,
/// therefore, be prepared for your sockets to be destroyed at any
/// time when the main event loop is running. To prevent this from
/// happening, you can connect to the #GtkSocket::plug-removed signal.
/// </para>
/// <para>
/// The communication between a #GtkSocket and a #GtkPlug follows the
/// [XEmbed Protocol](http://www.freedesktop.org/Standards/xembed-spec).
/// This protocol has also been implemented in other toolkits, e.g. Qt,
/// allowing the same level of integration when embedding a Qt widget
/// in GTK or vice versa.
/// </para>
/// <para>
/// The #GtkPlug and #GtkSocket widgets are only available when GTK+
/// is compiled for the X11 platform and %GDK_WINDOWING_X11 is defined.
/// They can only be used on a #GdkX11Display. To use #GtkPlug and
/// #GtkSocket, you need to include the `gtk/gtkx.h` header.
/// </para>
/// </summary>

public class GtkSocketHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Create a new empty #GtkSocket.
/// </para>
/// </summary>

/// <return>
/// the new #GtkSocket.
/// </return>

	public static MentorLake.Gtk.GtkSocketHandle New()
	{
		return GtkSocketHandleExterns.gtk_socket_new();
	}

}
public static class GtkSocketHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when a client is successfully
/// added to the socket.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when a client is removed from the socket.
/// The default action is to destroy the #GtkSocket widget, so if you
/// want to reuse it you must add a signal handler that returns %TRUE.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GtkSocketHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when a client is successfully
/// added to the socket.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void plug_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a client is removed from the socket.
/// The default action is to destroy the #GtkSocket widget, so if you
/// want to reuse it you must add a signal handler that returns %TRUE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool plug_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle self, IntPtr user_data);

}


public static class GtkSocketHandleExtensions
{
/// <summary>
/// <para>
/// Adds an XEMBED client, such as a #GtkPlug, to the #GtkSocket.  The
/// client may be in the same process or in a different process.
/// </para>
/// <para>
/// To embed a #GtkPlug in a #GtkSocket, you can either create the
/// #GtkPlug with `gtk_plug_new (0)`, call
/// gtk_plug_get_id() to get the window ID of the plug, and then pass that to the
/// gtk_socket_add_id(), or you can call gtk_socket_get_id() to get the
/// window ID for the socket, and call gtk_plug_new() passing in that
/// ID.
/// </para>
/// <para>
/// The #GtkSocket must have already be added into a toplevel window
///  before you can make this call.
/// </para>
/// </summary>

/// <param name="socket_">
/// a #GtkSocket
/// </param>
/// <param name="window">
/// the Window of a client participating in the XEMBED protocol.
/// </param>

	public static T AddId<T>(this T socket_, MentorLake.xlib.Window window) where T : GtkSocketHandle
	{
		if (socket_.IsInvalid) throw new Exception("Invalid handle (GtkSocketHandle)");
		GtkSocketHandleExterns.gtk_socket_add_id(socket_, window);
		return socket_;
	}

/// <summary>
/// <para>
/// Gets the window ID of a #GtkSocket widget, which can then
/// be used to create a client embedded inside the socket, for
/// instance with gtk_plug_new().
/// </para>
/// <para>
/// The #GtkSocket must have already be added into a toplevel window
/// before you can make this call.
/// </para>
/// </summary>

/// <param name="socket_">
/// a #GtkSocket.
/// </param>
/// <return>
/// the window ID for the socket
/// </return>

	public static MentorLake.xlib.Window GetId(this MentorLake.Gtk.GtkSocketHandle socket_)
	{
		if (socket_.IsInvalid) throw new Exception("Invalid handle (GtkSocketHandle)");
		return GtkSocketHandleExterns.gtk_socket_get_id(socket_);
	}

/// <summary>
/// <para>
/// Retrieves the window of the plug. Use this to check if the plug has
/// been created inside of the socket.
/// </para>
/// </summary>

/// <param name="socket_">
/// a #GtkSocket.
/// </param>
/// <return>
/// the window of the plug if
/// available, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetPlugWindow(this MentorLake.Gtk.GtkSocketHandle socket_)
	{
		if (socket_.IsInvalid) throw new Exception("Invalid handle (GtkSocketHandle)");
		return GtkSocketHandleExterns.gtk_socket_get_plug_window(socket_);
	}

}

internal class GtkSocketHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))]
	internal static extern MentorLake.Gtk.GtkSocketHandle gtk_socket_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_socket_add_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle socket_, MentorLake.xlib.Window window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.xlib.Window gtk_socket_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle socket_);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_socket_get_plug_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketHandle>))] MentorLake.Gtk.GtkSocketHandle socket_);

}

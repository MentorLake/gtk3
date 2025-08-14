namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Together with #GtkSocket, #GtkPlug provides the ability to embed
/// widgets from one process into another process in a fashion that is
/// transparent to the user. One process creates a #GtkSocket widget
/// and passes the ID of that widget’s window to the other process,
/// which then creates a #GtkPlug with that window ID. Any widgets
/// contained in the #GtkPlug then will appear inside the first
/// application’s window.
/// </para>
/// <para>
/// The communication between a #GtkSocket and a #GtkPlug follows the
/// [XEmbed Protocol](http://www.freedesktop.org/Standards/xembed-spec).
/// This protocol has also been implemented in other toolkits, e.g. Qt,
/// allowing the same level of integration when embedding a Qt widget
/// in GTK+ or vice versa.
/// </para>
/// <para>
/// The #GtkPlug and #GtkSocket widgets are only available when GTK+
/// is compiled for the X11 platform and %GDK_WINDOWING_X11 is defined.
/// They can only be used on a #GdkX11Display. To use #GtkPlug and
/// #GtkSocket, you need to include the `gtk/gtkx.h` header.
/// </para>
/// </summary>

public class GtkPlugHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new plug widget inside the #GtkSocket identified
/// by @socket_id. If @socket_id is 0, the plug is left “unplugged” and
/// can later be plugged into a #GtkSocket by  gtk_socket_add_id().
/// </para>
/// </summary>

/// <param name="socket_id">
/// the window ID of the socket, or 0.
/// </param>
/// <return>
/// the new #GtkPlug widget.
/// </return>

	public static MentorLake.Gtk.GtkPlugHandle New(MentorLake.xlib.Window socket_id)
	{
		return GtkPlugHandleExterns.gtk_plug_new(socket_id);
	}

/// <summary>
/// <para>
/// Create a new plug widget inside the #GtkSocket identified by socket_id.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay on which @socket_id is displayed
/// </param>
/// <param name="socket_id">
/// the XID of the socket’s window.
/// </param>
/// <return>
/// the new #GtkPlug widget.
/// </return>

	public static MentorLake.Gtk.GtkPlugHandle NewForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.xlib.Window socket_id)
	{
		return GtkPlugHandleExterns.gtk_plug_new_for_display(display, socket_id);
	}

}
public static class GtkPlugHandleSignalExtensions
{
/// <summary>
/// <para>
/// Gets emitted when the plug becomes embedded in a socket.
/// </para>
/// </summary>

	public static IObservable<GtkPlugHandleSignalStructs.EmbeddedSignal> Signal_Embedded(this GtkPlugHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlugHandleSignalStructs.EmbeddedSignal> obs) =>
		{
			GtkPlugHandleSignalDelegates.embedded handler = ( MentorLake.Gtk.GtkPlugHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugHandleSignalStructs.EmbeddedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "embedded", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPlugHandleSignalStructs
{

public class EmbeddedSignal
{

	public MentorLake.Gtk.GtkPlugHandle Self;

	public IntPtr UserData;
}
}

public static class GtkPlugHandleSignalDelegates
{

/// <summary>
/// <para>
/// Gets emitted when the plug becomes embedded in a socket.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void embedded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))] MentorLake.Gtk.GtkPlugHandle self, IntPtr user_data);

}


public static class GtkPlugHandleExtensions
{
/// <summary>
/// <para>
/// Finish the initialization of @plug for a given #GtkSocket identified by
/// @socket_id. This function will generally only be used by classes deriving from #GtkPlug.
/// </para>
/// </summary>

/// <param name="plug">
/// a #GtkPlug.
/// </param>
/// <param name="socket_id">
/// the XID of the socket’s window.
/// </param>

	public static T Construct<T>(this T plug, MentorLake.xlib.Window socket_id) where T : GtkPlugHandle
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		GtkPlugHandleExterns.gtk_plug_construct(plug, socket_id);
		return plug;
	}

/// <summary>
/// <para>
/// Finish the initialization of @plug for a given #GtkSocket identified by
/// @socket_id which is currently displayed on @display.
/// This function will generally only be used by classes deriving from #GtkPlug.
/// </para>
/// </summary>

/// <param name="plug">
/// a #GtkPlug.
/// </param>
/// <param name="display">
/// the #GdkDisplay associated with @socket_id’s
///      #GtkSocket.
/// </param>
/// <param name="socket_id">
/// the XID of the socket’s window.
/// </param>

	public static T ConstructForDisplay<T>(this T plug, MentorLake.Gdk.GdkDisplayHandle display, MentorLake.xlib.Window socket_id) where T : GtkPlugHandle
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		GtkPlugHandleExterns.gtk_plug_construct_for_display(plug, display, socket_id);
		return plug;
	}

/// <summary>
/// <para>
/// Determines whether the plug is embedded in a socket.
/// </para>
/// </summary>

/// <param name="plug">
/// a #GtkPlug
/// </param>
/// <return>
/// %TRUE if the plug is embedded in a socket
/// </return>

	public static bool GetEmbedded(this MentorLake.Gtk.GtkPlugHandle plug)
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		return GtkPlugHandleExterns.gtk_plug_get_embedded(plug);
	}

/// <summary>
/// <para>
/// Gets the window ID of a #GtkPlug widget, which can then
/// be used to embed this window inside another window, for
/// instance with gtk_socket_add_id().
/// </para>
/// </summary>

/// <param name="plug">
/// a #GtkPlug.
/// </param>
/// <return>
/// the window ID for the plug
/// </return>

	public static MentorLake.xlib.Window GetId(this MentorLake.Gtk.GtkPlugHandle plug)
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		return GtkPlugHandleExterns.gtk_plug_get_id(plug);
	}

/// <summary>
/// <para>
/// Retrieves the socket the plug is embedded in.
/// </para>
/// </summary>

/// <param name="plug">
/// a #GtkPlug
/// </param>
/// <return>
/// the window of the socket, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetSocketWindow(this MentorLake.Gtk.GtkPlugHandle plug)
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		return GtkPlugHandleExterns.gtk_plug_get_socket_window(plug);
	}

}

internal class GtkPlugHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))]
	internal static extern MentorLake.Gtk.GtkPlugHandle gtk_plug_new(MentorLake.xlib.Window socket_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))]
	internal static extern MentorLake.Gtk.GtkPlugHandle gtk_plug_new_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.xlib.Window socket_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_plug_construct([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))] MentorLake.Gtk.GtkPlugHandle plug, MentorLake.xlib.Window socket_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_plug_construct_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))] MentorLake.Gtk.GtkPlugHandle plug, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.xlib.Window socket_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_plug_get_embedded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))] MentorLake.Gtk.GtkPlugHandle plug);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.xlib.Window gtk_plug_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))] MentorLake.Gtk.GtkPlugHandle plug);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_plug_get_socket_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))] MentorLake.Gtk.GtkPlugHandle plug);

}

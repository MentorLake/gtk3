namespace MentorLake.Gtk;

public class GtkPlugHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkPlugHandle New(MentorLake.xlib.Window socket_id)
	{
		return GtkPlugHandleExterns.gtk_plug_new(socket_id);
	}

	public static MentorLake.Gtk.GtkPlugHandle NewForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.xlib.Window socket_id)
	{
		return GtkPlugHandleExterns.gtk_plug_new_for_display(display, socket_id);
	}

}
public static class GtkPlugHandleSignalExtensions
{

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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void embedded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugHandle>))] MentorLake.Gtk.GtkPlugHandle self, IntPtr user_data);

}


public static class GtkPlugHandleExtensions
{
	public static T Construct<T>(this T plug, MentorLake.xlib.Window socket_id) where T : GtkPlugHandle
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		GtkPlugHandleExterns.gtk_plug_construct(plug, socket_id);
		return plug;
	}

	public static T ConstructForDisplay<T>(this T plug, MentorLake.Gdk.GdkDisplayHandle display, MentorLake.xlib.Window socket_id) where T : GtkPlugHandle
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		GtkPlugHandleExterns.gtk_plug_construct_for_display(plug, display, socket_id);
		return plug;
	}

	public static bool GetEmbedded(this MentorLake.Gtk.GtkPlugHandle plug)
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		return GtkPlugHandleExterns.gtk_plug_get_embedded(plug);
	}

	public static MentorLake.xlib.Window GetId(this MentorLake.Gtk.GtkPlugHandle plug)
	{
		if (plug.IsInvalid) throw new Exception("Invalid handle (GtkPlugHandle)");
		return GtkPlugHandleExterns.gtk_plug_get_id(plug);
	}

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

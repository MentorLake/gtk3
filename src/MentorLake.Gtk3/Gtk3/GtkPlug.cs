namespace MentorLake.Gtk3.Gtk3;

public class GtkPlugHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkPlugHandle New(IntPtr socket_id)
	{
		return GtkPlugExterns.gtk_plug_new(socket_id);
	}

	public static GtkPlugHandle NewForDisplay(GdkDisplayHandle display, IntPtr socket_id)
	{
		return GtkPlugExterns.gtk_plug_new_for_display(display, socket_id);
	}

}

public static class GtkPlugSignalExtensions
{

	public static IObservable<GtkPlugSignalStructs.EmbeddedSignal> Signal_Embedded(this GtkPlugHandle instance)
	{
		return Observable.Create((IObserver<GtkPlugSignalStructs.EmbeddedSignal> obs) =>
		{
			GtkPlugSignalDelegates.embedded handler = (GtkPlugHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlugSignalStructs.EmbeddedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "embedded", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPlugSignalStructs
{

public struct EmbeddedSignal
{
	public GtkPlugHandle Self;
	public IntPtr UserData;
}
}

public static class GtkPlugSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void embedded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlugHandle>))] GtkPlugHandle self, IntPtr user_data);

}


public static class GtkPlugHandleExtensions
{
	public static T Construct<T>(this T plug, IntPtr socket_id) where T : GtkPlugHandle
	{
		GtkPlugExterns.gtk_plug_construct(plug, socket_id);
		return plug;
	}

	public static T ConstructForDisplay<T>(this T plug, GdkDisplayHandle display, IntPtr socket_id) where T : GtkPlugHandle
	{
		GtkPlugExterns.gtk_plug_construct_for_display(plug, display, socket_id);
		return plug;
	}

	public static bool GetEmbedded(this GtkPlugHandle plug)
	{
		return GtkPlugExterns.gtk_plug_get_embedded(plug);
	}

	public static IntPtr GetId(this GtkPlugHandle plug)
	{
		return GtkPlugExterns.gtk_plug_get_id(plug);
	}

	public static GdkWindowHandle GetSocketWindow(this GtkPlugHandle plug)
	{
		return GtkPlugExterns.gtk_plug_get_socket_window(plug);
	}

}

internal class GtkPlugExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPlugHandle gtk_plug_new(IntPtr socket_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPlugHandle gtk_plug_new_for_display(GdkDisplayHandle display, IntPtr socket_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_plug_construct(GtkPlugHandle plug, IntPtr socket_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_plug_construct_for_display(GtkPlugHandle plug, GdkDisplayHandle display, IntPtr socket_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_plug_get_embedded(GtkPlugHandle plug);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_plug_get_id(GtkPlugHandle plug);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_plug_get_socket_window(GtkPlugHandle plug);

}

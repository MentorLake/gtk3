namespace MentorLake.Gtk;

public class GtkLinkButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkLinkButtonHandle New(string uri)
	{
		return GtkLinkButtonHandleExterns.gtk_link_button_new(uri);
	}

	public static MentorLake.Gtk.GtkLinkButtonHandle NewWithLabel(string uri, string label)
	{
		return GtkLinkButtonHandleExterns.gtk_link_button_new_with_label(uri, label);
	}

}
public static class GtkLinkButtonHandleSignalExtensions
{

	public static IObservable<GtkLinkButtonHandleSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkLinkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLinkButtonHandleSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkLinkButtonHandleSignalDelegates.activate_link handler = ( MentorLake.Gtk.GtkLinkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLinkButtonHandleSignalStructs.ActivateLinkSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkLinkButtonHandleSignalStructs
{

public class ActivateLinkSignal
{
	public MentorLake.Gtk.GtkLinkButtonHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkLinkButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle self, IntPtr user_data);

}


public static class GtkLinkButtonHandleExtensions
{
	public static string GetUri(this MentorLake.Gtk.GtkLinkButtonHandle link_button)
	{
		if (link_button.IsInvalid || link_button.IsClosed) throw new Exception("Invalid or closed handle (GtkLinkButtonHandle)");
		return GtkLinkButtonHandleExterns.gtk_link_button_get_uri(link_button);
	}

	public static bool GetVisited(this MentorLake.Gtk.GtkLinkButtonHandle link_button)
	{
		if (link_button.IsInvalid || link_button.IsClosed) throw new Exception("Invalid or closed handle (GtkLinkButtonHandle)");
		return GtkLinkButtonHandleExterns.gtk_link_button_get_visited(link_button);
	}

	public static T SetUri<T>(this T link_button, string uri) where T : GtkLinkButtonHandle
	{
		if (link_button.IsInvalid || link_button.IsClosed) throw new Exception("Invalid or closed handle (GtkLinkButtonHandle)");
		GtkLinkButtonHandleExterns.gtk_link_button_set_uri(link_button, uri);
		return link_button;
	}

	public static T SetVisited<T>(this T link_button, bool visited) where T : GtkLinkButtonHandle
	{
		if (link_button.IsInvalid || link_button.IsClosed) throw new Exception("Invalid or closed handle (GtkLinkButtonHandle)");
		GtkLinkButtonHandleExterns.gtk_link_button_set_visited(link_button, visited);
		return link_button;
	}

}

internal class GtkLinkButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLinkButtonHandle gtk_link_button_new(string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLinkButtonHandle gtk_link_button_new_with_label(string uri, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_link_button_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_link_button_get_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_link_button_set_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button, string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_link_button_set_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button, bool visited);

}

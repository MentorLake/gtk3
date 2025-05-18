namespace MentorLake.Gtk;

public class GtkCellRendererToggleHandle : GtkCellRendererHandle
{
	public static MentorLake.Gtk.GtkCellRendererToggleHandle New()
	{
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_new();
	}

}
public static class GtkCellRendererToggleHandleSignalExtensions
{

	public static IObservable<GtkCellRendererToggleHandleSignalStructs.ToggledSignal> Signal_Toggled(this GtkCellRendererToggleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererToggleHandleSignalStructs.ToggledSignal> obs) =>
		{
			GtkCellRendererToggleHandleSignalDelegates.toggled handler = ( MentorLake.Gtk.GtkCellRendererToggleHandle self,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererToggleHandleSignalStructs.ToggledSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererToggleHandleSignalStructs
{

public class ToggledSignal
{
	public MentorLake.Gtk.GtkCellRendererToggleHandle Self;
	public string Path;
	public IntPtr UserData;
}
}

public static class GtkCellRendererToggleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle self, string path, IntPtr user_data);

}


public static class GtkCellRendererToggleHandleExtensions
{
	public static bool GetActivatable(this MentorLake.Gtk.GtkCellRendererToggleHandle toggle)
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_get_activatable(toggle);
	}

	public static bool GetActive(this MentorLake.Gtk.GtkCellRendererToggleHandle toggle)
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_get_active(toggle);
	}

	public static bool GetRadio(this MentorLake.Gtk.GtkCellRendererToggleHandle toggle)
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_get_radio(toggle);
	}

	public static T SetActivatable<T>(this T toggle, bool setting) where T : GtkCellRendererToggleHandle
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_set_activatable(toggle, setting);
		return toggle;
	}

	public static T SetActive<T>(this T toggle, bool setting) where T : GtkCellRendererToggleHandle
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_set_active(toggle, setting);
		return toggle;
	}

	public static T SetRadio<T>(this T toggle, bool radio) where T : GtkCellRendererToggleHandle
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_set_radio(toggle, radio);
		return toggle;
	}

}

internal class GtkCellRendererToggleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererToggleHandle gtk_cell_renderer_toggle_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_toggle_get_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_toggle_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_toggle_get_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_toggle_set_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_toggle_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_toggle_set_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle, bool radio);

}

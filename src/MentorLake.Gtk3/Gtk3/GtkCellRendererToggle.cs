namespace MentorLake.Gtk3.Gtk3;

public class GtkCellRendererToggleHandle : GtkCellRendererHandle
{
	public static GtkCellRendererToggleHandle New()
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_new();
	}

}

public static class GtkCellRendererToggleSignalExtensions
{

	public static IObservable<GtkCellRendererToggleSignalStructs.ToggledSignal> Signal_Toggled(this GtkCellRendererToggleHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererToggleSignalStructs.ToggledSignal> obs) =>
		{
			GtkCellRendererToggleSignalDelegates.toggled handler = (GtkCellRendererToggleHandle self, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererToggleSignalStructs.ToggledSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCellRendererToggleSignalStructs
{

public struct ToggledSignal
{
	public GtkCellRendererToggleHandle Self;
	public string Path;
	public IntPtr UserData;
}
}

public static class GtkCellRendererToggleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererToggleHandle>))] GtkCellRendererToggleHandle self, string path, IntPtr user_data);

}


public static class GtkCellRendererToggleHandleExtensions
{
	public static bool GetActivatable(this GtkCellRendererToggleHandle toggle)
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_activatable(toggle);
	}

	public static bool GetActive(this GtkCellRendererToggleHandle toggle)
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_active(toggle);
	}

	public static bool GetRadio(this GtkCellRendererToggleHandle toggle)
	{
		return GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_get_radio(toggle);
	}

	public static T SetActivatable<T>(this T toggle, bool setting) where T : GtkCellRendererToggleHandle
	{
		GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_activatable(toggle, setting);
		return toggle;
	}

	public static T SetActive<T>(this T toggle, bool setting) where T : GtkCellRendererToggleHandle
	{
		GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_active(toggle, setting);
		return toggle;
	}

	public static T SetRadio<T>(this T toggle, bool radio) where T : GtkCellRendererToggleHandle
	{
		GtkCellRendererToggleExterns.gtk_cell_renderer_toggle_set_radio(toggle, radio);
		return toggle;
	}

}

internal class GtkCellRendererToggleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererToggleHandle gtk_cell_renderer_toggle_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_renderer_toggle_get_activatable(GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_renderer_toggle_get_active(GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_renderer_toggle_get_radio(GtkCellRendererToggleHandle toggle);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_toggle_set_activatable(GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_toggle_set_active(GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_toggle_set_radio(GtkCellRendererToggleHandle toggle, bool radio);

}

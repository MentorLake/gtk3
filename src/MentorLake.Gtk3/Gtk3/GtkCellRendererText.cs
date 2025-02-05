namespace MentorLake.Gtk3.Gtk3;

public class GtkCellRendererTextHandle : GtkCellRendererHandle
{
	public static GtkCellRendererTextHandle New()
	{
		return GtkCellRendererTextExterns.gtk_cell_renderer_text_new();
	}

}

public static class GtkCellRendererTextSignalExtensions
{

	public static IObservable<GtkCellRendererTextSignalStructs.EditedSignal> Signal_Edited(this GtkCellRendererTextHandle instance)
	{
		return Observable.Create((IObserver<GtkCellRendererTextSignalStructs.EditedSignal> obs) =>
		{
			GtkCellRendererTextSignalDelegates.edited handler = (GtkCellRendererTextHandle self, string path, string new_text, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererTextSignalStructs.EditedSignal()
				{
					Self = self, Path = path, NewText = new_text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCellRendererTextSignalStructs
{

public struct EditedSignal
{
	public GtkCellRendererTextHandle Self;
	public string Path;
	public string NewText;
	public IntPtr UserData;
}
}

public static class GtkCellRendererTextSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCellRendererTextHandle>))] GtkCellRendererTextHandle self, string path, string new_text, IntPtr user_data);

}


public static class GtkCellRendererTextHandleExtensions
{
	public static T SetFixedHeightFromFont<T>(this T renderer, int number_of_rows) where T : GtkCellRendererTextHandle
	{
		GtkCellRendererTextExterns.gtk_cell_renderer_text_set_fixed_height_from_font(renderer, number_of_rows);
		return renderer;
	}

}

internal class GtkCellRendererTextExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellRendererTextHandle gtk_cell_renderer_text_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_renderer_text_set_fixed_height_from_font(GtkCellRendererTextHandle renderer, int number_of_rows);

}

namespace MentorLake.Gtk;

public class GtkCellRendererTextHandle : GtkCellRendererHandle
{
	public static MentorLake.Gtk.GtkCellRendererTextHandle New()
	{
		return GtkCellRendererTextHandleExterns.gtk_cell_renderer_text_new();
	}

}
public static class GtkCellRendererTextHandleSignalExtensions
{

	public static IObservable<GtkCellRendererTextHandleSignalStructs.EditedSignal> Signal_Edited(this GtkCellRendererTextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererTextHandleSignalStructs.EditedSignal> obs) =>
		{
			GtkCellRendererTextHandleSignalDelegates.edited handler = ( MentorLake.Gtk.GtkCellRendererTextHandle self,  string path,  string new_text,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererTextHandleSignalStructs.EditedSignal()
				{
					Self = self, Path = path, NewText = new_text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererTextHandleSignalStructs
{

public struct EditedSignal
{
	public MentorLake.Gtk.GtkCellRendererTextHandle Self;
	public string Path;
	public string NewText;
	public IntPtr UserData;
}
}

public static class GtkCellRendererTextHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererTextHandle>))] MentorLake.Gtk.GtkCellRendererTextHandle self, string path, string new_text, IntPtr user_data);

}


public static class GtkCellRendererTextHandleExtensions
{
	public static T SetFixedHeightFromFont<T>(this T renderer, int number_of_rows) where T : GtkCellRendererTextHandle
	{
		GtkCellRendererTextHandleExterns.gtk_cell_renderer_text_set_fixed_height_from_font(renderer, number_of_rows);
		return renderer;
	}

}

internal class GtkCellRendererTextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellRendererTextHandle gtk_cell_renderer_text_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_text_set_fixed_height_from_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererTextHandle>))] MentorLake.Gtk.GtkCellRendererTextHandle renderer, int number_of_rows);

}

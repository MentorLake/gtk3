namespace MentorLake.Gtk;

public class GtkCellRendererComboHandle : GtkCellRendererTextHandle
{
	public static MentorLake.Gtk.GtkCellRendererComboHandle New()
	{
		return GtkCellRendererComboHandleExterns.gtk_cell_renderer_combo_new();
	}

}
public static class GtkCellRendererComboHandleSignalExtensions
{

	public static IObservable<GtkCellRendererComboHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkCellRendererComboHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererComboHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkCellRendererComboHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkCellRendererComboHandle self,  string path_string,  MentorLake.Gtk.GtkTreeIterHandle new_iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererComboHandleSignalStructs.ChangedSignal()
				{
					Self = self, PathString = path_string, NewIter = new_iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererComboHandleSignalStructs
{

public struct ChangedSignal
{
	public MentorLake.Gtk.GtkCellRendererComboHandle Self;
	public string PathString;
	public MentorLake.Gtk.GtkTreeIterHandle NewIter;
	public IntPtr UserData;
}
}

public static class GtkCellRendererComboHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererComboHandle>))] MentorLake.Gtk.GtkCellRendererComboHandle self, string path_string, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle new_iter, IntPtr user_data);

}


public static class GtkCellRendererComboHandleExtensions
{
}

internal class GtkCellRendererComboHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellRendererComboHandle gtk_cell_renderer_combo_new();

}

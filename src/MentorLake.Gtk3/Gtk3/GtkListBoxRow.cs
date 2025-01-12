namespace MentorLake.Gtk3.Gtk3;

public class GtkListBoxRowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkBuildableHandle
{
	public static GtkListBoxRowHandle New()
	{
		return GtkListBoxRowExterns.gtk_list_box_row_new();
	}

}

public static class GtkListBoxRowSignalExtensions
{

	public static IObservable<GtkListBoxRowSignalStructs.ActivateSignal> Signal_Activate(this GtkListBoxRowHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxRowSignalStructs.ActivateSignal> obs) =>
		{
			GtkListBoxRowSignalDelegates.activate handler = (GtkListBoxRowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxRowSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkListBoxRowSignalStructs
{

public struct ActivateSignal
{
	public GtkListBoxRowHandle Self;
	public IntPtr UserData;
}
}

public static class GtkListBoxRowSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxRowHandle>))] GtkListBoxRowHandle self, IntPtr user_data);

}


public static class GtkListBoxRowHandleExtensions
{
	public static T Changed<T>(this T row) where T : GtkListBoxRowHandle
	{
		GtkListBoxRowExterns.gtk_list_box_row_changed(row);
		return row;
	}

	public static bool GetActivatable(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_activatable(row);
	}

	public static GtkWidgetHandle GetHeader(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_header(row);
	}

	public static int GetIndex(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_index(row);
	}

	public static bool GetSelectable(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_selectable(row);
	}

	public static bool IsSelected(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_is_selected(row);
	}

	public static T SetActivatable<T>(this T row, bool activatable) where T : GtkListBoxRowHandle
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_activatable(row, activatable);
		return row;
	}

	public static T SetHeader<T>(this T row, GtkWidgetHandle header) where T : GtkListBoxRowHandle
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_header(row, header);
		return row;
	}

	public static T SetSelectable<T>(this T row, bool selectable) where T : GtkListBoxRowHandle
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_selectable(row, selectable);
		return row;
	}

}

internal class GtkListBoxRowExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkListBoxRowHandle gtk_list_box_row_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_box_row_changed(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_list_box_row_get_activatable(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_list_box_row_get_header(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_list_box_row_get_index(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_list_box_row_get_selectable(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_list_box_row_is_selected(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_box_row_set_activatable(GtkListBoxRowHandle row, bool activatable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_box_row_set_header(GtkListBoxRowHandle row, GtkWidgetHandle header);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_list_box_row_set_selectable(GtkListBoxRowHandle row, bool selectable);

}

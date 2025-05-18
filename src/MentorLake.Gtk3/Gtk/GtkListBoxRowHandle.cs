namespace MentorLake.Gtk;

public class GtkListBoxRowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkListBoxRowHandle New()
	{
		return GtkListBoxRowHandleExterns.gtk_list_box_row_new();
	}

}
public static class GtkListBoxRowHandleSignalExtensions
{

	public static IObservable<GtkListBoxRowHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkListBoxRowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkListBoxRowHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkListBoxRowHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkListBoxRowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxRowHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkListBoxRowHandleSignalStructs
{

public class ActivateSignal
{
	public MentorLake.Gtk.GtkListBoxRowHandle Self;
	public IntPtr UserData;
}
}

public static class GtkListBoxRowHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle self, IntPtr user_data);

}


public static class GtkListBoxRowHandleExtensions
{
	public static T Changed<T>(this T row) where T : GtkListBoxRowHandle
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		GtkListBoxRowHandleExterns.gtk_list_box_row_changed(row);
		return row;
	}

	public static bool GetActivatable(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_activatable(row);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetHeader(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_header(row);
	}

	public static int GetIndex(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_index(row);
	}

	public static bool GetSelectable(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_selectable(row);
	}

	public static bool IsSelected(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_is_selected(row);
	}

	public static T SetActivatable<T>(this T row, bool activatable) where T : GtkListBoxRowHandle
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		GtkListBoxRowHandleExterns.gtk_list_box_row_set_activatable(row, activatable);
		return row;
	}

	public static T SetHeader<T>(this T row, MentorLake.Gtk.GtkWidgetHandle header) where T : GtkListBoxRowHandle
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		GtkListBoxRowHandleExterns.gtk_list_box_row_set_header(row, header);
		return row;
	}

	public static T SetSelectable<T>(this T row, bool selectable) where T : GtkListBoxRowHandle
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		GtkListBoxRowHandleExterns.gtk_list_box_row_set_selectable(row, selectable);
		return row;
	}

}

internal class GtkListBoxRowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))]
	internal static extern MentorLake.Gtk.GtkListBoxRowHandle gtk_list_box_row_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_row_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_box_row_get_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_list_box_row_get_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_list_box_row_get_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_box_row_get_selectable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_box_row_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_row_set_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, bool activatable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_row_set_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle header);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_box_row_set_selectable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, bool selectable);

}

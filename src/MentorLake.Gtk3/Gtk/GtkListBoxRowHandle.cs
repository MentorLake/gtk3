namespace MentorLake.Gtk;


public class GtkListBoxRowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkListBoxRow, to be used as a child of a #GtkListBox.
/// </para>
/// </summary>

/// <return>
/// a new #GtkListBoxRow
/// </return>

	public static MentorLake.Gtk.GtkListBoxRowHandle New()
	{
		return GtkListBoxRowHandleExterns.gtk_list_box_row_new();
	}

}
public static class GtkListBoxRowHandleSignalExtensions
{
/// <summary>
/// <para>
/// This is a keybinding signal, which will cause this row to be activated.
/// </para>
/// <para>
/// If you want to be notified when the user activates a row (by key or not),
/// use the #GtkListBox::row-activated signal on the row’s parent #GtkListBox.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// This is a keybinding signal, which will cause this row to be activated.
/// </para>
/// <para>
/// If you want to be notified when the user activates a row (by key or not),
/// use the #GtkListBox::row-activated signal on the row’s parent #GtkListBox.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle self, IntPtr user_data);

}


public static class GtkListBoxRowHandleExtensions
{
/// <summary>
/// <para>
/// Marks @row as changed, causing any state that depends on this
/// to be updated. This affects sorting, filtering and headers.
/// </para>
/// <para>
/// Note that calls to this method must be in sync with the data
/// used for the row functions. For instance, if the list is
/// mirroring some external data set, and *two* rows changed in the
/// external data set then when you call gtk_list_box_row_changed()
/// on the first row the sort function must only read the new data
/// for the first of the two changed rows, otherwise the resorting
/// of the rows will be wrong.
/// </para>
/// <para>
/// This generally means that if you don’t fully control the data
/// model you have to duplicate the data that affects the listbox
/// row functions into the row widgets themselves. Another alternative
/// is to call gtk_list_box_invalidate_sort() on any model change,
/// but that is more expensive.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>

	public static T Changed<T>(this T row) where T : GtkListBoxRowHandle
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		GtkListBoxRowHandleExterns.gtk_list_box_row_changed(row);
		return row;
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkListBoxRow:activatable property
/// for this row.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <return>
/// %TRUE if the row is activatable
/// </return>

	public static bool GetActivatable(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_activatable(row);
	}

/// <summary>
/// <para>
/// Returns the current header of the @row. This can be used
/// in a #GtkListBoxUpdateHeaderFunc to see if there is a header
/// set already, and if so to update the state of it.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <return>
/// the current header, or %NULL if none
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetHeader(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_header(row);
	}

/// <summary>
/// <para>
/// Gets the current index of the @row in its #GtkListBox container.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <return>
/// the index of the @row, or -1 if the @row is not in a listbox
/// </return>

	public static int GetIndex(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_index(row);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkListBoxRow:selectable property
/// for this row.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <return>
/// %TRUE if the row is selectable
/// </return>

	public static bool GetSelectable(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_get_selectable(row);
	}

/// <summary>
/// <para>
/// Returns whether the child is currently selected in its
/// #GtkListBox container.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <return>
/// %TRUE if @row is selected
/// </return>

	public static bool IsSelected(this MentorLake.Gtk.GtkListBoxRowHandle row)
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		return GtkListBoxRowHandleExterns.gtk_list_box_row_is_selected(row);
	}

/// <summary>
/// <para>
/// Set the #GtkListBoxRow:activatable property for this row.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <param name="activatable">
/// %TRUE to mark the row as activatable
/// </param>

	public static T SetActivatable<T>(this T row, bool activatable) where T : GtkListBoxRowHandle
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		GtkListBoxRowHandleExterns.gtk_list_box_row_set_activatable(row, activatable);
		return row;
	}

/// <summary>
/// <para>
/// Sets the current header of the @row. This is only allowed to be called
/// from a #GtkListBoxUpdateHeaderFunc. It will replace any existing
/// header in the row, and be shown in front of the row in the listbox.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <param name="header">
/// the header, or %NULL
/// </param>

	public static T SetHeader<T>(this T row, MentorLake.Gtk.GtkWidgetHandle header) where T : GtkListBoxRowHandle
	{
		if (row.IsInvalid) throw new Exception("Invalid handle (GtkListBoxRowHandle)");
		GtkListBoxRowHandleExterns.gtk_list_box_row_set_header(row, header);
		return row;
	}

/// <summary>
/// <para>
/// Set the #GtkListBoxRow:selectable property for this row.
/// </para>
/// </summary>

/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <param name="selectable">
/// %TRUE to mark the row as selectable
/// </param>

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

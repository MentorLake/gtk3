namespace MentorLake.Gtk;

public class GtkTreeViewColumnHandle : GInitiallyUnownedHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
	public static MentorLake.Gtk.GtkTreeViewColumnHandle New()
	{
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_new();
	}

	public static MentorLake.Gtk.GtkTreeViewColumnHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_new_with_area(area);
	}

	public static MentorLake.Gtk.GtkTreeViewColumnHandle NewWithAttributes(string title, MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_new_with_attributes(title, cell, @__arglist);
	}

}
public static class GtkTreeViewColumnHandleSignalExtensions
{

	public static IObservable<GtkTreeViewColumnHandleSignalStructs.ClickedSignal> Signal_Clicked(this GtkTreeViewColumnHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeViewColumnHandleSignalStructs.ClickedSignal> obs) =>
		{
			GtkTreeViewColumnHandleSignalDelegates.clicked handler = ( MentorLake.Gtk.GtkTreeViewColumnHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewColumnHandleSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTreeViewColumnHandleSignalStructs
{

public class ClickedSignal
{
	public MentorLake.Gtk.GtkTreeViewColumnHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTreeViewColumnHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle self, IntPtr user_data);

}


public static class GtkTreeViewColumnHandleExtensions
{
	public static T AddAttribute<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, string attribute, int column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_add_attribute(tree_column, cell_renderer, attribute, column);
		return tree_column;
	}

	public static bool CellGetPosition(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, out int x_offset, out int width)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_get_position(tree_column, cell_renderer, out x_offset, out width);
	}

	public static T CellGetSize<T>(this T tree_column, MentorLake.Gdk.GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_get_size(tree_column, cell_area, out x_offset, out y_offset, out width, out height);
		return tree_column;
	}

	public static bool CellIsVisible(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_is_visible(tree_column);
	}

	public static T CellSetCellData<T>(this T tree_column, MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_cell_set_cell_data(tree_column, tree_model, iter, is_expander, is_expanded);
		return tree_column;
	}

	public static T Clear<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_clear(tree_column);
		return tree_column;
	}

	public static T ClearAttributes<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_clear_attributes(tree_column, cell_renderer);
		return tree_column;
	}

	public static T Clicked<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_clicked(tree_column);
		return tree_column;
	}

	public static T FocusCell<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_focus_cell(tree_column, cell);
		return tree_column;
	}

	public static float GetAlignment(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_alignment(tree_column);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetButton(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_button(tree_column);
	}

	public static bool GetClickable(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_clickable(tree_column);
	}

	public static bool GetExpand(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_expand(tree_column);
	}

	public static int GetFixedWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_fixed_width(tree_column);
	}

	public static int GetMaxWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_max_width(tree_column);
	}

	public static int GetMinWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_min_width(tree_column);
	}

	public static bool GetReorderable(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_reorderable(tree_column);
	}

	public static bool GetResizable(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_resizable(tree_column);
	}

	public static MentorLake.Gtk.GtkTreeViewColumnSizing GetSizing(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sizing(tree_column);
	}

	public static int GetSortColumnId(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sort_column_id(tree_column);
	}

	public static bool GetSortIndicator(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sort_indicator(tree_column);
	}

	public static MentorLake.Gtk.GtkSortType GetSortOrder(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_sort_order(tree_column);
	}

	public static int GetSpacing(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_spacing(tree_column);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_title(tree_column);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetTreeView(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_tree_view(tree_column);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_visible(tree_column);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_widget(tree_column);
	}

	public static int GetWidth(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_width(tree_column);
	}

	public static int GetXOffset(this MentorLake.Gtk.GtkTreeViewColumnHandle tree_column)
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		return GtkTreeViewColumnHandleExterns.gtk_tree_view_column_get_x_offset(tree_column);
	}

	public static T PackEnd<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_pack_end(tree_column, cell, expand);
		return tree_column;
	}

	public static T PackStart<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell, bool expand) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_pack_start(tree_column, cell, expand);
		return tree_column;
	}

	public static T QueueResize<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_queue_resize(tree_column);
		return tree_column;
	}

	public static T SetAlignment<T>(this T tree_column, float xalign) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_alignment(tree_column, xalign);
		return tree_column;
	}

	public static T SetAttributes<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, IntPtr @__arglist) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_attributes(tree_column, cell_renderer, @__arglist);
		return tree_column;
	}

	public static T SetCellDataFunc<T>(this T tree_column, MentorLake.Gtk.GtkCellRendererHandle cell_renderer, MentorLake.Gtk.GtkTreeCellDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_cell_data_func(tree_column, cell_renderer, func, func_data, destroy);
		return tree_column;
	}

	public static T SetClickable<T>(this T tree_column, bool clickable) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_clickable(tree_column, clickable);
		return tree_column;
	}

	public static T SetExpand<T>(this T tree_column, bool expand) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_expand(tree_column, expand);
		return tree_column;
	}

	public static T SetFixedWidth<T>(this T tree_column, int fixed_width) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_fixed_width(tree_column, fixed_width);
		return tree_column;
	}

	public static T SetMaxWidth<T>(this T tree_column, int max_width) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_max_width(tree_column, max_width);
		return tree_column;
	}

	public static T SetMinWidth<T>(this T tree_column, int min_width) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_min_width(tree_column, min_width);
		return tree_column;
	}

	public static T SetReorderable<T>(this T tree_column, bool reorderable) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_reorderable(tree_column, reorderable);
		return tree_column;
	}

	public static T SetResizable<T>(this T tree_column, bool resizable) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_resizable(tree_column, resizable);
		return tree_column;
	}

	public static T SetSizing<T>(this T tree_column, MentorLake.Gtk.GtkTreeViewColumnSizing type) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sizing(tree_column, type);
		return tree_column;
	}

	public static T SetSortColumnId<T>(this T tree_column, int sort_column_id) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sort_column_id(tree_column, sort_column_id);
		return tree_column;
	}

	public static T SetSortIndicator<T>(this T tree_column, bool setting) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sort_indicator(tree_column, setting);
		return tree_column;
	}

	public static T SetSortOrder<T>(this T tree_column, MentorLake.Gtk.GtkSortType order) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_sort_order(tree_column, order);
		return tree_column;
	}

	public static T SetSpacing<T>(this T tree_column, int spacing) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_spacing(tree_column, spacing);
		return tree_column;
	}

	public static T SetTitle<T>(this T tree_column, string title) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_title(tree_column, title);
		return tree_column;
	}

	public static T SetVisible<T>(this T tree_column, bool visible) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_visible(tree_column, visible);
		return tree_column;
	}

	public static T SetWidget<T>(this T tree_column, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkTreeViewColumnHandle
	{
		if (tree_column.IsInvalid || tree_column.IsClosed) throw new Exception("Invalid or closed handle (GtkTreeViewColumnHandle)");
		GtkTreeViewColumnHandleExterns.gtk_tree_view_column_set_widget(tree_column, widget);
		return tree_column;
	}

}

internal class GtkTreeViewColumnHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_column_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_column_new_with_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnHandle gtk_tree_view_column_new_with_attributes(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_add_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, string attribute, int column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_cell_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, out int x_offset, out int width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_cell_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_cell_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_cell_set_cell_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, bool is_expander, bool is_expanded);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_clear_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_focus_cell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_tree_view_column_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tree_view_column_get_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_clickable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_max_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_min_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_resizable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewColumnSizing gtk_tree_view_column_get_sizing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_sort_column_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_sort_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSortType gtk_tree_view_column_get_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tree_view_column_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tree_view_column_get_tree_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_view_column_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tree_view_column_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_view_column_get_x_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_queue_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, float xalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_cell_data_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell_renderer, MentorLake.Gtk.GtkTreeCellDataFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_clickable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool clickable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int fixed_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_max_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int max_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_min_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int min_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool reorderable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_resizable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool resizable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sizing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, MentorLake.Gtk.GtkTreeViewColumnSizing type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sort_column_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int sort_column_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sort_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, MentorLake.Gtk.GtkSortType order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_view_column_set_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}

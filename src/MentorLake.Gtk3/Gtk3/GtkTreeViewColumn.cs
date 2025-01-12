namespace MentorLake.Gtk3.Gtk3;

public class GtkTreeViewColumnHandle : GInitiallyUnownedHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
	public static GtkTreeViewColumnHandle New()
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_new();
	}

	public static GtkTreeViewColumnHandle NewWithArea(GtkCellAreaHandle area)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_new_with_area(area);
	}

	public static GtkTreeViewColumnHandle NewWithAttributes(string title, GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_new_with_attributes(title, cell, @__arglist);
	}

}

public static class GtkTreeViewColumnSignalExtensions
{

	public static IObservable<GtkTreeViewColumnSignalStructs.ClickedSignal> Signal_Clicked(this GtkTreeViewColumnHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeViewColumnSignalStructs.ClickedSignal> obs) =>
		{
			GtkTreeViewColumnSignalDelegates.clicked handler = (GtkTreeViewColumnHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeViewColumnSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkTreeViewColumnSignalStructs
{

public struct ClickedSignal
{
	public GtkTreeViewColumnHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTreeViewColumnSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeViewColumnHandle>))] GtkTreeViewColumnHandle self, IntPtr user_data);

}


public static class GtkTreeViewColumnHandleExtensions
{
	public static T AddAttribute<T>(this T tree_column, GtkCellRendererHandle cell_renderer, string attribute, int column) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_add_attribute(tree_column, cell_renderer, attribute, column);
		return tree_column;
	}

	public static bool CellGetPosition(this GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, out int x_offset, out int width)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_cell_get_position(tree_column, cell_renderer, out x_offset, out width);
	}

	public static T CellGetSize<T>(this T tree_column, GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_cell_get_size(tree_column, cell_area, out x_offset, out y_offset, out width, out height);
		return tree_column;
	}

	public static bool CellIsVisible(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_cell_is_visible(tree_column);
	}

	public static T CellSetCellData<T>(this T tree_column, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_cell_set_cell_data(tree_column, tree_model, iter, is_expander, is_expanded);
		return tree_column;
	}

	public static T Clear<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_clear(tree_column);
		return tree_column;
	}

	public static T ClearAttributes<T>(this T tree_column, GtkCellRendererHandle cell_renderer) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_clear_attributes(tree_column, cell_renderer);
		return tree_column;
	}

	public static T Clicked<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_clicked(tree_column);
		return tree_column;
	}

	public static T FocusCell<T>(this T tree_column, GtkCellRendererHandle cell) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_focus_cell(tree_column, cell);
		return tree_column;
	}

	public static float GetAlignment(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_alignment(tree_column);
	}

	public static GtkWidgetHandle GetButton(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_button(tree_column);
	}

	public static bool GetClickable(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_clickable(tree_column);
	}

	public static bool GetExpand(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_expand(tree_column);
	}

	public static int GetFixedWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_fixed_width(tree_column);
	}

	public static int GetMaxWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_max_width(tree_column);
	}

	public static int GetMinWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_min_width(tree_column);
	}

	public static bool GetReorderable(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_reorderable(tree_column);
	}

	public static bool GetResizable(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_resizable(tree_column);
	}

	public static GtkTreeViewColumnSizing GetSizing(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sizing(tree_column);
	}

	public static int GetSortColumnId(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sort_column_id(tree_column);
	}

	public static bool GetSortIndicator(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sort_indicator(tree_column);
	}

	public static GtkSortType GetSortOrder(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_sort_order(tree_column);
	}

	public static int GetSpacing(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_spacing(tree_column);
	}

	public static string GetTitle(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_title(tree_column);
	}

	public static GtkWidgetHandle GetTreeView(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_tree_view(tree_column);
	}

	public static bool GetVisible(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_visible(tree_column);
	}

	public static GtkWidgetHandle GetWidget(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_widget(tree_column);
	}

	public static int GetWidth(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_width(tree_column);
	}

	public static int GetXOffset(this GtkTreeViewColumnHandle tree_column)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_get_x_offset(tree_column);
	}

	public static T PackEnd<T>(this T tree_column, GtkCellRendererHandle cell, bool expand) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_pack_end(tree_column, cell, expand);
		return tree_column;
	}

	public static T PackStart<T>(this T tree_column, GtkCellRendererHandle cell, bool expand) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_pack_start(tree_column, cell, expand);
		return tree_column;
	}

	public static T QueueResize<T>(this T tree_column) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_queue_resize(tree_column);
		return tree_column;
	}

	public static T SetAlignment<T>(this T tree_column, float xalign) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_alignment(tree_column, xalign);
		return tree_column;
	}

	public static T SetAttributes<T>(this T tree_column, GtkCellRendererHandle cell_renderer, IntPtr @__arglist) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_attributes(tree_column, cell_renderer, @__arglist);
		return tree_column;
	}

	public static T SetCellDataFunc<T>(this T tree_column, GtkCellRendererHandle cell_renderer, GtkTreeCellDataFunc func, IntPtr func_data, GDestroyNotify destroy) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_cell_data_func(tree_column, cell_renderer, func, func_data, destroy);
		return tree_column;
	}

	public static T SetClickable<T>(this T tree_column, bool clickable) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_clickable(tree_column, clickable);
		return tree_column;
	}

	public static T SetExpand<T>(this T tree_column, bool expand) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_expand(tree_column, expand);
		return tree_column;
	}

	public static T SetFixedWidth<T>(this T tree_column, int fixed_width) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_fixed_width(tree_column, fixed_width);
		return tree_column;
	}

	public static T SetMaxWidth<T>(this T tree_column, int max_width) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_max_width(tree_column, max_width);
		return tree_column;
	}

	public static T SetMinWidth<T>(this T tree_column, int min_width) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_min_width(tree_column, min_width);
		return tree_column;
	}

	public static T SetReorderable<T>(this T tree_column, bool reorderable) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_reorderable(tree_column, reorderable);
		return tree_column;
	}

	public static T SetResizable<T>(this T tree_column, bool resizable) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_resizable(tree_column, resizable);
		return tree_column;
	}

	public static T SetSizing<T>(this T tree_column, GtkTreeViewColumnSizing type) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sizing(tree_column, type);
		return tree_column;
	}

	public static T SetSortColumnId<T>(this T tree_column, int sort_column_id) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sort_column_id(tree_column, sort_column_id);
		return tree_column;
	}

	public static T SetSortIndicator<T>(this T tree_column, bool setting) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sort_indicator(tree_column, setting);
		return tree_column;
	}

	public static T SetSortOrder<T>(this T tree_column, GtkSortType order) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_sort_order(tree_column, order);
		return tree_column;
	}

	public static T SetSpacing<T>(this T tree_column, int spacing) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_spacing(tree_column, spacing);
		return tree_column;
	}

	public static T SetTitle<T>(this T tree_column, string title) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_title(tree_column, title);
		return tree_column;
	}

	public static T SetVisible<T>(this T tree_column, bool visible) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_visible(tree_column, visible);
		return tree_column;
	}

	public static T SetWidget<T>(this T tree_column, GtkWidgetHandle widget) where T : GtkTreeViewColumnHandle
	{
		GtkTreeViewColumnExterns.gtk_tree_view_column_set_widget(tree_column, widget);
		return tree_column;
	}

}

internal class GtkTreeViewColumnExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewColumnHandle gtk_tree_view_column_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewColumnHandle gtk_tree_view_column_new_with_area(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewColumnHandle gtk_tree_view_column_new_with_attributes(string title, GtkCellRendererHandle cell, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_add_attribute(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, string attribute, int column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_cell_get_position(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, out int x_offset, out int width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_cell_get_size(GtkTreeViewColumnHandle tree_column, GdkRectangleHandle cell_area, out int x_offset, out int y_offset, out int width, out int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_cell_is_visible(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_cell_set_cell_data(GtkTreeViewColumnHandle tree_column, GtkTreeModelHandle tree_model, GtkTreeIterHandle iter, bool is_expander, bool is_expanded);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_clear(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_clear_attributes(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_clicked(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_focus_cell(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell);

	[DllImport(Libraries.Gtk3)]
	internal static extern float gtk_tree_view_column_get_alignment(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tree_view_column_get_button(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_get_clickable(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_get_expand(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_column_get_fixed_width(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_column_get_max_width(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_column_get_min_width(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_get_reorderable(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_get_resizable(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewColumnSizing gtk_tree_view_column_get_sizing(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_column_get_sort_column_id(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_get_sort_indicator(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSortType gtk_tree_view_column_get_sort_order(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_column_get_spacing(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tree_view_column_get_title(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tree_view_column_get_tree_view(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_view_column_get_visible(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tree_view_column_get_widget(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_column_get_width(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tree_view_column_get_x_offset(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_pack_end(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_pack_start(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_queue_resize(GtkTreeViewColumnHandle tree_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_alignment(GtkTreeViewColumnHandle tree_column, float xalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_attributes(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_cell_data_func(GtkTreeViewColumnHandle tree_column, GtkCellRendererHandle cell_renderer, GtkTreeCellDataFunc func, IntPtr func_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_clickable(GtkTreeViewColumnHandle tree_column, bool clickable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_expand(GtkTreeViewColumnHandle tree_column, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_fixed_width(GtkTreeViewColumnHandle tree_column, int fixed_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_max_width(GtkTreeViewColumnHandle tree_column, int max_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_min_width(GtkTreeViewColumnHandle tree_column, int min_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_reorderable(GtkTreeViewColumnHandle tree_column, bool reorderable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_resizable(GtkTreeViewColumnHandle tree_column, bool resizable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_sizing(GtkTreeViewColumnHandle tree_column, GtkTreeViewColumnSizing type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_sort_column_id(GtkTreeViewColumnHandle tree_column, int sort_column_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_sort_indicator(GtkTreeViewColumnHandle tree_column, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_sort_order(GtkTreeViewColumnHandle tree_column, GtkSortType order);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_spacing(GtkTreeViewColumnHandle tree_column, int spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_title(GtkTreeViewColumnHandle tree_column, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_visible(GtkTreeViewColumnHandle tree_column, bool visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_view_column_set_widget(GtkTreeViewColumnHandle tree_column, GtkWidgetHandle widget);

}

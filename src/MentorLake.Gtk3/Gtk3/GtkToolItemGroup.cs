namespace MentorLake.Gtk3.Gtk3;

public class GtkToolItemGroupHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkToolShellHandle
{
	public static GtkToolItemGroupHandle New(string label)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_new(label);
	}

}

public static class GtkToolItemGroupHandleExtensions
{
	public static bool GetCollapsed(this GtkToolItemGroupHandle group)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_collapsed(group);
	}

	public static GtkToolItemHandle GetDropItem(this GtkToolItemGroupHandle group, int x, int y)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_drop_item(group, x, y);
	}

	public static PangoEllipsizeMode GetEllipsize(this GtkToolItemGroupHandle group)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_ellipsize(group);
	}

	public static GtkReliefStyle GetHeaderRelief(this GtkToolItemGroupHandle group)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_header_relief(group);
	}

	public static int GetItemPosition(this GtkToolItemGroupHandle group, GtkToolItemHandle item)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_item_position(group, item);
	}

	public static string GetLabel(this GtkToolItemGroupHandle group)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_label(group);
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkToolItemGroupHandle group)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_label_widget(group);
	}

	public static uint GetNItems(this GtkToolItemGroupHandle group)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_n_items(group);
	}

	public static GtkToolItemHandle GetNthItem(this GtkToolItemGroupHandle group, uint index)
	{
		return GtkToolItemGroupExterns.gtk_tool_item_group_get_nth_item(group, index);
	}

	public static GtkToolItemGroupHandle Insert(this GtkToolItemGroupHandle group, GtkToolItemHandle item, int position)
	{
		GtkToolItemGroupExterns.gtk_tool_item_group_insert(group, item, position);
		return group;
	}

	public static GtkToolItemGroupHandle SetCollapsed(this GtkToolItemGroupHandle group, bool collapsed)
	{
		GtkToolItemGroupExterns.gtk_tool_item_group_set_collapsed(group, collapsed);
		return group;
	}

	public static GtkToolItemGroupHandle SetEllipsize(this GtkToolItemGroupHandle group, PangoEllipsizeMode ellipsize)
	{
		GtkToolItemGroupExterns.gtk_tool_item_group_set_ellipsize(group, ellipsize);
		return group;
	}

	public static GtkToolItemGroupHandle SetHeaderRelief(this GtkToolItemGroupHandle group, GtkReliefStyle style)
	{
		GtkToolItemGroupExterns.gtk_tool_item_group_set_header_relief(group, style);
		return group;
	}

	public static GtkToolItemGroupHandle SetItemPosition(this GtkToolItemGroupHandle group, GtkToolItemHandle item, int position)
	{
		GtkToolItemGroupExterns.gtk_tool_item_group_set_item_position(group, item, position);
		return group;
	}

	public static GtkToolItemGroupHandle SetLabel(this GtkToolItemGroupHandle group, string label)
	{
		GtkToolItemGroupExterns.gtk_tool_item_group_set_label(group, label);
		return group;
	}

	public static GtkToolItemGroupHandle SetLabelWidget(this GtkToolItemGroupHandle group, GtkWidgetHandle label_widget)
	{
		GtkToolItemGroupExterns.gtk_tool_item_group_set_label_widget(group, label_widget);
		return group;
	}

}

internal class GtkToolItemGroupExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolItemGroupHandle gtk_tool_item_group_new(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_item_group_get_collapsed(GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolItemHandle gtk_tool_item_group_get_drop_item(GtkToolItemGroupHandle group, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoEllipsizeMode gtk_tool_item_group_get_ellipsize(GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkReliefStyle gtk_tool_item_group_get_header_relief(GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tool_item_group_get_item_position(GtkToolItemGroupHandle group, GtkToolItemHandle item);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_item_group_get_label(GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tool_item_group_get_label_widget(GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_tool_item_group_get_n_items(GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolItemHandle gtk_tool_item_group_get_nth_item(GtkToolItemGroupHandle group, uint index);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_group_insert(GtkToolItemGroupHandle group, GtkToolItemHandle item, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_group_set_collapsed(GtkToolItemGroupHandle group, bool collapsed);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_group_set_ellipsize(GtkToolItemGroupHandle group, PangoEllipsizeMode ellipsize);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_group_set_header_relief(GtkToolItemGroupHandle group, GtkReliefStyle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_group_set_item_position(GtkToolItemGroupHandle group, GtkToolItemHandle item, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_group_set_label(GtkToolItemGroupHandle group, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_group_set_label_widget(GtkToolItemGroupHandle group, GtkWidgetHandle label_widget);

}

namespace MentorLake.Gtk;

public class GtkToolItemGroupHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkToolShellHandle
{
	public static MentorLake.Gtk.GtkToolItemGroupHandle New(string label)
	{
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_new(label);
	}

}

public static class GtkToolItemGroupHandleExtensions
{
	public static bool GetCollapsed(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_collapsed(group);
	}

	public static MentorLake.Gtk.GtkToolItemHandle GetDropItem(this MentorLake.Gtk.GtkToolItemGroupHandle group, int x, int y)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_drop_item(group, x, y);
	}

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_ellipsize(group);
	}

	public static MentorLake.Gtk.GtkReliefStyle GetHeaderRelief(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_header_relief(group);
	}

	public static int GetItemPosition(this MentorLake.Gtk.GtkToolItemGroupHandle group, MentorLake.Gtk.GtkToolItemHandle item)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_item_position(group, item);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_label(group);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_label_widget(group);
	}

	public static uint GetNItems(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_n_items(group);
	}

	public static MentorLake.Gtk.GtkToolItemHandle GetNthItem(this MentorLake.Gtk.GtkToolItemGroupHandle group, uint index)
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_nth_item(group, index);
	}

	public static T Insert<T>(this T group, MentorLake.Gtk.GtkToolItemHandle item, int position) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_insert(group, item, position);
		return group;
	}

	public static T SetCollapsed<T>(this T group, bool collapsed) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_collapsed(group, collapsed);
		return group;
	}

	public static T SetEllipsize<T>(this T group, MentorLake.Pango.PangoEllipsizeMode ellipsize) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_ellipsize(group, ellipsize);
		return group;
	}

	public static T SetHeaderRelief<T>(this T group, MentorLake.Gtk.GtkReliefStyle style) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_header_relief(group, style);
		return group;
	}

	public static T SetItemPosition<T>(this T group, MentorLake.Gtk.GtkToolItemHandle item, int position) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_item_position(group, item, position);
		return group;
	}

	public static T SetLabel<T>(this T group, string label) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_label(group, label);
		return group;
	}

	public static T SetLabelWidget<T>(this T group, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid || group.IsClosed) throw new Exception("Invalid or closed handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_label_widget(group, label_widget);
		return group;
	}

}

internal class GtkToolItemGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolItemGroupHandle gtk_tool_item_group_new(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_group_get_collapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolItemHandle gtk_tool_item_group_get_drop_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode gtk_tool_item_group_get_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkReliefStyle gtk_tool_item_group_get_header_relief([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tool_item_group_get_item_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_item_group_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_item_group_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_tool_item_group_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolItemHandle gtk_tool_item_group_get_nth_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, uint index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_group_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle item, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_group_set_collapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, bool collapsed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_group_set_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, MentorLake.Pango.PangoEllipsizeMode ellipsize);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_group_set_header_relief([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, MentorLake.Gtk.GtkReliefStyle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_group_set_item_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle item, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_group_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_group_set_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label_widget);

}

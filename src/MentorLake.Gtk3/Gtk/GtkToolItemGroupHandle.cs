namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkToolItemGroup is used together with #GtkToolPalette to add
/// #GtkToolItems to a palette like container with different
/// categories and drag and drop support.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkToolItemGroup has a single CSS node named toolitemgroup.
/// </para>
/// </summary>

public class GtkToolItemGroupHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkToolShellHandle
{
/// <summary>
/// <para>
/// Creates a new tool item group with label @label.
/// </para>
/// </summary>

/// <param name="label">
/// the label of the new group
/// </param>
/// <return>
/// a new #GtkToolItemGroup.
/// </return>

	public static MentorLake.Gtk.GtkToolItemGroupHandle New(string label)
	{
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_new(label);
	}

}

public static class GtkToolItemGroupHandleExtensions
{
/// <summary>
/// <para>
/// Gets whether @group is collapsed or expanded.
/// </para>
/// </summary>

/// <param name="group">
/// a GtkToolItemGroup
/// </param>
/// <return>
/// %TRUE if @group is collapsed, %FALSE if it is expanded
/// </return>

	public static bool GetCollapsed(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_collapsed(group);
	}

/// <summary>
/// <para>
/// Gets the tool item at position (x, y).
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="x">
/// the x position
/// </param>
/// <param name="y">
/// the y position
/// </param>
/// <return>
/// the #GtkToolItem at position (x, y)
/// </return>

	public static MentorLake.Gtk.GtkToolItemHandle GetDropItem(this MentorLake.Gtk.GtkToolItemGroupHandle group, int x, int y)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_drop_item(group, x, y);
	}

/// <summary>
/// <para>
/// Gets the ellipsization mode of @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <return>
/// the #PangoEllipsizeMode of @group
/// </return>

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_ellipsize(group);
	}

/// <summary>
/// <para>
/// Gets the relief mode of the header button of @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <return>
/// the #GtkReliefStyle
/// </return>

	public static MentorLake.Gtk.GtkReliefStyle GetHeaderRelief(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_header_relief(group);
	}

/// <summary>
/// <para>
/// Gets the position of @item in @group as index.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="item">
/// a #GtkToolItem
/// </param>
/// <return>
/// the index of @item in @group or -1 if @item is no child of @group
/// </return>

	public static int GetItemPosition(this MentorLake.Gtk.GtkToolItemGroupHandle group, MentorLake.Gtk.GtkToolItemHandle item)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_item_position(group, item);
	}

/// <summary>
/// <para>
/// Gets the label of @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <return>
/// the label of @group. The label is an internal string of @group
///     and must not be modified. Note that %NULL is returned if a custom
///     label has been set with gtk_tool_item_group_set_label_widget()
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_label(group);
	}

/// <summary>
/// <para>
/// Gets the label widget of @group.
/// See gtk_tool_item_group_set_label_widget().
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <return>
/// the label widget of @group
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_label_widget(group);
	}

/// <summary>
/// <para>
/// Gets the number of tool items in @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <return>
/// the number of tool items in @group
/// </return>

	public static uint GetNItems(this MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_n_items(group);
	}

/// <summary>
/// <para>
/// Gets the tool item at @index in group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="index">
/// the index
/// </param>
/// <return>
/// the #GtkToolItem at index
/// </return>

	public static MentorLake.Gtk.GtkToolItemHandle GetNthItem(this MentorLake.Gtk.GtkToolItemGroupHandle group, uint index)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		return GtkToolItemGroupHandleExterns.gtk_tool_item_group_get_nth_item(group, index);
	}

/// <summary>
/// <para>
/// Inserts @item at @position in the list of children of @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="item">
/// the #GtkToolItem to insert into @group
/// </param>
/// <param name="position">
/// the position of @item in @group, starting with 0.
///     The position -1 means end of list.
/// </param>

	public static T Insert<T>(this T group, MentorLake.Gtk.GtkToolItemHandle item, int position) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_insert(group, item, position);
		return group;
	}

/// <summary>
/// <para>
/// Sets whether the @group should be collapsed or expanded.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="collapsed">
/// whether the @group should be collapsed or expanded
/// </param>

	public static T SetCollapsed<T>(this T group, bool collapsed) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_collapsed(group, collapsed);
		return group;
	}

/// <summary>
/// <para>
/// Sets the ellipsization mode which should be used by labels in @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="ellipsize">
/// the #PangoEllipsizeMode labels in @group should use
/// </param>

	public static T SetEllipsize<T>(this T group, MentorLake.Pango.PangoEllipsizeMode ellipsize) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_ellipsize(group, ellipsize);
		return group;
	}

/// <summary>
/// <para>
/// Set the button relief of the group header.
/// See gtk_button_set_relief() for details.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="style">
/// the #GtkReliefStyle
/// </param>

	public static T SetHeaderRelief<T>(this T group, MentorLake.Gtk.GtkReliefStyle style) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_header_relief(group, style);
		return group;
	}

/// <summary>
/// <para>
/// Sets the position of @item in the list of children of @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="item">
/// the #GtkToolItem to move to a new position, should
///     be a child of @group.
/// </param>
/// <param name="position">
/// the new position of @item in @group, starting with 0.
///     The position -1 means end of list.
/// </param>

	public static T SetItemPosition<T>(this T group, MentorLake.Gtk.GtkToolItemHandle item, int position) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_item_position(group, item, position);
		return group;
	}

/// <summary>
/// <para>
/// Sets the label of the tool item group. The label is displayed in the header
/// of the group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="label">
/// the new human-readable label of of the group
/// </param>

	public static T SetLabel<T>(this T group, string label) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_label(group, label);
		return group;
	}

/// <summary>
/// <para>
/// Sets the label of the tool item group.
/// The label widget is displayed in the header of the group, in place
/// of the usual label.
/// </para>
/// </summary>

/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <param name="label_widget">
/// the widget to be displayed in place of the usual label
/// </param>

	public static T SetLabelWidget<T>(this T group, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkToolItemGroupHandle
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GtkToolItemGroupHandle)");
		GtkToolItemGroupHandleExterns.gtk_tool_item_group_set_label_widget(group, label_widget);
		return group;
	}

}

internal class GtkToolItemGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkToolItemGroupHandle gtk_tool_item_group_new(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_group_get_collapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_item_group_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_tool_item_group_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))]
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

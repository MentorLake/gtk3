namespace MentorLake.Gtk;

public class GtkToolPaletteHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkScrollableHandle
{
	public static MentorLake.Gtk.GtkToolPaletteHandle New()
	{
		return GtkToolPaletteHandleExterns.gtk_tool_palette_new();
	}

	public static MentorLake.Gtk.GtkTargetEntryHandle GetDragTargetGroup()
	{
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drag_target_group();
	}

	public static MentorLake.Gtk.GtkTargetEntryHandle GetDragTargetItem()
	{
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drag_target_item();
	}

}

public static class GtkToolPaletteHandleExtensions
{
	public static T AddDragDest<T>(this T palette, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDestDefaults flags, MentorLake.Gtk.GtkToolPaletteDragTargets targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_add_drag_dest(palette, widget, flags, targets, actions);
		return palette;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetDragItem(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkSelectionDataHandle selection)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drag_item(palette, selection);
	}

	public static MentorLake.Gtk.GtkToolItemGroupHandle GetDropGroup(this MentorLake.Gtk.GtkToolPaletteHandle palette, int x, int y)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drop_group(palette, x, y);
	}

	public static MentorLake.Gtk.GtkToolItemHandle GetDropItem(this MentorLake.Gtk.GtkToolPaletteHandle palette, int x, int y)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drop_item(palette, x, y);
	}

	public static bool GetExclusive(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_exclusive(palette, group);
	}

	public static bool GetExpand(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_expand(palette, group);
	}

	public static int GetGroupPosition(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_group_position(palette, group);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_hadjustment(palette);
	}

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_icon_size(palette);
	}

	public static MentorLake.Gtk.GtkToolbarStyle GetStyle(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_style(palette);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_vadjustment(palette);
	}

	public static T SetDragSource<T>(this T palette, MentorLake.Gtk.GtkToolPaletteDragTargets targets) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_drag_source(palette, targets);
		return palette;
	}

	public static T SetExclusive<T>(this T palette, MentorLake.Gtk.GtkToolItemGroupHandle group, bool exclusive) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_exclusive(palette, group, exclusive);
		return palette;
	}

	public static T SetExpand<T>(this T palette, MentorLake.Gtk.GtkToolItemGroupHandle group, bool expand) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_expand(palette, group, expand);
		return palette;
	}

	public static T SetGroupPosition<T>(this T palette, MentorLake.Gtk.GtkToolItemGroupHandle group, int position) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_group_position(palette, group, position);
		return palette;
	}

	public static T SetIconSize<T>(this T palette, MentorLake.Gtk.GtkIconSize icon_size) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_icon_size(palette, icon_size);
		return palette;
	}

	public static T SetStyle<T>(this T palette, MentorLake.Gtk.GtkToolbarStyle style) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_style(palette, style);
		return palette;
	}

	public static T UnsetIconSize<T>(this T palette) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_unset_icon_size(palette);
		return palette;
	}

	public static T UnsetStyle<T>(this T palette) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_unset_style(palette);
		return palette;
	}

}

internal class GtkToolPaletteHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))]
	internal static extern MentorLake.Gtk.GtkToolPaletteHandle gtk_tool_palette_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_add_drag_dest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDestDefaults flags, MentorLake.Gtk.GtkToolPaletteDragTargets targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_palette_get_drag_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkToolItemGroupHandle gtk_tool_palette_get_drop_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, int x, int y);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))]
	internal static extern MentorLake.Gtk.GtkToolItemHandle gtk_tool_palette_get_drop_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_palette_get_exclusive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_palette_get_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tool_palette_get_group_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_tool_palette_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_tool_palette_get_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolbarStyle gtk_tool_palette_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_tool_palette_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_set_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolPaletteDragTargets targets);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_set_exclusive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, bool exclusive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_set_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_set_group_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemGroupHandle>))] MentorLake.Gtk.GtkToolItemGroupHandle group, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_set_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkIconSize icon_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_set_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolbarStyle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_unset_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_palette_unset_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolPaletteHandle>))] MentorLake.Gtk.GtkToolPaletteHandle palette);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetEntryHandle gtk_tool_palette_get_drag_target_group();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetEntryHandle gtk_tool_palette_get_drag_target_item();

}

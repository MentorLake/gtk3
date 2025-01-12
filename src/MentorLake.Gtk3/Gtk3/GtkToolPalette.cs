namespace MentorLake.Gtk3.Gtk3;

public class GtkToolPaletteHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkScrollableHandle
{
	public static GtkToolPaletteHandle New()
	{
		return GtkToolPaletteExterns.gtk_tool_palette_new();
	}

	public static GtkTargetEntryHandle GetDragTargetGroup()
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_drag_target_group();
	}

	public static GtkTargetEntryHandle GetDragTargetItem()
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_drag_target_item();
	}

}

public static class GtkToolPaletteHandleExtensions
{
	public static GtkToolPaletteHandle AddDragDest(this GtkToolPaletteHandle palette, GtkWidgetHandle widget, GtkDestDefaults flags, GtkToolPaletteDragTargets targets, GdkDragAction actions)
	{
		GtkToolPaletteExterns.gtk_tool_palette_add_drag_dest(palette, widget, flags, targets, actions);
		return palette;
	}

	public static GtkWidgetHandle GetDragItem(this GtkToolPaletteHandle palette, GtkSelectionDataHandle selection)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_drag_item(palette, selection);
	}

	public static GtkToolItemGroupHandle GetDropGroup(this GtkToolPaletteHandle palette, int x, int y)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_drop_group(palette, x, y);
	}

	public static GtkToolItemHandle GetDropItem(this GtkToolPaletteHandle palette, int x, int y)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_drop_item(palette, x, y);
	}

	public static bool GetExclusive(this GtkToolPaletteHandle palette, GtkToolItemGroupHandle group)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_exclusive(palette, group);
	}

	public static bool GetExpand(this GtkToolPaletteHandle palette, GtkToolItemGroupHandle group)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_expand(palette, group);
	}

	public static int GetGroupPosition(this GtkToolPaletteHandle palette, GtkToolItemGroupHandle group)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_group_position(palette, group);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkToolPaletteHandle palette)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_hadjustment(palette);
	}

	public static GtkIconSize GetIconSize(this GtkToolPaletteHandle palette)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_icon_size(palette);
	}

	public static GtkToolbarStyle GetStyle(this GtkToolPaletteHandle palette)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_style(palette);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkToolPaletteHandle palette)
	{
		return GtkToolPaletteExterns.gtk_tool_palette_get_vadjustment(palette);
	}

	public static GtkToolPaletteHandle SetDragSource(this GtkToolPaletteHandle palette, GtkToolPaletteDragTargets targets)
	{
		GtkToolPaletteExterns.gtk_tool_palette_set_drag_source(palette, targets);
		return palette;
	}

	public static GtkToolPaletteHandle SetExclusive(this GtkToolPaletteHandle palette, GtkToolItemGroupHandle group, bool exclusive)
	{
		GtkToolPaletteExterns.gtk_tool_palette_set_exclusive(palette, group, exclusive);
		return palette;
	}

	public static GtkToolPaletteHandle SetExpand(this GtkToolPaletteHandle palette, GtkToolItemGroupHandle group, bool expand)
	{
		GtkToolPaletteExterns.gtk_tool_palette_set_expand(palette, group, expand);
		return palette;
	}

	public static GtkToolPaletteHandle SetGroupPosition(this GtkToolPaletteHandle palette, GtkToolItemGroupHandle group, int position)
	{
		GtkToolPaletteExterns.gtk_tool_palette_set_group_position(palette, group, position);
		return palette;
	}

	public static GtkToolPaletteHandle SetIconSize(this GtkToolPaletteHandle palette, GtkIconSize icon_size)
	{
		GtkToolPaletteExterns.gtk_tool_palette_set_icon_size(palette, icon_size);
		return palette;
	}

	public static GtkToolPaletteHandle SetStyle(this GtkToolPaletteHandle palette, GtkToolbarStyle style)
	{
		GtkToolPaletteExterns.gtk_tool_palette_set_style(palette, style);
		return palette;
	}

	public static GtkToolPaletteHandle UnsetIconSize(this GtkToolPaletteHandle palette)
	{
		GtkToolPaletteExterns.gtk_tool_palette_unset_icon_size(palette);
		return palette;
	}

	public static GtkToolPaletteHandle UnsetStyle(this GtkToolPaletteHandle palette)
	{
		GtkToolPaletteExterns.gtk_tool_palette_unset_style(palette);
		return palette;
	}

}

internal class GtkToolPaletteExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolPaletteHandle gtk_tool_palette_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_add_drag_dest(GtkToolPaletteHandle palette, GtkWidgetHandle widget, GtkDestDefaults flags, GtkToolPaletteDragTargets targets, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tool_palette_get_drag_item(GtkToolPaletteHandle palette, GtkSelectionDataHandle selection);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolItemGroupHandle gtk_tool_palette_get_drop_group(GtkToolPaletteHandle palette, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolItemHandle gtk_tool_palette_get_drop_item(GtkToolPaletteHandle palette, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_palette_get_exclusive(GtkToolPaletteHandle palette, GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_palette_get_expand(GtkToolPaletteHandle palette, GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_tool_palette_get_group_position(GtkToolPaletteHandle palette, GtkToolItemGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_tool_palette_get_hadjustment(GtkToolPaletteHandle palette);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSize gtk_tool_palette_get_icon_size(GtkToolPaletteHandle palette);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolbarStyle gtk_tool_palette_get_style(GtkToolPaletteHandle palette);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_tool_palette_get_vadjustment(GtkToolPaletteHandle palette);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_set_drag_source(GtkToolPaletteHandle palette, GtkToolPaletteDragTargets targets);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_set_exclusive(GtkToolPaletteHandle palette, GtkToolItemGroupHandle group, bool exclusive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_set_expand(GtkToolPaletteHandle palette, GtkToolItemGroupHandle group, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_set_group_position(GtkToolPaletteHandle palette, GtkToolItemGroupHandle group, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_set_icon_size(GtkToolPaletteHandle palette, GtkIconSize icon_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_set_style(GtkToolPaletteHandle palette, GtkToolbarStyle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_unset_icon_size(GtkToolPaletteHandle palette);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_palette_unset_style(GtkToolPaletteHandle palette);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetEntryHandle gtk_tool_palette_get_drag_target_group();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetEntryHandle gtk_tool_palette_get_drag_target_item();

}

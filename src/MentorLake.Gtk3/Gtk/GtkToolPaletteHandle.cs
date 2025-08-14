namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkToolPalette allows you to add #GtkToolItems to a palette-like
/// container with different categories and drag and drop support.
/// </para>
/// <para>
/// A #GtkToolPalette is created with a call to gtk_tool_palette_new().
/// </para>
/// <para>
/// #GtkToolItems cannot be added directly to a #GtkToolPalette -
/// instead they are added to a #GtkToolItemGroup which can than be added
/// to a #GtkToolPalette. To add a #GtkToolItemGroup to a #GtkToolPalette,
/// use gtk_container_add().
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkWidget *palette, *group;
/// GtkToolItem *item;
/// </para>
/// <para>
/// palette = gtk_tool_palette_new ();
/// group = gtk_tool_item_group_new (_("Test Category"));
/// gtk_container_add (GTK_CONTAINER (palette), group);
/// </para>
/// <para>
/// item = gtk_tool_button_new (NULL, _("_Open"));
/// gtk_tool_button_set_icon_name (GTK_TOOL_BUTTON (item), "document-open");
/// gtk_tool_item_group_insert (GTK_TOOL_ITEM_GROUP (group), item, -1);
/// ]|
/// </para>
/// <para>
/// The easiest way to use drag and drop with #GtkToolPalette is to call
/// gtk_tool_palette_add_drag_dest() with the desired drag source @palette
/// and the desired drag target @widget. Then gtk_tool_palette_get_drag_item()
/// can be used to get the dragged item in the #GtkWidget::drag-data-received
/// signal handler of the drag target.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// passive_canvas_drag_data_received (GtkWidget        *widget,
///                                    GdkDragContext   *context,
///                                    gint              x,
///                                    gint              y,
///                                    GtkSelectionData *selection,
///                                    guint             info,
///                                    guint             time,
///                                    gpointer          data)
/// {
///   GtkWidget *palette;
///   GtkWidget *item;
/// </para>
/// <para>
///   // Get the dragged item
///   palette = gtk_widget_get_ancestor (gtk_drag_get_source_widget (context),
///                                      GTK_TYPE_TOOL_PALETTE);
///   if (palette != NULL)
///     item = gtk_tool_palette_get_drag_item (GTK_TOOL_PALETTE (palette),
///                                            selection);
/// </para>
/// <para>
///   // Do something with item
/// }
/// </para>
/// <para>
/// GtkWidget *target, palette;
/// </para>
/// <para>
/// palette = gtk_tool_palette_new ();
/// target = gtk_drawing_area_new ();
/// </para>
/// <para>
/// g_signal_connect (G_OBJECT (target), "drag-data-received",
///                   G_CALLBACK (passive_canvas_drag_data_received), NULL);
/// gtk_tool_palette_add_drag_dest (GTK_TOOL_PALETTE (palette), target,
///                                 GTK_DEST_DEFAULT_ALL,
///                                 GTK_TOOL_PALETTE_DRAG_ITEMS,
///                                 GDK_ACTION_COPY);
/// ]|
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkToolPalette has a single CSS node named toolpalette.
/// </para>
/// </summary>

public class GtkToolPaletteHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkScrollableHandle
{
/// <summary>
/// <para>
/// Creates a new tool palette.
/// </para>
/// </summary>

/// <return>
/// a new #GtkToolPalette
/// </return>

	public static MentorLake.Gtk.GtkToolPaletteHandle New()
	{
		return GtkToolPaletteHandleExterns.gtk_tool_palette_new();
	}

/// <summary>
/// <para>
/// Get the target entry for a dragged #GtkToolItemGroup.
/// </para>
/// </summary>

/// <return>
/// the #GtkTargetEntry for a dragged group
/// </return>

	public static MentorLake.Gtk.GtkTargetEntryHandle GetDragTargetGroup()
	{
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drag_target_group();
	}

/// <summary>
/// <para>
/// Gets the target entry for a dragged #GtkToolItem.
/// </para>
/// </summary>

/// <return>
/// the #GtkTargetEntry for a dragged item.
/// </return>

	public static MentorLake.Gtk.GtkTargetEntryHandle GetDragTargetItem()
	{
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drag_target_item();
	}

}

public static class GtkToolPaletteHandleExtensions
{
/// <summary>
/// <para>
/// Sets @palette as drag source (see gtk_tool_palette_set_drag_source())
/// and sets @widget as a drag destination for drags from @palette.
/// See gtk_drag_dest_set().
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="widget">
/// a #GtkWidget which should be a drag destination for @palette
/// </param>
/// <param name="flags">
/// the flags that specify what actions GTK+ should take for drops
///     on that widget
/// </param>
/// <param name="targets">
/// the #GtkToolPaletteDragTargets which the widget
///     should support
/// </param>
/// <param name="actions">
/// the #GdkDragActions which the widget should suppport
/// </param>

	public static T AddDragDest<T>(this T palette, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDestDefaults flags, MentorLake.Gtk.GtkToolPaletteDragTargets targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_add_drag_dest(palette, widget, flags, targets, actions);
		return palette;
	}

/// <summary>
/// <para>
/// Get the dragged item from the selection.
/// This could be a #GtkToolItem or a #GtkToolItemGroup.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="selection">
/// a #GtkSelectionData
/// </param>
/// <return>
/// the dragged item in selection
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetDragItem(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkSelectionDataHandle selection)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drag_item(palette, selection);
	}

/// <summary>
/// <para>
/// Gets the group at position (x, y).
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="x">
/// the x position
/// </param>
/// <param name="y">
/// the y position
/// </param>
/// <return>
/// the #GtkToolItemGroup at position
/// or %NULL if there is no such group
/// </return>

	public static MentorLake.Gtk.GtkToolItemGroupHandle GetDropGroup(this MentorLake.Gtk.GtkToolPaletteHandle palette, int x, int y)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drop_group(palette, x, y);
	}

/// <summary>
/// <para>
/// Gets the item at position (x, y).
/// See gtk_tool_palette_get_drop_group().
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="x">
/// the x position
/// </param>
/// <param name="y">
/// the y position
/// </param>
/// <return>
/// the #GtkToolItem at position or %NULL if there is no such item
/// </return>

	public static MentorLake.Gtk.GtkToolItemHandle GetDropItem(this MentorLake.Gtk.GtkToolPaletteHandle palette, int x, int y)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_drop_item(palette, x, y);
	}

/// <summary>
/// <para>
/// Gets whether @group is exclusive or not.
/// See gtk_tool_palette_set_exclusive().
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="group">
/// a #GtkToolItemGroup which is a child of palette
/// </param>
/// <return>
/// %TRUE if @group is exclusive
/// </return>

	public static bool GetExclusive(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_exclusive(palette, group);
	}

/// <summary>
/// <para>
/// Gets whether group should be given extra space.
/// See gtk_tool_palette_set_expand().
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="group">
/// a #GtkToolItemGroup which is a child of palette
/// </param>
/// <return>
/// %TRUE if group should be given extra space, %FALSE otherwise
/// </return>

	public static bool GetExpand(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_expand(palette, group);
	}

/// <summary>
/// <para>
/// Gets the position of @group in @palette as index.
/// See gtk_tool_palette_set_group_position().
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="group">
/// a #GtkToolItemGroup
/// </param>
/// <return>
/// the index of group or -1 if @group is not a child of @palette
/// </return>

	public static int GetGroupPosition(this MentorLake.Gtk.GtkToolPaletteHandle palette, MentorLake.Gtk.GtkToolItemGroupHandle group)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_group_position(palette, group);
	}

/// <summary>
/// <para>
/// Gets the horizontal adjustment of the tool palette.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <return>
/// the horizontal adjustment of @palette
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_hadjustment(palette);
	}

/// <summary>
/// <para>
/// Gets the size of icons in the tool palette.
/// See gtk_tool_palette_set_icon_size().
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <return>
/// the #GtkIconSize of icons in the tool palette
/// </return>

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_icon_size(palette);
	}

/// <summary>
/// <para>
/// Gets the style (icons, text or both) of items in the tool palette.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <return>
/// the #GtkToolbarStyle of items in the tool palette.
/// </return>

	public static MentorLake.Gtk.GtkToolbarStyle GetStyle(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_style(palette);
	}

/// <summary>
/// <para>
/// Gets the vertical adjustment of the tool palette.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <return>
/// the vertical adjustment of @palette
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkToolPaletteHandle palette)
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		return GtkToolPaletteHandleExterns.gtk_tool_palette_get_vadjustment(palette);
	}

/// <summary>
/// <para>
/// Sets the tool palette as a drag source.
/// Enables all groups and items in the tool palette as drag sources
/// on button 1 and button 3 press with copy and move actions.
/// See gtk_drag_source_set().
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="targets">
/// the #GtkToolPaletteDragTargets
///     which the widget should support
/// </param>

	public static T SetDragSource<T>(this T palette, MentorLake.Gtk.GtkToolPaletteDragTargets targets) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_drag_source(palette, targets);
		return palette;
	}

/// <summary>
/// <para>
/// Sets whether the group should be exclusive or not.
/// If an exclusive group is expanded all other groups are collapsed.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="group">
/// a #GtkToolItemGroup which is a child of palette
/// </param>
/// <param name="exclusive">
/// whether the group should be exclusive or not
/// </param>

	public static T SetExclusive<T>(this T palette, MentorLake.Gtk.GtkToolItemGroupHandle group, bool exclusive) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_exclusive(palette, group, exclusive);
		return palette;
	}

/// <summary>
/// <para>
/// Sets whether the group should be given extra space.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="group">
/// a #GtkToolItemGroup which is a child of palette
/// </param>
/// <param name="expand">
/// whether the group should be given extra space
/// </param>

	public static T SetExpand<T>(this T palette, MentorLake.Gtk.GtkToolItemGroupHandle group, bool expand) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_expand(palette, group, expand);
		return palette;
	}

/// <summary>
/// <para>
/// Sets the position of the group as an index of the tool palette.
/// If position is 0 the group will become the first child, if position is
/// -1 it will become the last child.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="group">
/// a #GtkToolItemGroup which is a child of palette
/// </param>
/// <param name="position">
/// a new index for group
/// </param>

	public static T SetGroupPosition<T>(this T palette, MentorLake.Gtk.GtkToolItemGroupHandle group, int position) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_group_position(palette, group, position);
		return palette;
	}

/// <summary>
/// <para>
/// Sets the size of icons in the tool palette.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="icon_size">
/// the #GtkIconSize that icons in the tool
///     palette shall have
/// </param>

	public static T SetIconSize<T>(this T palette, MentorLake.Gtk.GtkIconSize icon_size) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_icon_size(palette, icon_size);
		return palette;
	}

/// <summary>
/// <para>
/// Sets the style (text, icons or both) of items in the tool palette.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>
/// <param name="style">
/// the #GtkToolbarStyle that items in the tool palette shall have
/// </param>

	public static T SetStyle<T>(this T palette, MentorLake.Gtk.GtkToolbarStyle style) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_set_style(palette, style);
		return palette;
	}

/// <summary>
/// <para>
/// Unsets the tool palette icon size set with gtk_tool_palette_set_icon_size(),
/// so that user preferences will be used to determine the icon size.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>

	public static T UnsetIconSize<T>(this T palette) where T : GtkToolPaletteHandle
	{
		if (palette.IsInvalid) throw new Exception("Invalid handle (GtkToolPaletteHandle)");
		GtkToolPaletteHandleExterns.gtk_tool_palette_unset_icon_size(palette);
		return palette;
	}

/// <summary>
/// <para>
/// Unsets a toolbar style set with gtk_tool_palette_set_style(),
/// so that user preferences will be used to determine the toolbar style.
/// </para>
/// </summary>

/// <param name="palette">
/// a #GtkToolPalette
/// </param>

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

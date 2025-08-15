namespace MentorLake.Gtk;


public class GtkButtonBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkButtonBox.
/// </para>
/// </summary>

/// <param name="orientation">
/// the box&apos;s orientation.
/// </param>
/// <return>
/// a new #GtkButtonBox.
/// </return>

	public static MentorLake.Gtk.GtkButtonBoxHandle New(MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkButtonBoxHandleExterns.gtk_button_box_new(orientation);
	}

}

public static class GtkButtonBoxHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether the child is exempted from homogenous
/// sizing.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkButtonBox
/// </param>
/// <param name="child">
/// a child of @widget
/// </param>
/// <return>
/// %TRUE if the child is not subject to homogenous sizing
/// </return>

	public static bool GetChildNonHomogeneous(this MentorLake.Gtk.GtkButtonBoxHandle widget, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkButtonBoxHandle)");
		return GtkButtonBoxHandleExterns.gtk_button_box_get_child_non_homogeneous(widget, child);
	}

/// <summary>
/// <para>
/// Returns whether @child should appear in a secondary group of children.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkButtonBox
/// </param>
/// <param name="child">
/// a child of @widget
/// </param>
/// <return>
/// whether @child should appear in a secondary group of children.
/// </return>

	public static bool GetChildSecondary(this MentorLake.Gtk.GtkButtonBoxHandle widget, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkButtonBoxHandle)");
		return GtkButtonBoxHandleExterns.gtk_button_box_get_child_secondary(widget, child);
	}

/// <summary>
/// <para>
/// Retrieves the method being used to arrange the buttons in a button box.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkButtonBox
/// </param>
/// <return>
/// the method used to lay out buttons in @widget.
/// </return>

	public static MentorLake.Gtk.GtkButtonBoxStyle GetLayout(this MentorLake.Gtk.GtkButtonBoxHandle widget)
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkButtonBoxHandle)");
		return GtkButtonBoxHandleExterns.gtk_button_box_get_layout(widget);
	}

/// <summary>
/// <para>
/// Sets whether the child is exempted from homogeous sizing.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkButtonBox
/// </param>
/// <param name="child">
/// a child of @widget
/// </param>
/// <param name="non_homogeneous">
/// the new value
/// </param>

	public static T SetChildNonHomogeneous<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle child, bool non_homogeneous) where T : GtkButtonBoxHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkButtonBoxHandle)");
		GtkButtonBoxHandleExterns.gtk_button_box_set_child_non_homogeneous(widget, child, non_homogeneous);
		return widget;
	}

/// <summary>
/// <para>
/// Sets whether @child should appear in a secondary group of children.
/// A typical use of a secondary child is the help button in a dialog.
/// </para>
/// <para>
/// This group appears after the other children if the style
/// is %GTK_BUTTONBOX_START, %GTK_BUTTONBOX_SPREAD or
/// %GTK_BUTTONBOX_EDGE, and before the other children if the style
/// is %GTK_BUTTONBOX_END. For horizontal button boxes, the definition
/// of before/after depends on direction of the widget (see
/// gtk_widget_set_direction()). If the style is %GTK_BUTTONBOX_START
/// or %GTK_BUTTONBOX_END, then the secondary children are aligned at
/// the other end of the button box from the main children. For the
/// other styles, they appear immediately next to the main children.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkButtonBox
/// </param>
/// <param name="child">
/// a child of @widget
/// </param>
/// <param name="is_secondary">
/// if %TRUE, the @child appears in a secondary group of the
///                button box.
/// </param>

	public static T SetChildSecondary<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle child, bool is_secondary) where T : GtkButtonBoxHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkButtonBoxHandle)");
		GtkButtonBoxHandleExterns.gtk_button_box_set_child_secondary(widget, child, is_secondary);
		return widget;
	}

/// <summary>
/// <para>
/// Changes the way buttons are arranged in their container.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkButtonBox
/// </param>
/// <param name="layout_style">
/// the new layout style
/// </param>

	public static T SetLayout<T>(this T widget, MentorLake.Gtk.GtkButtonBoxStyle layout_style) where T : GtkButtonBoxHandle
	{
		if (widget.IsInvalid) throw new Exception("Invalid handle (GtkButtonBoxHandle)");
		GtkButtonBoxHandleExterns.gtk_button_box_set_layout(widget, layout_style);
		return widget;
	}

}

internal class GtkButtonBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkButtonBoxHandle gtk_button_box_new(MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_box_get_child_non_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_box_get_child_secondary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonBoxStyle gtk_button_box_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_box_set_child_non_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool non_homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_box_set_child_secondary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool is_secondary);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_box_set_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, MentorLake.Gtk.GtkButtonBoxStyle layout_style);

}

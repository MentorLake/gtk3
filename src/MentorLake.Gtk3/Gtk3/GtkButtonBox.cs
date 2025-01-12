namespace MentorLake.Gtk3.Gtk3;

public class GtkButtonBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkButtonBoxHandle New(GtkOrientation orientation)
	{
		return GtkButtonBoxExterns.gtk_button_box_new(orientation);
	}

}

public static class GtkButtonBoxHandleExtensions
{
	public static bool GetChildNonHomogeneous(this GtkButtonBoxHandle widget, GtkWidgetHandle child)
	{
		return GtkButtonBoxExterns.gtk_button_box_get_child_non_homogeneous(widget, child);
	}

	public static bool GetChildSecondary(this GtkButtonBoxHandle widget, GtkWidgetHandle child)
	{
		return GtkButtonBoxExterns.gtk_button_box_get_child_secondary(widget, child);
	}

	public static GtkButtonBoxStyle GetLayout(this GtkButtonBoxHandle widget)
	{
		return GtkButtonBoxExterns.gtk_button_box_get_layout(widget);
	}

	public static T SetChildNonHomogeneous<T>(this T widget, GtkWidgetHandle child, bool non_homogeneous) where T : GtkButtonBoxHandle
	{
		GtkButtonBoxExterns.gtk_button_box_set_child_non_homogeneous(widget, child, non_homogeneous);
		return widget;
	}

	public static T SetChildSecondary<T>(this T widget, GtkWidgetHandle child, bool is_secondary) where T : GtkButtonBoxHandle
	{
		GtkButtonBoxExterns.gtk_button_box_set_child_secondary(widget, child, is_secondary);
		return widget;
	}

	public static T SetLayout<T>(this T widget, GtkButtonBoxStyle layout_style) where T : GtkButtonBoxHandle
	{
		GtkButtonBoxExterns.gtk_button_box_set_layout(widget, layout_style);
		return widget;
	}

}

internal class GtkButtonBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkButtonBoxHandle gtk_button_box_new(GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_button_box_get_child_non_homogeneous(GtkButtonBoxHandle widget, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_button_box_get_child_secondary(GtkButtonBoxHandle widget, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkButtonBoxStyle gtk_button_box_get_layout(GtkButtonBoxHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_box_set_child_non_homogeneous(GtkButtonBoxHandle widget, GtkWidgetHandle child, bool non_homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_box_set_child_secondary(GtkButtonBoxHandle widget, GtkWidgetHandle child, bool is_secondary);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_box_set_layout(GtkButtonBoxHandle widget, GtkButtonBoxStyle layout_style);

}

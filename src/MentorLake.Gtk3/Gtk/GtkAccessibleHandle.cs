namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkAccessible class is the base class for accessible
/// implementations for #GtkWidget subclasses. It is a thin
/// wrapper around #AtkObject, which adds facilities for associating
/// a widget with its accessible object.
/// </para>
/// <para>
/// An accessible implementation for a third-party widget should
/// derive from #GtkAccessible and implement the suitable interfaces
/// from ATK, such as #AtkText or #AtkSelection. To establish
/// the connection between the widget class and its corresponding
/// acccessible implementation, override the get_accessible vfunc
/// in #GtkWidgetClass.
/// </para>
/// </summary>

public class GtkAccessibleHandle : AtkObjectHandle
{
}

public static class GtkAccessibleHandleExtensions
{
/// <summary>
/// <para>
/// This function specifies the callback function to be called
/// when the widget corresponding to a GtkAccessible is destroyed.
/// </para>
/// </summary>

/// <param name="accessible">
/// a #GtkAccessible
/// </param>

	public static T ConnectWidgetDestroyed<T>(this T accessible) where T : GtkAccessibleHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (GtkAccessibleHandle)");
		GtkAccessibleHandleExterns.gtk_accessible_connect_widget_destroyed(accessible);
		return accessible;
	}

/// <summary>
/// <para>
/// Gets the #GtkWidget corresponding to the #GtkAccessible.
/// The returned widget does not have a reference added, so
/// you do not need to unref it.
/// </para>
/// </summary>

/// <param name="accessible">
/// a #GtkAccessible
/// </param>
/// <return>
/// pointer to the #GtkWidget
///     corresponding to the #GtkAccessible, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkAccessibleHandle accessible)
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (GtkAccessibleHandle)");
		return GtkAccessibleHandleExterns.gtk_accessible_get_widget(accessible);
	}

/// <summary>
/// <para>
/// Sets the #GtkWidget corresponding to the #GtkAccessible.
/// </para>
/// <para>
/// @accessible will not hold a reference to @widget.
/// It is the caller’s responsibility to ensure that when @widget
/// is destroyed, the widget is unset by calling this function
/// again with @widget set to %NULL.
/// </para>
/// </summary>

/// <param name="accessible">
/// a #GtkAccessible
/// </param>
/// <param name="widget">
/// a #GtkWidget or %NULL to unset
/// </param>

	public static T SetWidget<T>(this T accessible, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkAccessibleHandle
	{
		if (accessible.IsInvalid) throw new Exception("Invalid handle (GtkAccessibleHandle)");
		GtkAccessibleHandleExterns.gtk_accessible_set_widget(accessible, widget);
		return accessible;
	}

}

internal class GtkAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accessible_connect_widget_destroyed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccessibleHandle>))] MentorLake.Gtk.GtkAccessibleHandle accessible);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_accessible_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccessibleHandle>))] MentorLake.Gtk.GtkAccessibleHandle accessible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accessible_set_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccessibleHandle>))] MentorLake.Gtk.GtkAccessibleHandle accessible, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}

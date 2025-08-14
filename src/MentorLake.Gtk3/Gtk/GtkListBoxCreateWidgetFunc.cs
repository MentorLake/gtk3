namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Called for list boxes that are bound to a #GListModel with
/// gtk_list_box_bind_model() for each item that gets added to the model.
/// </para>
/// <para>
/// Versions of GTK+ prior to 3.18 called gtk_widget_show_all() on the rows
/// created by the GtkListBoxCreateWidgetFunc, but this forced all widgets
/// inside the row to be shown, and is no longer the case. Applications should
/// be updated to show the desired row widgets.
/// </para>
/// </summary>

/// <param name="item">
/// the item from the model for which to create a widget for
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// a #GtkWidget that represents @item
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gtk.GtkWidgetHandle GtkListBoxCreateWidgetFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item, IntPtr user_data);

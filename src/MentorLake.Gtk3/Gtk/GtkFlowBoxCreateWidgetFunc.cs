namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Called for flow boxes that are bound to a #GListModel with
/// gtk_flow_box_bind_model() for each item that gets added to the model.
/// </para>
/// </summary>

/// <param name="item">
/// the item from the model for which to create a widget for
/// </param>
/// <param name="user_data">
/// user data from gtk_flow_box_bind_model()
/// </param>
/// <return>
/// a #GtkWidget that represents @item
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gtk.GtkWidgetHandle GtkFlowBoxCreateWidgetFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item, IntPtr user_data);

namespace MentorLake.Gtk;


/// <param name="tag">
/// the #GtkTextTag
/// </param>
/// <param name="data">
/// data passed to gtk_text_tag_table_foreach()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTextTagTableForeach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, IntPtr data);

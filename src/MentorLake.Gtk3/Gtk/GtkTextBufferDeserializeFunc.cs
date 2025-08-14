namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function that is called to deserialize rich text that has been
/// serialized with gtk_text_buffer_serialize(), and insert it at @iter.
/// </para>
/// </summary>

/// <param name="register_buffer">
/// the #GtkTextBuffer the format is registered with
/// </param>
/// <param name="content_buffer">
/// the #GtkTextBuffer to deserialize into
/// </param>
/// <param name="iter">
/// insertion point for the deserialized text
/// </param>
/// <param name="data">
/// data to deserialize
/// </param>
/// <param name="length">
/// length of @data
/// </param>
/// <param name="create_tags">
/// %TRUE if deserializing may create tags
/// </param>
/// <param name="user_data">
/// user data that was specified when registering the format
/// </param>
/// <return>
/// %TRUE on success, %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTextBufferDeserializeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle register_buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle content_buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, byte[] data, UIntPtr length, bool create_tags, IntPtr user_data);

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function that is called to serialize the content of a text buffer.
/// It must return the serialized form of the content.
/// </para>
/// </summary>

/// <param name="register_buffer">
/// the #GtkTextBuffer for which the format is registered
/// </param>
/// <param name="content_buffer">
/// the #GtkTextBuffer to serialize
/// </param>
/// <param name="start">
/// start of the block of text to serialize
/// </param>
/// <param name="end">
/// end of the block of text to serialize
/// </param>
/// <param name="length">
/// return location for the length of the serialized data
/// </param>
/// <param name="user_data">
/// user data that was specified when registering the format
/// </param>
/// <return>
/// a newly-allocated array of guint8
/// which contains the serialized data, or %NULL if an error occurred
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate byte[] GtkTextBufferSerializeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle register_buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle content_buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, out UIntPtr length, IntPtr user_data);

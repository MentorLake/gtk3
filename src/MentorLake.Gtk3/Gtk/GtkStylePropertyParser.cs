namespace MentorLake.Gtk;


/// <param name="@string">
/// </param>
/// <param name="value">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkStylePropertyParser(string @string, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

namespace MentorLake.Gtk;


/// <param name="screen">
/// </param>
/// <param name="colors">
/// Array of colors
/// </param>
/// <param name="n_colors">
/// Number of colors in the array
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkColorSelectionChangePaletteWithScreenFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, MentorLake.Gdk.GdkColor[] colors, int n_colors);

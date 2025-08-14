namespace MentorLake.Gtk;


/// <param name="colors">
/// Array of colors
/// </param>
/// <param name="n_colors">
/// Number of colors in the array
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkColorSelectionChangePaletteFunc(MentorLake.Gdk.GdkColor[] colors, int n_colors);

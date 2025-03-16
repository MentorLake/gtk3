namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkColorSelectionChangePaletteFunc(MentorLake.Gdk.GdkColor[] colors, int n_colors);

namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkColorSelectionChangePaletteFunc(GdkColor[] colors, int n_colors);

namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkAccelMapForeach(IntPtr data, string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, bool changed);

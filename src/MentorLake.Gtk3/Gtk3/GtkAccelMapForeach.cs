namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkAccelMapForeach(IntPtr data, string accel_path, uint accel_key, GdkModifierType accel_mods, bool changed);

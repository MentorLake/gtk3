namespace MentorLake.Gtk;


/// <param name="data">
/// User data passed to gtk_accel_map_foreach() or
///  gtk_accel_map_foreach_unfiltered()
/// </param>
/// <param name="accel_path">
/// Accel path of the current accelerator
/// </param>
/// <param name="accel_key">
/// Key of the current accelerator
/// </param>
/// <param name="accel_mods">
/// Modifiers of the current accelerator
/// </param>
/// <param name="changed">
/// Changed flag of the accelerator (if %TRUE, accelerator has changed
///  during runtime and would need to be saved during an accelerator dump)
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkAccelMapForeach(IntPtr data, string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, bool changed);

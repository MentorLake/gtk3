namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Each GTK+ module must have a function gtk_module_init() with this prototype.
/// This function is called after loading the module.
/// </para>
/// </summary>

/// <param name="argc">
/// GTK+ always passes %NULL for this argument
/// </param>
/// <param name="argv">
/// GTK+ always passes %NULL for this argument
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkModuleInitFunc(int argc, string[] argv);

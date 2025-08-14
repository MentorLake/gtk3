namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to [func@GLib.timeout_add],
/// [func@GLib.timeout_add_full], [func@GLib.idle_add], and
/// [func@GLib.idle_add_full].
/// </para>
/// <para>
/// When calling [method@GLib.Source.set_callback], you may need to cast a
/// function of a different type to this type. Use [func@GLib.SOURCE_FUNC] to
/// avoid warnings about incompatible function types.
/// </para>
/// </summary>

/// <param name="user_data">
/// data passed to the function, set when the source was
///     created with one of the above functions
/// </param>
/// <return>
/// %FALSE if the source should be removed.
/// [const@GLib.SOURCE_CONTINUE] and [const@GLib.SOURCE_REMOVE] are more
/// memorable names for the return value.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSourceFunc(IntPtr user_data);

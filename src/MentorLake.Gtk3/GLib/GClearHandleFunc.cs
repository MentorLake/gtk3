namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to [func@GLib.clear_handle_id] The
/// implementation is expected to free the resource identified by @handle_id;
/// for instance, if @handle_id is a [struct@GLib.Source] ID,
/// [func@GLib.Source.remove] can be used.
/// </para>
/// </summary>

/// <param name="handle_id">
/// the handle ID to clear
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClearHandleFunc(uint handle_id);

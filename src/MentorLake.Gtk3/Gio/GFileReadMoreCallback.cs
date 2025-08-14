namespace MentorLake.Gio;

/// <summary>
/// <para>
/// When loading the partial contents of a file with g_file_load_partial_contents_async(),
/// it may become necessary to determine if any more data from the file should be loaded.
/// A #GFileReadMoreCallback function facilitates this by returning %TRUE if more data
/// should be read, or %FALSE otherwise.
/// </para>
/// </summary>

/// <param name="file_contents">
/// the data as currently read.
/// </param>
/// <param name="file_size">
/// the size of the data currently read.
/// </param>
/// <param name="callback_data">
/// data passed to the callback.
/// </param>
/// <return>
/// %TRUE if more data should be read back. %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GFileReadMoreCallback(string file_contents, int file_size, IntPtr callback_data);

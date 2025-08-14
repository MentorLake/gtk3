namespace MentorLake.Gio;

/// <summary>
/// <para>
/// When doing file operations that may take a while, such as moving
/// a file or copying a file, a progress callback is used to pass how
/// far along that operation is to the application.
/// </para>
/// </summary>

/// <param name="current_num_bytes">
/// the current number of bytes in the operation.
/// </param>
/// <param name="total_num_bytes">
/// the total number of bytes in the operation.
/// </param>
/// <param name="data">
/// user data passed to the callback.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFileProgressCallback(int current_num_bytes, int total_num_bytes, IntPtr data);

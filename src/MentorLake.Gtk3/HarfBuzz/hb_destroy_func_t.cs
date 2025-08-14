namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for destroy user-data callbacks.
/// </para>
/// </summary>

/// <param name="user_data">
/// the data to be destroyed
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hb_destroy_func_t(IntPtr user_data);

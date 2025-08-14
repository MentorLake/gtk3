namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type used for test case functions that take an extra pointer
/// argument.
/// </para>
/// </summary>

/// <param name="user_data">
/// the data provided when registering the test
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTestDataFunc(IntPtr user_data);

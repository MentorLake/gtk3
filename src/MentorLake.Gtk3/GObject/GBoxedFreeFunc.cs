namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This function is provided by the user and should free the boxed
/// structure passed.
/// </para>
/// </summary>

/// <param name="boxed">
/// The boxed structure to be freed.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBoxedFreeFunc(IntPtr boxed);

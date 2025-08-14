namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This function is provided by the user and should produce a copy
/// of the passed in boxed structure.
/// </para>
/// </summary>

/// <param name="boxed">
/// The boxed structure to be copied.
/// </param>
/// <return>
/// The newly created copy of the boxed structure.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GBoxedCopyFunc(IntPtr boxed);

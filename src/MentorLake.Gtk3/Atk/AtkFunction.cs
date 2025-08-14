namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An AtkFunction is a function definition used for padding which has
/// been added to class and interface structures to allow for expansion
/// in the future.
/// </para>
/// </summary>

/// <param name="user_data">
/// custom data defined by the user
/// </param>
/// <return>
/// not used
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool AtkFunction(IntPtr user_data);

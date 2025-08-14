namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Type of a function that can duplicate user data for an attribute.
/// </para>
/// </summary>

/// <param name="user_data">
/// user data to copy
/// </param>
/// <return>
/// new copy of @user_data.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr PangoAttrDataCopyFunc(IntPtr user_data);

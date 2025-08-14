namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the print handler functions.
/// These are called with the complete formatted string to output.
/// </para>
/// </summary>

/// <param name="@string">
/// the message to output
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GPrintFunc(string @string);

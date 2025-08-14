namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Type of a function filtering a list of attributes.
/// </para>
/// </summary>

/// <param name="attribute">
/// a Pango attribute
/// </param>
/// <param name="user_data">
/// user data passed to the function
/// </param>
/// <return>
/// %TRUE if the attribute should be selected for
///   filtering, %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool PangoAttrFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attribute, IntPtr user_data);

namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type for the function that is used to convert from #GSettings to
/// an object property. The @value is already initialized to hold values
/// of the appropriate type.
/// </para>
/// </summary>

/// <param name="value">
/// return location for the property value
/// </param>
/// <param name="variant">
/// the #GVariant
/// </param>
/// <param name="user_data">
/// user data that was specified when the binding was created
/// </param>
/// <return>
/// %TRUE if the conversion succeeded, %FALSE in case of an error
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSettingsBindGetMapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant, IntPtr user_data);

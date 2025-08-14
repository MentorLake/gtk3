namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type for the function that is used to convert an object property
/// value to a #GVariant for storing it in #GSettings.
/// </para>
/// </summary>

/// <param name="value">
/// a #GValue containing the property value to map
/// </param>
/// <param name="expected_type">
/// the #GVariantType to create
/// </param>
/// <param name="user_data">
/// user data that was specified when the binding was created
/// </param>
/// <return>
/// a new #GVariant holding the data from @value,
///     or %NULL in case of an error
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GLib.GVariantHandle GSettingsBindSetMapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type, IntPtr user_data);

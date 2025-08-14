namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of the function that is used to convert from a value stored
/// in a #GSettings to a value that is useful to the application.
/// </para>
/// <para>
/// If the value is successfully mapped, the result should be stored at
/// @result and %TRUE returned.  If mapping fails (for example, if @value
/// is not in the right format) then %FALSE should be returned.
/// </para>
/// <para>
/// If @value is %NULL then it means that the mapping function is being
/// given a "last chance" to successfully return a valid value.  %TRUE
/// must be returned in this case.
/// </para>
/// </summary>

/// <param name="value">
/// the #GVariant to map, or %NULL
/// </param>
/// <param name="result">
/// the result of the mapping
/// </param>
/// <param name="user_data">
/// the user data that was passed to
/// g_settings_get_mapped()
/// </param>
/// <return>
/// %TRUE if the conversion succeeded, %FALSE in case of an error
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSettingsGetMapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out IntPtr result, IntPtr user_data);

namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Callback used when enumerating fonts in a fontset.
/// </para>
/// <para>
/// See [method@Pango.Fontset.foreach].
/// </para>
/// </summary>

/// <param name="fontset">
/// a `PangoFontset`
/// </param>
/// <param name="font">
/// a font from @fontset
/// </param>
/// <param name="user_data">
/// callback data
/// </param>
/// <return>
/// if %TRUE, stop iteration and return immediately.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool PangoFontsetForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))] MentorLake.Pango.PangoFontsetHandle fontset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, IntPtr user_data);

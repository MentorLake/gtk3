namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A callback method for #hb_buffer_t. The method gets called with the
/// #hb_buffer_t it was set on, the #hb_font_t the buffer is shaped with and a
/// message describing what step of the shaping process will be performed.
/// Returning `false` from this method will skip this shaping step and move to
/// the next one.
/// </para>
/// </summary>

/// <param name="buffer">
/// An #hb_buffer_t to work upon
/// </param>
/// <param name="font">
/// The #hb_font_t the @buffer is shaped with
/// </param>
/// <param name="message">
/// `NULL`-terminated message passed to the function
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// `true` to perform the shaping step, `false` to skip it.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_buffer_message_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_buffer_tHandle>))] MentorLake.HarfBuzz.hb_buffer_tHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_font_tHandle>))] MentorLake.HarfBuzz.hb_font_tHandle font, string message, IntPtr user_data);

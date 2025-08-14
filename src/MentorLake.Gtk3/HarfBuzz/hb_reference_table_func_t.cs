namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Callback function for hb_face_create_for_tables().
/// </para>
/// </summary>

/// <param name="face">
/// an #hb_face_t to reference table for
/// </param>
/// <param name="tag">
/// the tag of the table to reference
/// </param>
/// <param name="user_data">
/// User data pointer passed by the caller
/// </param>
/// <return>
/// A pointer to the @tag table within @face
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_blob_tHandle hb_reference_table_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag, IntPtr user_data);

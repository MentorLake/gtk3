namespace MentorLake.HarfBuzz;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_blob_tHandle hb_reference_table_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))] MentorLake.HarfBuzz.hb_face_tHandle face, MentorLake.HarfBuzz.hb_tag_t tag, IntPtr user_data);

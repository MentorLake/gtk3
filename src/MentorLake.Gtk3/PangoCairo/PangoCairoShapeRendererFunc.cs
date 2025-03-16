namespace MentorLake.PangoCairo;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PangoCairoShapeRendererFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrShapeHandle>))] MentorLake.Pango.PangoAttrShapeHandle attr, bool do_path, IntPtr data);

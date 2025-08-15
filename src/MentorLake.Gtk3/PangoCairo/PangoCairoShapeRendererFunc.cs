namespace MentorLake.PangoCairo;

/// <summary>
/// <para>
/// Function type for rendering attributes of type %PANGO_ATTR_SHAPE
/// with Pango&apos;s Cairo renderer.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context with current point set to where the shape should
/// be rendered
/// </param>
/// <param name="attr">
/// the %PANGO_ATTR_SHAPE to render
/// </param>
/// <param name="do_path">
/// whether only the shape path should be appended to current
/// path of @cr and no filling/stroking done.  This will be set
/// to %TRUE when called from pango_cairo_layout_path() and
/// pango_cairo_layout_line_path() rendering functions.
/// </param>
/// <param name="data">
/// user data passed to pango_cairo_context_set_shape_renderer()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PangoCairoShapeRendererFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrShapeHandle>))] MentorLake.Pango.PangoAttrShapeHandle attr, bool do_path, IntPtr data);

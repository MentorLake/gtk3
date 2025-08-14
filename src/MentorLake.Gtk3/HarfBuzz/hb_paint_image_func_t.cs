namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_paint_funcs_t to paint a glyph image.
/// </para>
/// <para>
/// This method is called for glyphs with image blobs in the CBDT,
/// sbix or SVG tables. The @format identifies the kind of data that
/// is contained in @image. Possible values include #HB_PAINT_IMAGE_FORMAT_PNG,
/// #HB_PAINT_IMAGE_FORMAT_SVG and #HB_PAINT_IMAGE_FORMAT_BGRA.
/// </para>
/// <para>
/// The image dimensions and glyph extents are provided if available,
/// and should be used to size and position the image.
/// </para>
/// </summary>

/// <param name="funcs">
/// paint functions object
/// </param>
/// <param name="paint_data">
/// The data accompanying the paint functions in hb_font_paint_glyph()
/// </param>
/// <param name="image">
/// the image data
/// </param>
/// <param name="width">
/// width of the raster image in pixels, or 0
/// </param>
/// <param name="height">
/// height of the raster image in pixels, or 0
/// </param>
/// <param name="format">
/// the image format as a tag
/// </param>
/// <param name="slant">
/// the synthetic slant ratio to be applied to the image during rendering
/// </param>
/// <param name="extents">
/// glyph extents for desired rendering
/// </param>
/// <param name="user_data">
/// User data pointer passed to hb_paint_funcs_set_image_func()
/// </param>
/// <return>
/// Whether the operation was successful.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.HarfBuzz.hb_bool_t hb_paint_image_func_t([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_paint_funcs_tHandle>))] MentorLake.HarfBuzz.hb_paint_funcs_tHandle funcs, IntPtr paint_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_blob_tHandle>))] MentorLake.HarfBuzz.hb_blob_tHandle image, uint width, uint height, MentorLake.HarfBuzz.hb_tag_t format, float slant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_glyph_extents_tHandle>))] MentorLake.HarfBuzz.hb_glyph_extents_tHandle extents, IntPtr user_data);

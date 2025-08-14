namespace MentorLake.cairo;

public class cairoGlobalFunctions
{

/// <param name="cr">
/// </param>
/// <param name="path">
/// </param>

	public static void AppendPath(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_path_tHandle path)
	{
		cairoGlobalFunctionsExterns.cairo_append_path(cr, path);
	}


/// <param name="cr">
/// </param>
/// <param name="xc">
/// </param>
/// <param name="yc">
/// </param>
/// <param name="radius">
/// </param>
/// <param name="angle1">
/// </param>
/// <param name="angle2">
/// </param>

	public static void Arc(MentorLake.cairo.cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2)
	{
		cairoGlobalFunctionsExterns.cairo_arc(cr, xc, yc, radius, angle1, angle2);
	}


/// <param name="cr">
/// </param>
/// <param name="xc">
/// </param>
/// <param name="yc">
/// </param>
/// <param name="radius">
/// </param>
/// <param name="angle1">
/// </param>
/// <param name="angle2">
/// </param>

	public static void ArcNegative(MentorLake.cairo.cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2)
	{
		cairoGlobalFunctionsExterns.cairo_arc_negative(cr, xc, yc, radius, angle1, angle2);
	}


/// <param name="cr">
/// </param>

	public static void Clip(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_clip(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>
/// <param name="x2">
/// </param>
/// <param name="y2">
/// </param>

	public static void ClipExtents(MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2)
	{
		cairoGlobalFunctionsExterns.cairo_clip_extents(cr, x1, y1, x2, y2);
	}


/// <param name="cr">
/// </param>

	public static void ClipPreserve(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_clip_preserve(cr);
	}


/// <param name="cr">
/// </param>

	public static void ClosePath(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_close_path(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_rectangle_list_tHandle CopyClipRectangleList(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_copy_clip_rectangle_list(cr);
	}


/// <param name="cr">
/// </param>

	public static void CopyPage(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_copy_page(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_path_tHandle CopyPath(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_copy_path(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_path_tHandle CopyPathFlat(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_copy_path_flat(cr);
	}


/// <param name="target">
/// </param>

	public static MentorLake.cairo.cairo_tHandle Create(MentorLake.cairo.cairo_surface_tHandle target)
	{
		return cairoGlobalFunctionsExterns.cairo_create(target);
	}


/// <param name="cr">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>
/// <param name="x2">
/// </param>
/// <param name="y2">
/// </param>
/// <param name="x3">
/// </param>
/// <param name="y3">
/// </param>

	public static void CurveTo(MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2, double x3, double y3)
	{
		cairoGlobalFunctionsExterns.cairo_curve_to(cr, x1, y1, x2, y2, x3, y3);
	}



	public static void DebugResetStaticData()
	{
		cairoGlobalFunctionsExterns.cairo_debug_reset_static_data();
	}


/// <param name="cr">
/// </param>

	public static void Destroy(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_destroy(cr);
	}


/// <param name="device">
/// </param>

	public static MentorLake.cairo.cairo_status_t DeviceAcquire(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_acquire(device);
	}


/// <param name="device">
/// </param>

	public static void DeviceDestroy(MentorLake.cairo.cairo_device_tHandle device)
	{
		cairoGlobalFunctionsExterns.cairo_device_destroy(device);
	}


/// <param name="device">
/// </param>

	public static void DeviceFinish(MentorLake.cairo.cairo_device_tHandle device)
	{
		cairoGlobalFunctionsExterns.cairo_device_finish(device);
	}


/// <param name="device">
/// </param>

	public static void DeviceFlush(MentorLake.cairo.cairo_device_tHandle device)
	{
		cairoGlobalFunctionsExterns.cairo_device_flush(device);
	}


/// <param name="device">
/// </param>

	public static uint DeviceGetReferenceCount(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_get_reference_count(device);
	}


/// <param name="device">
/// </param>

	public static MentorLake.cairo.cairo_device_type_t DeviceGetType(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_get_type(device);
	}


/// <param name="device">
/// </param>
/// <param name="key">
/// </param>

	public static IntPtr DeviceGetUserData(MentorLake.cairo.cairo_device_tHandle device, MentorLake.cairo.cairo_user_data_key_tHandle key)
	{
		return cairoGlobalFunctionsExterns.cairo_device_get_user_data(device, key);
	}


/// <param name="device">
/// </param>

	public static double DeviceObserverElapsed(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_observer_elapsed(device);
	}


/// <param name="device">
/// </param>

	public static double DeviceObserverFillElapsed(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_observer_fill_elapsed(device);
	}


/// <param name="device">
/// </param>

	public static double DeviceObserverGlyphsElapsed(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_observer_glyphs_elapsed(device);
	}


/// <param name="device">
/// </param>

	public static double DeviceObserverMaskElapsed(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_observer_mask_elapsed(device);
	}


/// <param name="device">
/// </param>

	public static double DeviceObserverPaintElapsed(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_observer_paint_elapsed(device);
	}


/// <param name="device">
/// </param>
/// <param name="write_func">
/// </param>
/// <param name="closure">
/// </param>

	public static MentorLake.cairo.cairo_status_t DeviceObserverPrint(MentorLake.cairo.cairo_device_tHandle device, MentorLake.cairo.cairo_write_func_t write_func, IntPtr closure)
	{
		return cairoGlobalFunctionsExterns.cairo_device_observer_print(device, write_func, closure);
	}


/// <param name="device">
/// </param>

	public static double DeviceObserverStrokeElapsed(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_observer_stroke_elapsed(device);
	}


/// <param name="device">
/// </param>

	public static MentorLake.cairo.cairo_device_tHandle DeviceReference(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_reference(device);
	}


/// <param name="device">
/// </param>

	public static void DeviceRelease(MentorLake.cairo.cairo_device_tHandle device)
	{
		cairoGlobalFunctionsExterns.cairo_device_release(device);
	}


/// <param name="device">
/// </param>
/// <param name="key">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="destroy">
/// </param>

	public static MentorLake.cairo.cairo_status_t DeviceSetUserData(MentorLake.cairo.cairo_device_tHandle device, MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy)
	{
		return cairoGlobalFunctionsExterns.cairo_device_set_user_data(device, key, user_data, destroy);
	}


/// <param name="device">
/// </param>

	public static MentorLake.cairo.cairo_status_t DeviceStatus(MentorLake.cairo.cairo_device_tHandle device)
	{
		return cairoGlobalFunctionsExterns.cairo_device_status(device);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void DeviceToUser(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_device_to_user(cr, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="dx">
/// </param>
/// <param name="dy">
/// </param>

	public static void DeviceToUserDistance(MentorLake.cairo.cairo_tHandle cr, double dx, double dy)
	{
		cairoGlobalFunctionsExterns.cairo_device_to_user_distance(cr, dx, dy);
	}


/// <param name="cr">
/// </param>

	public static void Fill(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_fill(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>
/// <param name="x2">
/// </param>
/// <param name="y2">
/// </param>

	public static void FillExtents(MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2)
	{
		cairoGlobalFunctionsExterns.cairo_fill_extents(cr, x1, y1, x2, y2);
	}


/// <param name="cr">
/// </param>

	public static void FillPreserve(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_fill_preserve(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="extents">
/// </param>

	public static void FontExtents(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_font_extents_tHandle extents)
	{
		cairoGlobalFunctionsExterns.cairo_font_extents(cr, extents);
	}


/// <param name="font_face">
/// </param>

	public static void FontFaceDestroy(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		cairoGlobalFunctionsExterns.cairo_font_face_destroy(font_face);
	}


/// <param name="font_face">
/// </param>

	public static uint FontFaceGetReferenceCount(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_font_face_get_reference_count(font_face);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_font_type_t FontFaceGetType(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_font_face_get_type(font_face);
	}


/// <param name="font_face">
/// </param>
/// <param name="key">
/// </param>

	public static IntPtr FontFaceGetUserData(MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_data_key_tHandle key)
	{
		return cairoGlobalFunctionsExterns.cairo_font_face_get_user_data(font_face, key);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_font_face_tHandle FontFaceReference(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_font_face_reference(font_face);
	}


/// <param name="font_face">
/// </param>
/// <param name="key">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="destroy">
/// </param>

	public static MentorLake.cairo.cairo_status_t FontFaceSetUserData(MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy)
	{
		return cairoGlobalFunctionsExterns.cairo_font_face_set_user_data(font_face, key, user_data, destroy);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_status_t FontFaceStatus(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_font_face_status(font_face);
	}


/// <param name="original">
/// </param>

	public static MentorLake.cairo.cairo_font_options_tHandle FontOptionsCopy(MentorLake.cairo.cairo_font_options_tHandle original)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_copy(original);
	}



	public static MentorLake.cairo.cairo_font_options_tHandle FontOptionsCreate()
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_create();
	}


/// <param name="options">
/// </param>

	public static void FontOptionsDestroy(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		cairoGlobalFunctionsExterns.cairo_font_options_destroy(options);
	}


/// <param name="options">
/// </param>
/// <param name="other">
/// </param>

	public static MentorLake.cairo.cairo_bool_t FontOptionsEqual(MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_font_options_tHandle other)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_equal(options, other);
	}


/// <param name="options">
/// </param>

	public static MentorLake.cairo.cairo_antialias_t FontOptionsGetAntialias(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_get_antialias(options);
	}


/// <param name="options">
/// </param>

	public static MentorLake.cairo.cairo_hint_metrics_t FontOptionsGetHintMetrics(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_get_hint_metrics(options);
	}


/// <param name="options">
/// </param>

	public static MentorLake.cairo.cairo_hint_style_t FontOptionsGetHintStyle(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_get_hint_style(options);
	}


/// <param name="options">
/// </param>

	public static MentorLake.cairo.cairo_subpixel_order_t FontOptionsGetSubpixelOrder(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_get_subpixel_order(options);
	}


/// <param name="options">
/// </param>

	public static string FontOptionsGetVariations(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_get_variations(options);
	}


/// <param name="options">
/// </param>

	public static ulong FontOptionsHash(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_hash(options);
	}


/// <param name="options">
/// </param>
/// <param name="other">
/// </param>

	public static void FontOptionsMerge(MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_font_options_tHandle other)
	{
		cairoGlobalFunctionsExterns.cairo_font_options_merge(options, other);
	}


/// <param name="options">
/// </param>
/// <param name="antialias">
/// </param>

	public static void FontOptionsSetAntialias(MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_antialias_t antialias)
	{
		cairoGlobalFunctionsExterns.cairo_font_options_set_antialias(options, antialias);
	}


/// <param name="options">
/// </param>
/// <param name="hint_metrics">
/// </param>

	public static void FontOptionsSetHintMetrics(MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_hint_metrics_t hint_metrics)
	{
		cairoGlobalFunctionsExterns.cairo_font_options_set_hint_metrics(options, hint_metrics);
	}


/// <param name="options">
/// </param>
/// <param name="hint_style">
/// </param>

	public static void FontOptionsSetHintStyle(MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_hint_style_t hint_style)
	{
		cairoGlobalFunctionsExterns.cairo_font_options_set_hint_style(options, hint_style);
	}


/// <param name="options">
/// </param>
/// <param name="subpixel_order">
/// </param>

	public static void FontOptionsSetSubpixelOrder(MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_subpixel_order_t subpixel_order)
	{
		cairoGlobalFunctionsExterns.cairo_font_options_set_subpixel_order(options, subpixel_order);
	}


/// <param name="options">
/// </param>
/// <param name="variations">
/// </param>

	public static void FontOptionsSetVariations(MentorLake.cairo.cairo_font_options_tHandle options, string variations)
	{
		cairoGlobalFunctionsExterns.cairo_font_options_set_variations(options, variations);
	}


/// <param name="options">
/// </param>

	public static MentorLake.cairo.cairo_status_t FontOptionsStatus(MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_font_options_status(options);
	}


/// <param name="format">
/// </param>
/// <param name="width">
/// </param>

	public static int FormatStrideForWidth(MentorLake.cairo.cairo_format_t format, int width)
	{
		return cairoGlobalFunctionsExterns.cairo_format_stride_for_width(format, width);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_antialias_t GetAntialias(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_antialias(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void GetCurrentPoint(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_get_current_point(cr, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="dashes">
/// </param>
/// <param name="offset">
/// </param>

	public static void GetDash(MentorLake.cairo.cairo_tHandle cr, double dashes, double offset)
	{
		cairoGlobalFunctionsExterns.cairo_get_dash(cr, dashes, offset);
	}


/// <param name="cr">
/// </param>

	public static int GetDashCount(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_dash_count(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_fill_rule_t GetFillRule(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_fill_rule(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_font_face_tHandle GetFontFace(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_font_face(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="matrix">
/// </param>

	public static void GetFontMatrix(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_get_font_matrix(cr, matrix);
	}


/// <param name="cr">
/// </param>
/// <param name="options">
/// </param>

	public static void GetFontOptions(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_font_options_tHandle options)
	{
		cairoGlobalFunctionsExterns.cairo_get_font_options(cr, options);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle GetGroupTarget(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_group_target(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_line_cap_t GetLineCap(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_line_cap(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_line_join_t GetLineJoin(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_line_join(cr);
	}


/// <param name="cr">
/// </param>

	public static double GetLineWidth(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_line_width(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="matrix">
/// </param>

	public static void GetMatrix(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_get_matrix(cr, matrix);
	}


/// <param name="cr">
/// </param>

	public static double GetMiterLimit(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_miter_limit(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_operator_t GetOperator(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_operator(cr);
	}


/// <param name="cr">
/// </param>

	public static uint GetReferenceCount(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_reference_count(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_scaled_font_tHandle GetScaledFont(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_scaled_font(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle GetSource(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_source(cr);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle GetTarget(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_target(cr);
	}


/// <param name="cr">
/// </param>

	public static double GetTolerance(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_get_tolerance(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="key">
/// </param>

	public static IntPtr GetUserData(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_user_data_key_tHandle key)
	{
		return cairoGlobalFunctionsExterns.cairo_get_user_data(cr, key);
	}


/// <param name="num_glyphs">
/// </param>

	public static MentorLake.cairo.cairo_glyph_tHandle GlyphAllocate(int num_glyphs)
	{
		return cairoGlobalFunctionsExterns.cairo_glyph_allocate(num_glyphs);
	}


/// <param name="cr">
/// </param>
/// <param name="glyphs">
/// </param>
/// <param name="num_glyphs">
/// </param>
/// <param name="extents">
/// </param>

	public static void GlyphExtents(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs, MentorLake.cairo.cairo_text_extents_tHandle extents)
	{
		cairoGlobalFunctionsExterns.cairo_glyph_extents(cr, glyphs, num_glyphs, extents);
	}


/// <param name="glyphs">
/// </param>

	public static void GlyphFree(MentorLake.cairo.cairo_glyph_tHandle glyphs)
	{
		cairoGlobalFunctionsExterns.cairo_glyph_free(glyphs);
	}


/// <param name="cr">
/// </param>
/// <param name="glyphs">
/// </param>
/// <param name="num_glyphs">
/// </param>

	public static void GlyphPath(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs)
	{
		cairoGlobalFunctionsExterns.cairo_glyph_path(cr, glyphs, num_glyphs);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_bool_t HasCurrentPoint(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_has_current_point(cr);
	}


/// <param name="cr">
/// </param>

	public static void IdentityMatrix(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_identity_matrix(cr);
	}


/// <param name="format">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle ImageSurfaceCreate(MentorLake.cairo.cairo_format_t format, int width, int height)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_create(format, width, height);
	}


/// <param name="data">
/// </param>
/// <param name="format">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>
/// <param name="stride">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle ImageSurfaceCreateForData(byte[] data, MentorLake.cairo.cairo_format_t format, int width, int height, int stride)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_create_for_data(data, format, width, height, stride);
	}


/// <param name="filename">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle ImageSurfaceCreateFromPng(string filename)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_create_from_png(filename);
	}


/// <param name="read_func">
/// </param>
/// <param name="closure">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle ImageSurfaceCreateFromPngStream(MentorLake.cairo.cairo_read_func_t read_func, IntPtr closure)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_create_from_png_stream(read_func, closure);
	}


/// <param name="surface">
/// </param>

	public static byte ImageSurfaceGetData(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_get_data(surface);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_format_t ImageSurfaceGetFormat(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_get_format(surface);
	}


/// <param name="surface">
/// </param>

	public static int ImageSurfaceGetHeight(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_get_height(surface);
	}


/// <param name="surface">
/// </param>

	public static int ImageSurfaceGetStride(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_get_stride(surface);
	}


/// <param name="surface">
/// </param>

	public static int ImageSurfaceGetWidth(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_image_surface_get_width(surface);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static MentorLake.cairo.cairo_bool_t InClip(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		return cairoGlobalFunctionsExterns.cairo_in_clip(cr, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static MentorLake.cairo.cairo_bool_t InFill(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		return cairoGlobalFunctionsExterns.cairo_in_fill(cr, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static MentorLake.cairo.cairo_bool_t InStroke(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		return cairoGlobalFunctionsExterns.cairo_in_stroke(cr, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void LineTo(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_line_to(cr, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="pattern">
/// </param>

	public static void Mask(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		cairoGlobalFunctionsExterns.cairo_mask(cr, pattern);
	}


/// <param name="cr">
/// </param>
/// <param name="surface">
/// </param>
/// <param name="surface_x">
/// </param>
/// <param name="surface_y">
/// </param>

	public static void MaskSurface(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_surface_tHandle surface, double surface_x, double surface_y)
	{
		cairoGlobalFunctionsExterns.cairo_mask_surface(cr, surface, surface_x, surface_y);
	}


/// <param name="matrix">
/// </param>
/// <param name="xx">
/// </param>
/// <param name="yx">
/// </param>
/// <param name="xy">
/// </param>
/// <param name="yy">
/// </param>
/// <param name="x0">
/// </param>
/// <param name="y0">
/// </param>

	public static void MatrixInit(MentorLake.cairo.cairo_matrix_tHandle matrix, double xx, double yx, double xy, double yy, double x0, double y0)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_init(matrix, xx, yx, xy, yy, x0, y0);
	}


/// <param name="matrix">
/// </param>

	public static void MatrixInitIdentity(MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_init_identity(matrix);
	}


/// <param name="matrix">
/// </param>
/// <param name="radians">
/// </param>

	public static void MatrixInitRotate(MentorLake.cairo.cairo_matrix_tHandle matrix, double radians)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_init_rotate(matrix, radians);
	}


/// <param name="matrix">
/// </param>
/// <param name="sx">
/// </param>
/// <param name="sy">
/// </param>

	public static void MatrixInitScale(MentorLake.cairo.cairo_matrix_tHandle matrix, double sx, double sy)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_init_scale(matrix, sx, sy);
	}


/// <param name="matrix">
/// </param>
/// <param name="tx">
/// </param>
/// <param name="ty">
/// </param>

	public static void MatrixInitTranslate(MentorLake.cairo.cairo_matrix_tHandle matrix, double tx, double ty)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_init_translate(matrix, tx, ty);
	}


/// <param name="matrix">
/// </param>

	public static MentorLake.cairo.cairo_status_t MatrixInvert(MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		return cairoGlobalFunctionsExterns.cairo_matrix_invert(matrix);
	}


/// <param name="result">
/// </param>
/// <param name="a">
/// </param>
/// <param name="b">
/// </param>

	public static void MatrixMultiply(MentorLake.cairo.cairo_matrix_tHandle result, MentorLake.cairo.cairo_matrix_tHandle a, MentorLake.cairo.cairo_matrix_tHandle b)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_multiply(result, a, b);
	}


/// <param name="matrix">
/// </param>
/// <param name="radians">
/// </param>

	public static void MatrixRotate(MentorLake.cairo.cairo_matrix_tHandle matrix, double radians)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_rotate(matrix, radians);
	}


/// <param name="matrix">
/// </param>
/// <param name="sx">
/// </param>
/// <param name="sy">
/// </param>

	public static void MatrixScale(MentorLake.cairo.cairo_matrix_tHandle matrix, double sx, double sy)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_scale(matrix, sx, sy);
	}


/// <param name="matrix">
/// </param>
/// <param name="dx">
/// </param>
/// <param name="dy">
/// </param>

	public static void MatrixTransformDistance(MentorLake.cairo.cairo_matrix_tHandle matrix, double dx, double dy)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_transform_distance(matrix, dx, dy);
	}


/// <param name="matrix">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void MatrixTransformPoint(MentorLake.cairo.cairo_matrix_tHandle matrix, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_transform_point(matrix, x, y);
	}


/// <param name="matrix">
/// </param>
/// <param name="tx">
/// </param>
/// <param name="ty">
/// </param>

	public static void MatrixTranslate(MentorLake.cairo.cairo_matrix_tHandle matrix, double tx, double ty)
	{
		cairoGlobalFunctionsExterns.cairo_matrix_translate(matrix, tx, ty);
	}


/// <param name="pattern">
/// </param>

	public static void MeshPatternBeginPatch(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_begin_patch(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>
/// <param name="x2">
/// </param>
/// <param name="y2">
/// </param>
/// <param name="x3">
/// </param>
/// <param name="y3">
/// </param>

	public static void MeshPatternCurveTo(MentorLake.cairo.cairo_pattern_tHandle pattern, double x1, double y1, double x2, double y2, double x3, double y3)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_curve_to(pattern, x1, y1, x2, y2, x3, y3);
	}


/// <param name="pattern">
/// </param>

	public static void MeshPatternEndPatch(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_end_patch(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="patch_num">
/// </param>
/// <param name="point_num">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static MentorLake.cairo.cairo_status_t MeshPatternGetControlPoint(MentorLake.cairo.cairo_pattern_tHandle pattern, uint patch_num, uint point_num, double x, double y)
	{
		return cairoGlobalFunctionsExterns.cairo_mesh_pattern_get_control_point(pattern, patch_num, point_num, x, y);
	}


/// <param name="pattern">
/// </param>
/// <param name="patch_num">
/// </param>
/// <param name="corner_num">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>
/// <param name="alpha">
/// </param>

	public static MentorLake.cairo.cairo_status_t MeshPatternGetCornerColorRgba(MentorLake.cairo.cairo_pattern_tHandle pattern, uint patch_num, uint corner_num, double red, double green, double blue, double alpha)
	{
		return cairoGlobalFunctionsExterns.cairo_mesh_pattern_get_corner_color_rgba(pattern, patch_num, corner_num, red, green, blue, alpha);
	}


/// <param name="pattern">
/// </param>
/// <param name="count">
/// </param>

	public static MentorLake.cairo.cairo_status_t MeshPatternGetPatchCount(MentorLake.cairo.cairo_pattern_tHandle pattern, uint count)
	{
		return cairoGlobalFunctionsExterns.cairo_mesh_pattern_get_patch_count(pattern, count);
	}


/// <param name="pattern">
/// </param>
/// <param name="patch_num">
/// </param>

	public static MentorLake.cairo.cairo_path_tHandle MeshPatternGetPath(MentorLake.cairo.cairo_pattern_tHandle pattern, uint patch_num)
	{
		return cairoGlobalFunctionsExterns.cairo_mesh_pattern_get_path(pattern, patch_num);
	}


/// <param name="pattern">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void MeshPatternLineTo(MentorLake.cairo.cairo_pattern_tHandle pattern, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_line_to(pattern, x, y);
	}


/// <param name="pattern">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void MeshPatternMoveTo(MentorLake.cairo.cairo_pattern_tHandle pattern, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_move_to(pattern, x, y);
	}


/// <param name="pattern">
/// </param>
/// <param name="point_num">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void MeshPatternSetControlPoint(MentorLake.cairo.cairo_pattern_tHandle pattern, uint point_num, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_set_control_point(pattern, point_num, x, y);
	}


/// <param name="pattern">
/// </param>
/// <param name="corner_num">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>

	public static void MeshPatternSetCornerColorRgb(MentorLake.cairo.cairo_pattern_tHandle pattern, uint corner_num, double red, double green, double blue)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_set_corner_color_rgb(pattern, corner_num, red, green, blue);
	}


/// <param name="pattern">
/// </param>
/// <param name="corner_num">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>
/// <param name="alpha">
/// </param>

	public static void MeshPatternSetCornerColorRgba(MentorLake.cairo.cairo_pattern_tHandle pattern, uint corner_num, double red, double green, double blue, double alpha)
	{
		cairoGlobalFunctionsExterns.cairo_mesh_pattern_set_corner_color_rgba(pattern, corner_num, red, green, blue, alpha);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void MoveTo(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_move_to(cr, x, y);
	}


/// <param name="cr">
/// </param>

	public static void NewPath(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_new_path(cr);
	}


/// <param name="cr">
/// </param>

	public static void NewSubPath(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_new_sub_path(cr);
	}


/// <param name="cr">
/// </param>

	public static void Paint(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_paint(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="alpha">
/// </param>

	public static void PaintWithAlpha(MentorLake.cairo.cairo_tHandle cr, double alpha)
	{
		cairoGlobalFunctionsExterns.cairo_paint_with_alpha(cr, alpha);
	}


/// <param name="path">
/// </param>

	public static void PathDestroy(MentorLake.cairo.cairo_path_tHandle path)
	{
		cairoGlobalFunctionsExterns.cairo_path_destroy(path);
	}


/// <param name="cr">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>
/// <param name="x2">
/// </param>
/// <param name="y2">
/// </param>

	public static void PathExtents(MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2)
	{
		cairoGlobalFunctionsExterns.cairo_path_extents(cr, x1, y1, x2, y2);
	}


/// <param name="pattern">
/// </param>
/// <param name="offset">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>

	public static void PatternAddColorStopRgb(MentorLake.cairo.cairo_pattern_tHandle pattern, double offset, double red, double green, double blue)
	{
		cairoGlobalFunctionsExterns.cairo_pattern_add_color_stop_rgb(pattern, offset, red, green, blue);
	}


/// <param name="pattern">
/// </param>
/// <param name="offset">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>
/// <param name="alpha">
/// </param>

	public static void PatternAddColorStopRgba(MentorLake.cairo.cairo_pattern_tHandle pattern, double offset, double red, double green, double blue, double alpha)
	{
		cairoGlobalFunctionsExterns.cairo_pattern_add_color_stop_rgba(pattern, offset, red, green, blue, alpha);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PatternCreateForSurface(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_create_for_surface(surface);
	}


/// <param name="x0">
/// </param>
/// <param name="y0">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PatternCreateLinear(double x0, double y0, double x1, double y1)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_create_linear(x0, y0, x1, y1);
	}



	public static MentorLake.cairo.cairo_pattern_tHandle PatternCreateMesh()
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_create_mesh();
	}


/// <param name="cx0">
/// </param>
/// <param name="cy0">
/// </param>
/// <param name="radius0">
/// </param>
/// <param name="cx1">
/// </param>
/// <param name="cy1">
/// </param>
/// <param name="radius1">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PatternCreateRadial(double cx0, double cy0, double radius0, double cx1, double cy1, double radius1)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_create_radial(cx0, cy0, radius0, cx1, cy1, radius1);
	}


/// <param name="user_data">
/// </param>
/// <param name="content">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PatternCreateRasterSource(IntPtr user_data, MentorLake.cairo.cairo_content_t content, int width, int height)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_create_raster_source(user_data, content, width, height);
	}


/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PatternCreateRgb(double red, double green, double blue)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_create_rgb(red, green, blue);
	}


/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>
/// <param name="alpha">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PatternCreateRgba(double red, double green, double blue, double alpha)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_create_rgba(red, green, blue, alpha);
	}


/// <param name="pattern">
/// </param>

	public static void PatternDestroy(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		cairoGlobalFunctionsExterns.cairo_pattern_destroy(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="count">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternGetColorStopCount(MentorLake.cairo.cairo_pattern_tHandle pattern, int count)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_color_stop_count(pattern, count);
	}


/// <param name="pattern">
/// </param>
/// <param name="index">
/// </param>
/// <param name="offset">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>
/// <param name="alpha">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternGetColorStopRgba(MentorLake.cairo.cairo_pattern_tHandle pattern, int index, double offset, double red, double green, double blue, double alpha)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_color_stop_rgba(pattern, index, offset, red, green, blue, alpha);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_extend_t PatternGetExtend(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_extend(pattern);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_filter_t PatternGetFilter(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_filter(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="x0">
/// </param>
/// <param name="y0">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternGetLinearPoints(MentorLake.cairo.cairo_pattern_tHandle pattern, double x0, double y0, double x1, double y1)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_linear_points(pattern, x0, y0, x1, y1);
	}


/// <param name="pattern">
/// </param>
/// <param name="matrix">
/// </param>

	public static void PatternGetMatrix(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_pattern_get_matrix(pattern, matrix);
	}


/// <param name="pattern">
/// </param>
/// <param name="x0">
/// </param>
/// <param name="y0">
/// </param>
/// <param name="r0">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>
/// <param name="r1">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternGetRadialCircles(MentorLake.cairo.cairo_pattern_tHandle pattern, double x0, double y0, double r0, double x1, double y1, double r1)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_radial_circles(pattern, x0, y0, r0, x1, y1, r1);
	}


/// <param name="pattern">
/// </param>

	public static uint PatternGetReferenceCount(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_reference_count(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>
/// <param name="alpha">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternGetRgba(MentorLake.cairo.cairo_pattern_tHandle pattern, double red, double green, double blue, double alpha)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_rgba(pattern, red, green, blue, alpha);
	}


/// <param name="pattern">
/// </param>
/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternGetSurface(MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr surface)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_surface(pattern, surface);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_pattern_type_t PatternGetType(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_type(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="key">
/// </param>

	public static IntPtr PatternGetUserData(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_user_data_key_tHandle key)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_get_user_data(pattern, key);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PatternReference(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_reference(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="extend">
/// </param>

	public static void PatternSetExtend(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_extend_t extend)
	{
		cairoGlobalFunctionsExterns.cairo_pattern_set_extend(pattern, extend);
	}


/// <param name="pattern">
/// </param>
/// <param name="filter">
/// </param>

	public static void PatternSetFilter(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_filter_t filter)
	{
		cairoGlobalFunctionsExterns.cairo_pattern_set_filter(pattern, filter);
	}


/// <param name="pattern">
/// </param>
/// <param name="matrix">
/// </param>

	public static void PatternSetMatrix(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_pattern_set_matrix(pattern, matrix);
	}


/// <param name="pattern">
/// </param>
/// <param name="key">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="destroy">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternSetUserData(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_set_user_data(pattern, key, user_data, destroy);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_status_t PatternStatus(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_pattern_status(pattern);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle PopGroup(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_pop_group(cr);
	}


/// <param name="cr">
/// </param>

	public static void PopGroupToSource(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_pop_group_to_source(cr);
	}


/// <param name="cr">
/// </param>

	public static void PushGroup(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_push_group(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="content">
/// </param>

	public static void PushGroupWithContent(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_content_t content)
	{
		cairoGlobalFunctionsExterns.cairo_push_group_with_content(cr, content);
	}


/// <param name="pattern">
/// </param>
/// <param name="acquire">
/// </param>
/// <param name="release">
/// </param>

	public static void RasterSourcePatternGetAcquire(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_acquire_func_t acquire, MentorLake.cairo.cairo_raster_source_release_func_t release)
	{
		cairoGlobalFunctionsExterns.cairo_raster_source_pattern_get_acquire(pattern, acquire, release);
	}


/// <param name="pattern">
/// </param>

	public static IntPtr RasterSourcePatternGetCallbackData(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_raster_source_pattern_get_callback_data(pattern);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_raster_source_copy_func_t RasterSourcePatternGetCopy(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_raster_source_pattern_get_copy(pattern);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_raster_source_finish_func_t RasterSourcePatternGetFinish(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_raster_source_pattern_get_finish(pattern);
	}


/// <param name="pattern">
/// </param>

	public static MentorLake.cairo.cairo_raster_source_snapshot_func_t RasterSourcePatternGetSnapshot(MentorLake.cairo.cairo_pattern_tHandle pattern)
	{
		return cairoGlobalFunctionsExterns.cairo_raster_source_pattern_get_snapshot(pattern);
	}


/// <param name="pattern">
/// </param>
/// <param name="acquire">
/// </param>
/// <param name="release">
/// </param>

	public static void RasterSourcePatternSetAcquire(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_acquire_func_t acquire, MentorLake.cairo.cairo_raster_source_release_func_t release)
	{
		cairoGlobalFunctionsExterns.cairo_raster_source_pattern_set_acquire(pattern, acquire, release);
	}


/// <param name="pattern">
/// </param>
/// <param name="data">
/// </param>

	public static void RasterSourcePatternSetCallbackData(MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr data)
	{
		cairoGlobalFunctionsExterns.cairo_raster_source_pattern_set_callback_data(pattern, data);
	}


/// <param name="pattern">
/// </param>
/// <param name="copy">
/// </param>

	public static void RasterSourcePatternSetCopy(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_copy_func_t copy)
	{
		cairoGlobalFunctionsExterns.cairo_raster_source_pattern_set_copy(pattern, copy);
	}


/// <param name="pattern">
/// </param>
/// <param name="finish">
/// </param>

	public static void RasterSourcePatternSetFinish(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_finish_func_t finish)
	{
		cairoGlobalFunctionsExterns.cairo_raster_source_pattern_set_finish(pattern, finish);
	}


/// <param name="pattern">
/// </param>
/// <param name="snapshot">
/// </param>

	public static void RasterSourcePatternSetSnapshot(MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_snapshot_func_t snapshot)
	{
		cairoGlobalFunctionsExterns.cairo_raster_source_pattern_set_snapshot(pattern, snapshot);
	}


/// <param name="content">
/// </param>
/// <param name="extents">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle RecordingSurfaceCreate(MentorLake.cairo.cairo_content_t content, MentorLake.cairo.cairo_rectangle_tHandle extents)
	{
		return cairoGlobalFunctionsExterns.cairo_recording_surface_create(content, extents);
	}


/// <param name="surface">
/// </param>
/// <param name="extents">
/// </param>

	public static MentorLake.cairo.cairo_bool_t RecordingSurfaceGetExtents(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_rectangle_tHandle extents)
	{
		return cairoGlobalFunctionsExterns.cairo_recording_surface_get_extents(surface, extents);
	}


/// <param name="surface">
/// </param>
/// <param name="x0">
/// </param>
/// <param name="y0">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static void RecordingSurfaceInkExtents(MentorLake.cairo.cairo_surface_tHandle surface, double x0, double y0, double width, double height)
	{
		cairoGlobalFunctionsExterns.cairo_recording_surface_ink_extents(surface, x0, y0, width, height);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static void Rectangle(MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		cairoGlobalFunctionsExterns.cairo_rectangle(cr, x, y, width, height);
	}


/// <param name="rectangle_list">
/// </param>

	public static void RectangleListDestroy(MentorLake.cairo.cairo_rectangle_list_tHandle rectangle_list)
	{
		cairoGlobalFunctionsExterns.cairo_rectangle_list_destroy(rectangle_list);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_tHandle Reference(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_reference(cr);
	}


/// <param name="region">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static MentorLake.cairo.cairo_bool_t RegionContainsPoint(MentorLake.cairo.cairo_region_tHandle region, int x, int y)
	{
		return cairoGlobalFunctionsExterns.cairo_region_contains_point(region, x, y);
	}


/// <param name="region">
/// </param>
/// <param name="rectangle">
/// </param>

	public static MentorLake.cairo.cairo_region_overlap_t RegionContainsRectangle(MentorLake.cairo.cairo_region_tHandle region, MentorLake.cairo.cairo_rectangle_int_tHandle rectangle)
	{
		return cairoGlobalFunctionsExterns.cairo_region_contains_rectangle(region, rectangle);
	}


/// <param name="original">
/// </param>

	public static MentorLake.cairo.cairo_region_tHandle RegionCopy(MentorLake.cairo.cairo_region_tHandle original)
	{
		return cairoGlobalFunctionsExterns.cairo_region_copy(original);
	}



	public static MentorLake.cairo.cairo_region_tHandle RegionCreate()
	{
		return cairoGlobalFunctionsExterns.cairo_region_create();
	}


/// <param name="rectangle">
/// </param>

	public static MentorLake.cairo.cairo_region_tHandle RegionCreateRectangle(MentorLake.cairo.cairo_rectangle_int_tHandle rectangle)
	{
		return cairoGlobalFunctionsExterns.cairo_region_create_rectangle(rectangle);
	}


/// <param name="rects">
/// </param>
/// <param name="count">
/// </param>

	public static MentorLake.cairo.cairo_region_tHandle RegionCreateRectangles(MentorLake.cairo.cairo_rectangle_int_tHandle rects, int count)
	{
		return cairoGlobalFunctionsExterns.cairo_region_create_rectangles(rects, count);
	}


/// <param name="region">
/// </param>

	public static void RegionDestroy(MentorLake.cairo.cairo_region_tHandle region)
	{
		cairoGlobalFunctionsExterns.cairo_region_destroy(region);
	}


/// <param name="a">
/// </param>
/// <param name="b">
/// </param>

	public static MentorLake.cairo.cairo_bool_t RegionEqual(MentorLake.cairo.cairo_region_tHandle a, MentorLake.cairo.cairo_region_tHandle b)
	{
		return cairoGlobalFunctionsExterns.cairo_region_equal(a, b);
	}


/// <param name="region">
/// </param>
/// <param name="extents">
/// </param>

	public static void RegionGetExtents(MentorLake.cairo.cairo_region_tHandle region, MentorLake.cairo.cairo_rectangle_int_tHandle extents)
	{
		cairoGlobalFunctionsExterns.cairo_region_get_extents(region, extents);
	}


/// <param name="region">
/// </param>
/// <param name="nth">
/// </param>
/// <param name="rectangle">
/// </param>

	public static void RegionGetRectangle(MentorLake.cairo.cairo_region_tHandle region, int nth, MentorLake.cairo.cairo_rectangle_int_tHandle rectangle)
	{
		cairoGlobalFunctionsExterns.cairo_region_get_rectangle(region, nth, rectangle);
	}


/// <param name="dst">
/// </param>
/// <param name="other">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionIntersect(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_region_tHandle other)
	{
		return cairoGlobalFunctionsExterns.cairo_region_intersect(dst, other);
	}


/// <param name="dst">
/// </param>
/// <param name="rectangle">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionIntersectRectangle(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_rectangle_int_tHandle rectangle)
	{
		return cairoGlobalFunctionsExterns.cairo_region_intersect_rectangle(dst, rectangle);
	}


/// <param name="region">
/// </param>

	public static MentorLake.cairo.cairo_bool_t RegionIsEmpty(MentorLake.cairo.cairo_region_tHandle region)
	{
		return cairoGlobalFunctionsExterns.cairo_region_is_empty(region);
	}


/// <param name="region">
/// </param>

	public static int RegionNumRectangles(MentorLake.cairo.cairo_region_tHandle region)
	{
		return cairoGlobalFunctionsExterns.cairo_region_num_rectangles(region);
	}


/// <param name="region">
/// </param>

	public static MentorLake.cairo.cairo_region_tHandle RegionReference(MentorLake.cairo.cairo_region_tHandle region)
	{
		return cairoGlobalFunctionsExterns.cairo_region_reference(region);
	}


/// <param name="region">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionStatus(MentorLake.cairo.cairo_region_tHandle region)
	{
		return cairoGlobalFunctionsExterns.cairo_region_status(region);
	}


/// <param name="dst">
/// </param>
/// <param name="other">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionSubtract(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_region_tHandle other)
	{
		return cairoGlobalFunctionsExterns.cairo_region_subtract(dst, other);
	}


/// <param name="dst">
/// </param>
/// <param name="rectangle">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionSubtractRectangle(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_rectangle_int_tHandle rectangle)
	{
		return cairoGlobalFunctionsExterns.cairo_region_subtract_rectangle(dst, rectangle);
	}


/// <param name="region">
/// </param>
/// <param name="dx">
/// </param>
/// <param name="dy">
/// </param>

	public static void RegionTranslate(MentorLake.cairo.cairo_region_tHandle region, int dx, int dy)
	{
		cairoGlobalFunctionsExterns.cairo_region_translate(region, dx, dy);
	}


/// <param name="dst">
/// </param>
/// <param name="other">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionUnion(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_region_tHandle other)
	{
		return cairoGlobalFunctionsExterns.cairo_region_union(dst, other);
	}


/// <param name="dst">
/// </param>
/// <param name="rectangle">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionUnionRectangle(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_rectangle_int_tHandle rectangle)
	{
		return cairoGlobalFunctionsExterns.cairo_region_union_rectangle(dst, rectangle);
	}


/// <param name="dst">
/// </param>
/// <param name="other">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionXor(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_region_tHandle other)
	{
		return cairoGlobalFunctionsExterns.cairo_region_xor(dst, other);
	}


/// <param name="dst">
/// </param>
/// <param name="rectangle">
/// </param>

	public static MentorLake.cairo.cairo_status_t RegionXorRectangle(MentorLake.cairo.cairo_region_tHandle dst, MentorLake.cairo.cairo_rectangle_int_tHandle rectangle)
	{
		return cairoGlobalFunctionsExterns.cairo_region_xor_rectangle(dst, rectangle);
	}


/// <param name="cr">
/// </param>
/// <param name="dx1">
/// </param>
/// <param name="dy1">
/// </param>
/// <param name="dx2">
/// </param>
/// <param name="dy2">
/// </param>
/// <param name="dx3">
/// </param>
/// <param name="dy3">
/// </param>

	public static void RelCurveTo(MentorLake.cairo.cairo_tHandle cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3)
	{
		cairoGlobalFunctionsExterns.cairo_rel_curve_to(cr, dx1, dy1, dx2, dy2, dx3, dy3);
	}


/// <param name="cr">
/// </param>
/// <param name="dx">
/// </param>
/// <param name="dy">
/// </param>

	public static void RelLineTo(MentorLake.cairo.cairo_tHandle cr, double dx, double dy)
	{
		cairoGlobalFunctionsExterns.cairo_rel_line_to(cr, dx, dy);
	}


/// <param name="cr">
/// </param>
/// <param name="dx">
/// </param>
/// <param name="dy">
/// </param>

	public static void RelMoveTo(MentorLake.cairo.cairo_tHandle cr, double dx, double dy)
	{
		cairoGlobalFunctionsExterns.cairo_rel_move_to(cr, dx, dy);
	}


/// <param name="cr">
/// </param>

	public static void ResetClip(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_reset_clip(cr);
	}


/// <param name="cr">
/// </param>

	public static void Restore(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_restore(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="angle">
/// </param>

	public static void Rotate(MentorLake.cairo.cairo_tHandle cr, double angle)
	{
		cairoGlobalFunctionsExterns.cairo_rotate(cr, angle);
	}


/// <param name="cr">
/// </param>

	public static void Save(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_save(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="sx">
/// </param>
/// <param name="sy">
/// </param>

	public static void Scale(MentorLake.cairo.cairo_tHandle cr, double sx, double sy)
	{
		cairoGlobalFunctionsExterns.cairo_scale(cr, sx, sy);
	}


/// <param name="font_face">
/// </param>
/// <param name="font_matrix">
/// </param>
/// <param name="ctm">
/// </param>
/// <param name="options">
/// </param>

	public static MentorLake.cairo.cairo_scaled_font_tHandle ScaledFontCreate(MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_matrix_tHandle font_matrix, MentorLake.cairo.cairo_matrix_tHandle ctm, MentorLake.cairo.cairo_font_options_tHandle options)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_create(font_face, font_matrix, ctm, options);
	}


/// <param name="scaled_font">
/// </param>

	public static void ScaledFontDestroy(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_destroy(scaled_font);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="extents">
/// </param>

	public static void ScaledFontExtents(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_font_extents_tHandle extents)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_extents(scaled_font, extents);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="ctm">
/// </param>

	public static void ScaledFontGetCtm(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_matrix_tHandle ctm)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_get_ctm(scaled_font, ctm);
	}


/// <param name="scaled_font">
/// </param>

	public static MentorLake.cairo.cairo_font_face_tHandle ScaledFontGetFontFace(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_get_font_face(scaled_font);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="font_matrix">
/// </param>

	public static void ScaledFontGetFontMatrix(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_matrix_tHandle font_matrix)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_get_font_matrix(scaled_font, font_matrix);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="options">
/// </param>

	public static void ScaledFontGetFontOptions(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_font_options_tHandle options)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_get_font_options(scaled_font, options);
	}


/// <param name="scaled_font">
/// </param>

	public static uint ScaledFontGetReferenceCount(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_get_reference_count(scaled_font);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="scale_matrix">
/// </param>

	public static void ScaledFontGetScaleMatrix(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_matrix_tHandle scale_matrix)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_get_scale_matrix(scaled_font, scale_matrix);
	}


/// <param name="scaled_font">
/// </param>

	public static MentorLake.cairo.cairo_font_type_t ScaledFontGetType(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_get_type(scaled_font);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="key">
/// </param>

	public static IntPtr ScaledFontGetUserData(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_user_data_key_tHandle key)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_get_user_data(scaled_font, key);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="glyphs">
/// </param>
/// <param name="num_glyphs">
/// </param>
/// <param name="extents">
/// </param>

	public static void ScaledFontGlyphExtents(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs, MentorLake.cairo.cairo_text_extents_tHandle extents)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_glyph_extents(scaled_font, glyphs, num_glyphs, extents);
	}


/// <param name="scaled_font">
/// </param>

	public static MentorLake.cairo.cairo_scaled_font_tHandle ScaledFontReference(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_reference(scaled_font);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="key">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="destroy">
/// </param>

	public static MentorLake.cairo.cairo_status_t ScaledFontSetUserData(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_set_user_data(scaled_font, key, user_data, destroy);
	}


/// <param name="scaled_font">
/// </param>

	public static MentorLake.cairo.cairo_status_t ScaledFontStatus(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_status(scaled_font);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="utf8">
/// </param>
/// <param name="extents">
/// </param>

	public static void ScaledFontTextExtents(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, string utf8, MentorLake.cairo.cairo_text_extents_tHandle extents)
	{
		cairoGlobalFunctionsExterns.cairo_scaled_font_text_extents(scaled_font, utf8, extents);
	}


/// <param name="scaled_font">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>
/// <param name="utf8">
/// </param>
/// <param name="utf8_len">
/// </param>
/// <param name="glyphs">
/// </param>
/// <param name="num_glyphs">
/// </param>
/// <param name="clusters">
/// </param>
/// <param name="num_clusters">
/// </param>
/// <param name="cluster_flags">
/// </param>

	public static MentorLake.cairo.cairo_status_t ScaledFontTextToGlyphs(MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, double x, double y, string utf8, int utf8_len, IntPtr glyphs, int num_glyphs, IntPtr clusters, int num_clusters, MentorLake.cairo.cairo_text_cluster_flags_t cluster_flags)
	{
		return cairoGlobalFunctionsExterns.cairo_scaled_font_text_to_glyphs(scaled_font, x, y, utf8, utf8_len, glyphs, num_glyphs, clusters, num_clusters, cluster_flags);
	}


/// <param name="cr">
/// </param>
/// <param name="family">
/// </param>
/// <param name="slant">
/// </param>
/// <param name="weight">
/// </param>

	public static void SelectFontFace(MentorLake.cairo.cairo_tHandle cr, string family, MentorLake.cairo.cairo_font_slant_t slant, MentorLake.cairo.cairo_font_weight_t weight)
	{
		cairoGlobalFunctionsExterns.cairo_select_font_face(cr, family, slant, weight);
	}


/// <param name="cr">
/// </param>
/// <param name="antialias">
/// </param>

	public static void SetAntialias(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_antialias_t antialias)
	{
		cairoGlobalFunctionsExterns.cairo_set_antialias(cr, antialias);
	}


/// <param name="cr">
/// </param>
/// <param name="dashes">
/// </param>
/// <param name="num_dashes">
/// </param>
/// <param name="offset">
/// </param>

	public static void SetDash(MentorLake.cairo.cairo_tHandle cr, double dashes, int num_dashes, double offset)
	{
		cairoGlobalFunctionsExterns.cairo_set_dash(cr, dashes, num_dashes, offset);
	}


/// <param name="cr">
/// </param>
/// <param name="fill_rule">
/// </param>

	public static void SetFillRule(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_fill_rule_t fill_rule)
	{
		cairoGlobalFunctionsExterns.cairo_set_fill_rule(cr, fill_rule);
	}


/// <param name="cr">
/// </param>
/// <param name="font_face">
/// </param>

	public static void SetFontFace(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		cairoGlobalFunctionsExterns.cairo_set_font_face(cr, font_face);
	}


/// <param name="cr">
/// </param>
/// <param name="matrix">
/// </param>

	public static void SetFontMatrix(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_set_font_matrix(cr, matrix);
	}


/// <param name="cr">
/// </param>
/// <param name="options">
/// </param>

	public static void SetFontOptions(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_font_options_tHandle options)
	{
		cairoGlobalFunctionsExterns.cairo_set_font_options(cr, options);
	}


/// <param name="cr">
/// </param>
/// <param name="size">
/// </param>

	public static void SetFontSize(MentorLake.cairo.cairo_tHandle cr, double size)
	{
		cairoGlobalFunctionsExterns.cairo_set_font_size(cr, size);
	}


/// <param name="cr">
/// </param>
/// <param name="line_cap">
/// </param>

	public static void SetLineCap(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_line_cap_t line_cap)
	{
		cairoGlobalFunctionsExterns.cairo_set_line_cap(cr, line_cap);
	}


/// <param name="cr">
/// </param>
/// <param name="line_join">
/// </param>

	public static void SetLineJoin(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_line_join_t line_join)
	{
		cairoGlobalFunctionsExterns.cairo_set_line_join(cr, line_join);
	}


/// <param name="cr">
/// </param>
/// <param name="width">
/// </param>

	public static void SetLineWidth(MentorLake.cairo.cairo_tHandle cr, double width)
	{
		cairoGlobalFunctionsExterns.cairo_set_line_width(cr, width);
	}


/// <param name="cr">
/// </param>
/// <param name="matrix">
/// </param>

	public static void SetMatrix(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_set_matrix(cr, matrix);
	}


/// <param name="cr">
/// </param>
/// <param name="limit">
/// </param>

	public static void SetMiterLimit(MentorLake.cairo.cairo_tHandle cr, double limit)
	{
		cairoGlobalFunctionsExterns.cairo_set_miter_limit(cr, limit);
	}


/// <param name="cr">
/// </param>
/// <param name="op">
/// </param>

	public static void SetOperator(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_operator_t op)
	{
		cairoGlobalFunctionsExterns.cairo_set_operator(cr, op);
	}


/// <param name="cr">
/// </param>
/// <param name="scaled_font">
/// </param>

	public static void SetScaledFont(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_scaled_font_tHandle scaled_font)
	{
		cairoGlobalFunctionsExterns.cairo_set_scaled_font(cr, scaled_font);
	}


/// <param name="cr">
/// </param>
/// <param name="source">
/// </param>

	public static void SetSource(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_pattern_tHandle source)
	{
		cairoGlobalFunctionsExterns.cairo_set_source(cr, source);
	}


/// <param name="cr">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>

	public static void SetSourceRgb(MentorLake.cairo.cairo_tHandle cr, double red, double green, double blue)
	{
		cairoGlobalFunctionsExterns.cairo_set_source_rgb(cr, red, green, blue);
	}


/// <param name="cr">
/// </param>
/// <param name="red">
/// </param>
/// <param name="green">
/// </param>
/// <param name="blue">
/// </param>
/// <param name="alpha">
/// </param>

	public static void SetSourceRgba(MentorLake.cairo.cairo_tHandle cr, double red, double green, double blue, double alpha)
	{
		cairoGlobalFunctionsExterns.cairo_set_source_rgba(cr, red, green, blue, alpha);
	}


/// <param name="cr">
/// </param>
/// <param name="surface">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void SetSourceSurface(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_surface_tHandle surface, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_set_source_surface(cr, surface, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="tolerance">
/// </param>

	public static void SetTolerance(MentorLake.cairo.cairo_tHandle cr, double tolerance)
	{
		cairoGlobalFunctionsExterns.cairo_set_tolerance(cr, tolerance);
	}


/// <param name="cr">
/// </param>
/// <param name="key">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="destroy">
/// </param>

	public static MentorLake.cairo.cairo_status_t SetUserData(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy)
	{
		return cairoGlobalFunctionsExterns.cairo_set_user_data(cr, key, user_data, destroy);
	}


/// <param name="cr">
/// </param>
/// <param name="glyphs">
/// </param>
/// <param name="num_glyphs">
/// </param>

	public static void ShowGlyphs(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs)
	{
		cairoGlobalFunctionsExterns.cairo_show_glyphs(cr, glyphs, num_glyphs);
	}


/// <param name="cr">
/// </param>

	public static void ShowPage(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_show_page(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="utf8">
/// </param>

	public static void ShowText(MentorLake.cairo.cairo_tHandle cr, string utf8)
	{
		cairoGlobalFunctionsExterns.cairo_show_text(cr, utf8);
	}


/// <param name="cr">
/// </param>
/// <param name="utf8">
/// </param>
/// <param name="utf8_len">
/// </param>
/// <param name="glyphs">
/// </param>
/// <param name="num_glyphs">
/// </param>
/// <param name="clusters">
/// </param>
/// <param name="num_clusters">
/// </param>
/// <param name="cluster_flags">
/// </param>

	public static void ShowTextGlyphs(MentorLake.cairo.cairo_tHandle cr, string utf8, int utf8_len, MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs, MentorLake.cairo.cairo_text_cluster_tHandle clusters, int num_clusters, MentorLake.cairo.cairo_text_cluster_flags_t cluster_flags)
	{
		cairoGlobalFunctionsExterns.cairo_show_text_glyphs(cr, utf8, utf8_len, glyphs, num_glyphs, clusters, num_clusters, cluster_flags);
	}


/// <param name="cr">
/// </param>

	public static MentorLake.cairo.cairo_status_t Status(MentorLake.cairo.cairo_tHandle cr)
	{
		return cairoGlobalFunctionsExterns.cairo_status(cr);
	}


/// <param name="status">
/// </param>

	public static string StatusToString(MentorLake.cairo.cairo_status_t status)
	{
		return cairoGlobalFunctionsExterns.cairo_status_to_string(status);
	}


/// <param name="cr">
/// </param>

	public static void Stroke(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_stroke(cr);
	}


/// <param name="cr">
/// </param>
/// <param name="x1">
/// </param>
/// <param name="y1">
/// </param>
/// <param name="x2">
/// </param>
/// <param name="y2">
/// </param>

	public static void StrokeExtents(MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2)
	{
		cairoGlobalFunctionsExterns.cairo_stroke_extents(cr, x1, y1, x2, y2);
	}


/// <param name="cr">
/// </param>

	public static void StrokePreserve(MentorLake.cairo.cairo_tHandle cr)
	{
		cairoGlobalFunctionsExterns.cairo_stroke_preserve(cr);
	}


/// <param name="surface">
/// </param>

	public static void SurfaceCopyPage(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		cairoGlobalFunctionsExterns.cairo_surface_copy_page(surface);
	}


/// <param name="target">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle SurfaceCreateForRectangle(MentorLake.cairo.cairo_surface_tHandle target, double x, double y, double width, double height)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_create_for_rectangle(target, x, y, width, height);
	}


/// <param name="target">
/// </param>
/// <param name="mode">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle SurfaceCreateObserver(MentorLake.cairo.cairo_surface_tHandle target, MentorLake.cairo.cairo_surface_observer_mode_t mode)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_create_observer(target, mode);
	}


/// <param name="other">
/// </param>
/// <param name="content">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle SurfaceCreateSimilar(MentorLake.cairo.cairo_surface_tHandle other, MentorLake.cairo.cairo_content_t content, int width, int height)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_create_similar(other, content, width, height);
	}


/// <param name="other">
/// </param>
/// <param name="format">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle SurfaceCreateSimilarImage(MentorLake.cairo.cairo_surface_tHandle other, MentorLake.cairo.cairo_format_t format, int width, int height)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_create_similar_image(other, format, width, height);
	}


/// <param name="surface">
/// </param>

	public static void SurfaceDestroy(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		cairoGlobalFunctionsExterns.cairo_surface_destroy(surface);
	}


/// <param name="surface">
/// </param>

	public static void SurfaceFinish(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		cairoGlobalFunctionsExterns.cairo_surface_finish(surface);
	}


/// <param name="surface">
/// </param>

	public static void SurfaceFlush(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		cairoGlobalFunctionsExterns.cairo_surface_flush(surface);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_content_t SurfaceGetContent(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_get_content(surface);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_device_tHandle SurfaceGetDevice(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_get_device(surface);
	}


/// <param name="surface">
/// </param>
/// <param name="x_offset">
/// </param>
/// <param name="y_offset">
/// </param>

	public static void SurfaceGetDeviceOffset(MentorLake.cairo.cairo_surface_tHandle surface, double x_offset, double y_offset)
	{
		cairoGlobalFunctionsExterns.cairo_surface_get_device_offset(surface, x_offset, y_offset);
	}


/// <param name="surface">
/// </param>
/// <param name="x_scale">
/// </param>
/// <param name="y_scale">
/// </param>

	public static void SurfaceGetDeviceScale(MentorLake.cairo.cairo_surface_tHandle surface, double x_scale, double y_scale)
	{
		cairoGlobalFunctionsExterns.cairo_surface_get_device_scale(surface, x_scale, y_scale);
	}


/// <param name="surface">
/// </param>
/// <param name="x_pixels_per_inch">
/// </param>
/// <param name="y_pixels_per_inch">
/// </param>

	public static void SurfaceGetFallbackResolution(MentorLake.cairo.cairo_surface_tHandle surface, double x_pixels_per_inch, double y_pixels_per_inch)
	{
		cairoGlobalFunctionsExterns.cairo_surface_get_fallback_resolution(surface, x_pixels_per_inch, y_pixels_per_inch);
	}


/// <param name="surface">
/// </param>
/// <param name="options">
/// </param>

	public static void SurfaceGetFontOptions(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_font_options_tHandle options)
	{
		cairoGlobalFunctionsExterns.cairo_surface_get_font_options(surface, options);
	}


/// <param name="surface">
/// </param>
/// <param name="mime_type">
/// </param>
/// <param name="data">
/// </param>
/// <param name="length">
/// </param>

	public static void SurfaceGetMimeData(MentorLake.cairo.cairo_surface_tHandle surface, string mime_type, IntPtr data, ulong length)
	{
		cairoGlobalFunctionsExterns.cairo_surface_get_mime_data(surface, mime_type, data, length);
	}


/// <param name="surface">
/// </param>

	public static uint SurfaceGetReferenceCount(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_get_reference_count(surface);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_surface_type_t SurfaceGetType(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_get_type(surface);
	}


/// <param name="surface">
/// </param>
/// <param name="key">
/// </param>

	public static IntPtr SurfaceGetUserData(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_user_data_key_tHandle key)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_get_user_data(surface, key);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_bool_t SurfaceHasShowTextGlyphs(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_has_show_text_glyphs(surface);
	}


/// <param name="surface">
/// </param>
/// <param name="extents">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle SurfaceMapToImage(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_rectangle_int_tHandle extents)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_map_to_image(surface, extents);
	}


/// <param name="surface">
/// </param>

	public static void SurfaceMarkDirty(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		cairoGlobalFunctionsExterns.cairo_surface_mark_dirty(surface);
	}


/// <param name="surface">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>
/// <param name="width">
/// </param>
/// <param name="height">
/// </param>

	public static void SurfaceMarkDirtyRectangle(MentorLake.cairo.cairo_surface_tHandle surface, int x, int y, int width, int height)
	{
		cairoGlobalFunctionsExterns.cairo_surface_mark_dirty_rectangle(surface, x, y, width, height);
	}


/// <param name="abstract_surface">
/// </param>
/// <param name="func">
/// </param>
/// <param name="data">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverAddFillCallback(MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_add_fill_callback(abstract_surface, func, data);
	}


/// <param name="abstract_surface">
/// </param>
/// <param name="func">
/// </param>
/// <param name="data">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverAddFinishCallback(MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_add_finish_callback(abstract_surface, func, data);
	}


/// <param name="abstract_surface">
/// </param>
/// <param name="func">
/// </param>
/// <param name="data">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverAddFlushCallback(MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_add_flush_callback(abstract_surface, func, data);
	}


/// <param name="abstract_surface">
/// </param>
/// <param name="func">
/// </param>
/// <param name="data">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverAddGlyphsCallback(MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_add_glyphs_callback(abstract_surface, func, data);
	}


/// <param name="abstract_surface">
/// </param>
/// <param name="func">
/// </param>
/// <param name="data">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverAddMaskCallback(MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_add_mask_callback(abstract_surface, func, data);
	}


/// <param name="abstract_surface">
/// </param>
/// <param name="func">
/// </param>
/// <param name="data">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverAddPaintCallback(MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_add_paint_callback(abstract_surface, func, data);
	}


/// <param name="abstract_surface">
/// </param>
/// <param name="func">
/// </param>
/// <param name="data">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverAddStrokeCallback(MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_add_stroke_callback(abstract_surface, func, data);
	}


/// <param name="surface">
/// </param>

	public static double SurfaceObserverElapsed(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_elapsed(surface);
	}


/// <param name="surface">
/// </param>
/// <param name="write_func">
/// </param>
/// <param name="closure">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceObserverPrint(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_write_func_t write_func, IntPtr closure)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_observer_print(surface, write_func, closure);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_surface_tHandle SurfaceReference(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_reference(surface);
	}


/// <param name="surface">
/// </param>
/// <param name="x_offset">
/// </param>
/// <param name="y_offset">
/// </param>

	public static void SurfaceSetDeviceOffset(MentorLake.cairo.cairo_surface_tHandle surface, double x_offset, double y_offset)
	{
		cairoGlobalFunctionsExterns.cairo_surface_set_device_offset(surface, x_offset, y_offset);
	}


/// <param name="surface">
/// </param>
/// <param name="x_scale">
/// </param>
/// <param name="y_scale">
/// </param>

	public static void SurfaceSetDeviceScale(MentorLake.cairo.cairo_surface_tHandle surface, double x_scale, double y_scale)
	{
		cairoGlobalFunctionsExterns.cairo_surface_set_device_scale(surface, x_scale, y_scale);
	}


/// <param name="surface">
/// </param>
/// <param name="x_pixels_per_inch">
/// </param>
/// <param name="y_pixels_per_inch">
/// </param>

	public static void SurfaceSetFallbackResolution(MentorLake.cairo.cairo_surface_tHandle surface, double x_pixels_per_inch, double y_pixels_per_inch)
	{
		cairoGlobalFunctionsExterns.cairo_surface_set_fallback_resolution(surface, x_pixels_per_inch, y_pixels_per_inch);
	}


/// <param name="surface">
/// </param>
/// <param name="mime_type">
/// </param>
/// <param name="data">
/// </param>
/// <param name="length">
/// </param>
/// <param name="destroy">
/// </param>
/// <param name="closure">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceSetMimeData(MentorLake.cairo.cairo_surface_tHandle surface, string mime_type, byte data, ulong length, MentorLake.cairo.cairo_destroy_func_t destroy, IntPtr closure)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_set_mime_data(surface, mime_type, data, length, destroy, closure);
	}


/// <param name="surface">
/// </param>
/// <param name="key">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="destroy">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceSetUserData(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_set_user_data(surface, key, user_data, destroy);
	}


/// <param name="surface">
/// </param>

	public static void SurfaceShowPage(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		cairoGlobalFunctionsExterns.cairo_surface_show_page(surface);
	}


/// <param name="surface">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceStatus(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_status(surface);
	}


/// <param name="surface">
/// </param>
/// <param name="mime_type">
/// </param>

	public static MentorLake.cairo.cairo_bool_t SurfaceSupportsMimeType(MentorLake.cairo.cairo_surface_tHandle surface, string mime_type)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_supports_mime_type(surface, mime_type);
	}


/// <param name="surface">
/// </param>
/// <param name="image">
/// </param>

	public static void SurfaceUnmapImage(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_surface_tHandle image)
	{
		cairoGlobalFunctionsExterns.cairo_surface_unmap_image(surface, image);
	}


/// <param name="surface">
/// </param>
/// <param name="filename">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceWriteToPng(MentorLake.cairo.cairo_surface_tHandle surface, string filename)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_write_to_png(surface, filename);
	}


/// <param name="surface">
/// </param>
/// <param name="write_func">
/// </param>
/// <param name="closure">
/// </param>

	public static MentorLake.cairo.cairo_status_t SurfaceWriteToPngStream(MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_write_func_t write_func, IntPtr closure)
	{
		return cairoGlobalFunctionsExterns.cairo_surface_write_to_png_stream(surface, write_func, closure);
	}


/// <param name="cr">
/// </param>
/// <param name="tag_name">
/// </param>
/// <param name="attributes">
/// </param>

	public static void TagBegin(MentorLake.cairo.cairo_tHandle cr, string tag_name, string attributes)
	{
		cairoGlobalFunctionsExterns.cairo_tag_begin(cr, tag_name, attributes);
	}


/// <param name="cr">
/// </param>
/// <param name="tag_name">
/// </param>

	public static void TagEnd(MentorLake.cairo.cairo_tHandle cr, string tag_name)
	{
		cairoGlobalFunctionsExterns.cairo_tag_end(cr, tag_name);
	}


/// <param name="num_clusters">
/// </param>

	public static MentorLake.cairo.cairo_text_cluster_tHandle TextClusterAllocate(int num_clusters)
	{
		return cairoGlobalFunctionsExterns.cairo_text_cluster_allocate(num_clusters);
	}


/// <param name="clusters">
/// </param>

	public static void TextClusterFree(MentorLake.cairo.cairo_text_cluster_tHandle clusters)
	{
		cairoGlobalFunctionsExterns.cairo_text_cluster_free(clusters);
	}


/// <param name="cr">
/// </param>
/// <param name="utf8">
/// </param>
/// <param name="extents">
/// </param>

	public static void TextExtents(MentorLake.cairo.cairo_tHandle cr, string utf8, MentorLake.cairo.cairo_text_extents_tHandle extents)
	{
		cairoGlobalFunctionsExterns.cairo_text_extents(cr, utf8, extents);
	}


/// <param name="cr">
/// </param>
/// <param name="utf8">
/// </param>

	public static void TextPath(MentorLake.cairo.cairo_tHandle cr, string utf8)
	{
		cairoGlobalFunctionsExterns.cairo_text_path(cr, utf8);
	}


/// <param name="family">
/// </param>
/// <param name="slant">
/// </param>
/// <param name="weight">
/// </param>

	public static MentorLake.cairo.cairo_font_face_tHandle ToyFontFaceCreate(string family, MentorLake.cairo.cairo_font_slant_t slant, MentorLake.cairo.cairo_font_weight_t weight)
	{
		return cairoGlobalFunctionsExterns.cairo_toy_font_face_create(family, slant, weight);
	}


/// <param name="font_face">
/// </param>

	public static string ToyFontFaceGetFamily(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_toy_font_face_get_family(font_face);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_font_slant_t ToyFontFaceGetSlant(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_toy_font_face_get_slant(font_face);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_font_weight_t ToyFontFaceGetWeight(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_toy_font_face_get_weight(font_face);
	}


/// <param name="cr">
/// </param>
/// <param name="matrix">
/// </param>

	public static void Transform(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_matrix_tHandle matrix)
	{
		cairoGlobalFunctionsExterns.cairo_transform(cr, matrix);
	}


/// <param name="cr">
/// </param>
/// <param name="tx">
/// </param>
/// <param name="ty">
/// </param>

	public static void Translate(MentorLake.cairo.cairo_tHandle cr, double tx, double ty)
	{
		cairoGlobalFunctionsExterns.cairo_translate(cr, tx, ty);
	}



	public static MentorLake.cairo.cairo_font_face_tHandle UserFontFaceCreate()
	{
		return cairoGlobalFunctionsExterns.cairo_user_font_face_create();
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_user_scaled_font_init_func_t UserFontFaceGetInitFunc(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_user_font_face_get_init_func(font_face);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_user_scaled_font_render_glyph_func_t UserFontFaceGetRenderGlyphFunc(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_user_font_face_get_render_glyph_func(font_face);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_user_scaled_font_text_to_glyphs_func_t UserFontFaceGetTextToGlyphsFunc(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_user_font_face_get_text_to_glyphs_func(font_face);
	}


/// <param name="font_face">
/// </param>

	public static MentorLake.cairo.cairo_user_scaled_font_unicode_to_glyph_func_t UserFontFaceGetUnicodeToGlyphFunc(MentorLake.cairo.cairo_font_face_tHandle font_face)
	{
		return cairoGlobalFunctionsExterns.cairo_user_font_face_get_unicode_to_glyph_func(font_face);
	}


/// <param name="font_face">
/// </param>
/// <param name="init_func">
/// </param>

	public static void UserFontFaceSetInitFunc(MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_init_func_t init_func)
	{
		cairoGlobalFunctionsExterns.cairo_user_font_face_set_init_func(font_face, init_func);
	}


/// <param name="font_face">
/// </param>
/// <param name="render_glyph_func">
/// </param>

	public static void UserFontFaceSetRenderGlyphFunc(MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_render_glyph_func_t render_glyph_func)
	{
		cairoGlobalFunctionsExterns.cairo_user_font_face_set_render_glyph_func(font_face, render_glyph_func);
	}


/// <param name="font_face">
/// </param>
/// <param name="text_to_glyphs_func">
/// </param>

	public static void UserFontFaceSetTextToGlyphsFunc(MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_text_to_glyphs_func_t text_to_glyphs_func)
	{
		cairoGlobalFunctionsExterns.cairo_user_font_face_set_text_to_glyphs_func(font_face, text_to_glyphs_func);
	}


/// <param name="font_face">
/// </param>
/// <param name="unicode_to_glyph_func">
/// </param>

	public static void UserFontFaceSetUnicodeToGlyphFunc(MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_unicode_to_glyph_func_t unicode_to_glyph_func)
	{
		cairoGlobalFunctionsExterns.cairo_user_font_face_set_unicode_to_glyph_func(font_face, unicode_to_glyph_func);
	}


/// <param name="cr">
/// </param>
/// <param name="x">
/// </param>
/// <param name="y">
/// </param>

	public static void UserToDevice(MentorLake.cairo.cairo_tHandle cr, double x, double y)
	{
		cairoGlobalFunctionsExterns.cairo_user_to_device(cr, x, y);
	}


/// <param name="cr">
/// </param>
/// <param name="dx">
/// </param>
/// <param name="dy">
/// </param>

	public static void UserToDeviceDistance(MentorLake.cairo.cairo_tHandle cr, double dx, double dy)
	{
		cairoGlobalFunctionsExterns.cairo_user_to_device_distance(cr, dx, dy);
	}



	public static int Version()
	{
		return cairoGlobalFunctionsExterns.cairo_version();
	}



	public static string VersionString()
	{
		return cairoGlobalFunctionsExterns.cairo_version_string();
	}

}

internal class cairoGlobalFunctionsExterns
{
	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_append_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_path_tHandle>))] MentorLake.cairo.cairo_path_tHandle path);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_arc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_arc_negative([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_clip_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_clip_preserve([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_close_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_list_tHandle>))]
	internal static extern MentorLake.cairo.cairo_rectangle_list_tHandle cairo_copy_clip_rectangle_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_copy_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_path_tHandle>))]
	internal static extern MentorLake.cairo.cairo_path_tHandle cairo_copy_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_path_tHandle>))]
	internal static extern MentorLake.cairo.cairo_path_tHandle cairo_copy_path_flat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))]
	internal static extern MentorLake.cairo.cairo_tHandle cairo_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle target);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_curve_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2, double x3, double y3);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_debug_reset_static_data();

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_device_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_device_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_device_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_device_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern uint cairo_device_get_reference_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_device_type_t cairo_device_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern IntPtr cairo_device_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_device_observer_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_device_observer_fill_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_device_observer_glyphs_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_device_observer_mask_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_device_observer_paint_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_device_observer_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device, MentorLake.cairo.cairo_write_func_t write_func, IntPtr closure);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_device_observer_stroke_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))]
	internal static extern MentorLake.cairo.cairo_device_tHandle cairo_device_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_device_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_device_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_device_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))] MentorLake.cairo.cairo_device_tHandle device);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_device_to_user([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_device_to_user_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dx, double dy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_fill_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_fill_preserve([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_extents_tHandle>))] MentorLake.cairo.cairo_font_extents_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_face_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern uint cairo_font_face_get_reference_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_font_type_t cairo_font_face_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern IntPtr cairo_font_face_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_face_tHandle cairo_font_face_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_font_face_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_font_face_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_options_tHandle cairo_font_options_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle original);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_options_tHandle cairo_font_options_create();

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_options_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_font_options_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle other);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_antialias_t cairo_font_options_get_antialias([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_hint_metrics_t cairo_font_options_get_hint_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_hint_style_t cairo_font_options_get_hint_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_subpixel_order_t cairo_font_options_get_subpixel_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string cairo_font_options_get_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern ulong cairo_font_options_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_options_merge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle other);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_options_set_antialias([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_antialias_t antialias);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_options_set_hint_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_hint_metrics_t hint_metrics);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_options_set_hint_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_hint_style_t hint_style);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_options_set_subpixel_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options, MentorLake.cairo.cairo_subpixel_order_t subpixel_order);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_font_options_set_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options, string variations);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_font_options_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern int cairo_format_stride_for_width(MentorLake.cairo.cairo_format_t format, int width);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_antialias_t cairo_get_antialias([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_get_current_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_get_dash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dashes, double offset);

	[DllImport(cairoLibrary.Name)]
	internal static extern int cairo_get_dash_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_fill_rule_t cairo_get_fill_rule([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_face_tHandle cairo_get_font_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_get_font_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_get_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_get_group_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_line_cap_t cairo_get_line_cap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_line_join_t cairo_get_line_join([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_get_line_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_get_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_get_miter_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_operator_t cairo_get_operator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern uint cairo_get_reference_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))]
	internal static extern MentorLake.cairo.cairo_scaled_font_tHandle cairo_get_scaled_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_get_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_get_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_get_tolerance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern IntPtr cairo_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_glyph_tHandle>))]
	internal static extern MentorLake.cairo.cairo_glyph_tHandle cairo_glyph_allocate(int num_glyphs);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_glyph_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_glyph_tHandle>))] MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_extents_tHandle>))] MentorLake.cairo.cairo_text_extents_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_glyph_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_glyph_tHandle>))] MentorLake.cairo.cairo_glyph_tHandle glyphs);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_glyph_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_glyph_tHandle>))] MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_has_current_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_identity_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_image_surface_create(MentorLake.cairo.cairo_format_t format, int width, int height);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_image_surface_create_for_data(byte[] data, MentorLake.cairo.cairo_format_t format, int width, int height, int stride);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_image_surface_create_from_png(string filename);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_image_surface_create_from_png_stream(MentorLake.cairo.cairo_read_func_t read_func, IntPtr closure);

	[DllImport(cairoLibrary.Name)]
	internal static extern byte cairo_image_surface_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_format_t cairo_image_surface_get_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern int cairo_image_surface_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern int cairo_image_surface_get_stride([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern int cairo_image_surface_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_in_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_in_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_in_stroke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_line_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mask_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double surface_x, double surface_y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double xx, double yx, double xy, double yy, double x0, double y0);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_init_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_init_rotate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double radians);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_init_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double sx, double sy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_init_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double tx, double ty);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_matrix_invert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_multiply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle b);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_rotate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double radians);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double sx, double sy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_transform_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double dx, double dy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_transform_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_matrix_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix, double tx, double ty);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_begin_patch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_curve_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double x1, double y1, double x2, double y2, double x3, double y3);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_end_patch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_mesh_pattern_get_control_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, uint patch_num, uint point_num, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_mesh_pattern_get_corner_color_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, uint patch_num, uint corner_num, double red, double green, double blue, double alpha);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_mesh_pattern_get_patch_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, uint count);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_path_tHandle>))]
	internal static extern MentorLake.cairo.cairo_path_tHandle cairo_mesh_pattern_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, uint patch_num);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_line_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_move_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_set_control_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, uint point_num, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_set_corner_color_rgb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, uint corner_num, double red, double green, double blue);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_mesh_pattern_set_corner_color_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, uint corner_num, double red, double green, double blue, double alpha);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_move_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_new_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_new_sub_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_paint_with_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double alpha);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_path_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_path_tHandle>))] MentorLake.cairo.cairo_path_tHandle path);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_path_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pattern_add_color_stop_rgb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double offset, double red, double green, double blue);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pattern_add_color_stop_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double offset, double red, double green, double blue, double alpha);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_create_for_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_create_linear(double x0, double y0, double x1, double y1);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_create_mesh();

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_create_radial(double cx0, double cy0, double radius0, double cx1, double cy1, double radius1);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_create_raster_source(IntPtr user_data, MentorLake.cairo.cairo_content_t content, int width, int height);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_create_rgb(double red, double green, double blue);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_create_rgba(double red, double green, double blue, double alpha);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pattern_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_get_color_stop_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, int count);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_get_color_stop_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, int index, double offset, double red, double green, double blue, double alpha);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_extend_t cairo_pattern_get_extend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_filter_t cairo_pattern_get_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_get_linear_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double x0, double y0, double x1, double y1);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pattern_get_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_get_radial_circles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double x0, double y0, double r0, double x1, double y1, double r1);

	[DllImport(cairoLibrary.Name)]
	internal static extern uint cairo_pattern_get_reference_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_get_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, double red, double green, double blue, double alpha);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_get_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_pattern_type_t cairo_pattern_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern IntPtr cairo_pattern_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pattern_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pattern_set_extend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_extend_t extend);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pattern_set_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_filter_t filter);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pattern_set_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_pattern_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle cairo_pop_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_pop_group_to_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_push_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_push_group_with_content([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_content_t content);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_raster_source_pattern_get_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_acquire_func_t acquire, MentorLake.cairo.cairo_raster_source_release_func_t release);

	[DllImport(cairoLibrary.Name)]
	internal static extern IntPtr cairo_raster_source_pattern_get_callback_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_raster_source_copy_func_t cairo_raster_source_pattern_get_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_raster_source_finish_func_t cairo_raster_source_pattern_get_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_raster_source_snapshot_func_t cairo_raster_source_pattern_get_snapshot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_raster_source_pattern_set_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_acquire_func_t acquire, MentorLake.cairo.cairo_raster_source_release_func_t release);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_raster_source_pattern_set_callback_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_raster_source_pattern_set_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_copy_func_t copy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_raster_source_pattern_set_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_finish_func_t finish);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_raster_source_pattern_set_snapshot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern, MentorLake.cairo.cairo_raster_source_snapshot_func_t snapshot);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_recording_surface_create(MentorLake.cairo.cairo_content_t content, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_tHandle>))] MentorLake.cairo.cairo_rectangle_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_recording_surface_get_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_tHandle>))] MentorLake.cairo.cairo_rectangle_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_recording_surface_ink_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x0, double y0, double width, double height);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_rectangle_list_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_list_tHandle>))] MentorLake.cairo.cairo_rectangle_list_tHandle rectangle_list);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))]
	internal static extern MentorLake.cairo.cairo_tHandle cairo_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_region_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, int x, int y);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_region_overlap_t cairo_region_contains_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rectangle);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle cairo_region_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle original);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle cairo_region_create();

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle cairo_region_create_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rectangle);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle cairo_region_create_rectangles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rects, int count);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_region_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_region_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle b);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_region_get_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_region_get_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, int nth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rectangle);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle other);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_intersect_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rectangle);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_region_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(cairoLibrary.Name)]
	internal static extern int cairo_region_num_rectangles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle cairo_region_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_subtract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle other);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_subtract_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rectangle);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_region_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, int dx, int dy);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle other);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_union_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rectangle);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_xor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle other);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_region_xor_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle dst, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle rectangle);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_rel_curve_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_rel_line_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dx, double dy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_rel_move_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dx, double dy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_reset_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_restore([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_rotate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double angle);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double sx, double sy);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))]
	internal static extern MentorLake.cairo.cairo_scaled_font_tHandle cairo_scaled_font_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle font_matrix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle ctm, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_extents_tHandle>))] MentorLake.cairo.cairo_font_extents_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_get_ctm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle ctm);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_face_tHandle cairo_scaled_font_get_font_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_get_font_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle font_matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_get_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern uint cairo_scaled_font_get_reference_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_get_scale_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle scale_matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_font_type_t cairo_scaled_font_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font);

	[DllImport(cairoLibrary.Name)]
	internal static extern IntPtr cairo_scaled_font_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_glyph_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_glyph_tHandle>))] MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_extents_tHandle>))] MentorLake.cairo.cairo_text_extents_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))]
	internal static extern MentorLake.cairo.cairo_scaled_font_tHandle cairo_scaled_font_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_scaled_font_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_scaled_font_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_scaled_font_text_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, string utf8, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_extents_tHandle>))] MentorLake.cairo.cairo_text_extents_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_scaled_font_text_to_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font, double x, double y, string utf8, int utf8_len, IntPtr glyphs, int num_glyphs, IntPtr clusters, int num_clusters, MentorLake.cairo.cairo_text_cluster_flags_t cluster_flags);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_select_font_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string family, MentorLake.cairo.cairo_font_slant_t slant, MentorLake.cairo.cairo_font_weight_t weight);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_antialias([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_antialias_t antialias);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_dash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dashes, int num_dashes, double offset);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_fill_rule([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_fill_rule_t fill_rule);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_font_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_font_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double size);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_line_cap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_line_cap_t line_cap);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_line_join([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_line_join_t line_join);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_line_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double width);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_miter_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double limit);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_operator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_operator_t op);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_scaled_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_scaled_font_tHandle>))] MentorLake.cairo.cairo_scaled_font_tHandle scaled_font);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle source);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_source_rgb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double red, double green, double blue);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_source_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double red, double green, double blue, double alpha);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_source_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_set_tolerance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double tolerance);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_show_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_glyph_tHandle>))] MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_show_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_show_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string utf8);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_show_text_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string utf8, int utf8_len, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_glyph_tHandle>))] MentorLake.cairo.cairo_glyph_tHandle glyphs, int num_glyphs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_cluster_tHandle>))] MentorLake.cairo.cairo_text_cluster_tHandle clusters, int num_clusters, MentorLake.cairo.cairo_text_cluster_flags_t cluster_flags);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string cairo_status_to_string(MentorLake.cairo.cairo_status_t status);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_stroke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_stroke_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x1, double y1, double x2, double y2);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_stroke_preserve([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_copy_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_surface_create_for_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle target, double x, double y, double width, double height);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_surface_create_observer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle target, MentorLake.cairo.cairo_surface_observer_mode_t mode);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_surface_create_similar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle other, MentorLake.cairo.cairo_content_t content, int width, int height);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_surface_create_similar_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle other, MentorLake.cairo.cairo_format_t format, int width, int height);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_content_t cairo_surface_get_content([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_device_tHandle>))]
	internal static extern MentorLake.cairo.cairo_device_tHandle cairo_surface_get_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_get_device_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x_offset, double y_offset);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_get_device_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x_scale, double y_scale);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_get_fallback_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x_pixels_per_inch, double y_pixels_per_inch);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_get_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_get_mime_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, string mime_type, IntPtr data, ulong length);

	[DllImport(cairoLibrary.Name)]
	internal static extern uint cairo_surface_get_reference_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_surface_type_t cairo_surface_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern IntPtr cairo_surface_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_surface_has_show_text_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_surface_map_to_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_rectangle_int_tHandle>))] MentorLake.cairo.cairo_rectangle_int_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_mark_dirty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_mark_dirty_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, int x, int y, int width, int height);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_add_fill_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_add_finish_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_add_flush_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_add_glyphs_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_add_mask_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_add_paint_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_add_stroke_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle abstract_surface, MentorLake.cairo.cairo_surface_observer_callback_t func, IntPtr data);

	[DllImport(cairoLibrary.Name)]
	internal static extern double cairo_surface_observer_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_observer_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_write_func_t write_func, IntPtr closure);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle cairo_surface_reference([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_set_device_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x_offset, double y_offset);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_set_device_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x_scale, double y_scale);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_set_fallback_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x_pixels_per_inch, double y_pixels_per_inch);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_set_mime_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, string mime_type, byte data, ulong length, MentorLake.cairo.cairo_destroy_func_t destroy, IntPtr closure);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_user_data_key_tHandle>))] MentorLake.cairo.cairo_user_data_key_tHandle key, IntPtr user_data, MentorLake.cairo.cairo_destroy_func_t destroy);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_show_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_bool_t cairo_surface_supports_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, string mime_type);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_surface_unmap_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle image);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_write_to_png([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, string filename);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_status_t cairo_surface_write_to_png_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, MentorLake.cairo.cairo_write_func_t write_func, IntPtr closure);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_tag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string tag_name, string attributes);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_tag_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string tag_name);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_cluster_tHandle>))]
	internal static extern MentorLake.cairo.cairo_text_cluster_tHandle cairo_text_cluster_allocate(int num_clusters);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_text_cluster_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_cluster_tHandle>))] MentorLake.cairo.cairo_text_cluster_tHandle clusters);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_text_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string utf8, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_text_extents_tHandle>))] MentorLake.cairo.cairo_text_extents_tHandle extents);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_text_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string utf8);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_face_tHandle cairo_toy_font_face_create(string family, MentorLake.cairo.cairo_font_slant_t slant, MentorLake.cairo.cairo_font_weight_t weight);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string cairo_toy_font_face_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_font_slant_t cairo_toy_font_face_get_slant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_font_weight_t cairo_toy_font_face_get_weight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_transform([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_matrix_tHandle>))] MentorLake.cairo.cairo_matrix_tHandle matrix);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double tx, double ty);

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_face_tHandle cairo_user_font_face_create();

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_user_scaled_font_init_func_t cairo_user_font_face_get_init_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_user_scaled_font_render_glyph_func_t cairo_user_font_face_get_render_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_user_scaled_font_text_to_glyphs_func_t cairo_user_font_face_get_text_to_glyphs_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_user_scaled_font_unicode_to_glyph_func_t cairo_user_font_face_get_unicode_to_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_user_font_face_set_init_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_init_func_t init_func);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_user_font_face_set_render_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_render_glyph_func_t render_glyph_func);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_user_font_face_set_text_to_glyphs_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_text_to_glyphs_func_t text_to_glyphs_func);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_user_font_face_set_unicode_to_glyph_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_face_tHandle>))] MentorLake.cairo.cairo_font_face_tHandle font_face, MentorLake.cairo.cairo_user_scaled_font_unicode_to_glyph_func_t unicode_to_glyph_func);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_user_to_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y);

	[DllImport(cairoLibrary.Name)]
	internal static extern void cairo_user_to_device_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dx, double dy);

	[DllImport(cairoLibrary.Name)]
	internal static extern int cairo_version();

	[DllImport(cairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string cairo_version_string();

}

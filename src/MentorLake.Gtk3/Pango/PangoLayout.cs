namespace MentorLake.Gtk3.Pango;

public class PangoLayoutHandle : GObjectHandle
{
	public static PangoLayoutHandle New(PangoContextHandle context)
	{
		return PangoLayoutExterns.pango_layout_new(context);
	}

	public static PangoLayoutHandle Deserialize(PangoContextHandle context, GBytesHandle bytes, PangoLayoutDeserializeFlags flags, out GErrorHandle error)
	{
		return PangoLayoutExterns.pango_layout_deserialize(context, bytes, flags, out error);
	}

}

public static class PangoLayoutHandleExtensions
{
	public static T ContextChanged<T>(this T layout) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_context_changed(layout);
		return layout;
	}

	public static PangoLayoutHandle Copy(this PangoLayoutHandle src)
	{
		return PangoLayoutExterns.pango_layout_copy(src);
	}

	public static PangoAlignment GetAlignment(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_alignment(layout);
	}

	public static PangoAttrListHandle GetAttributes(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_attributes(layout);
	}

	public static bool GetAutoDir(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_auto_dir(layout);
	}

	public static int GetBaseline(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_baseline(layout);
	}

	public static T GetCaretPos<T>(this T layout, int index_, out PangoRectangle strong_pos, out PangoRectangle weak_pos) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_get_caret_pos(layout, index_, out strong_pos, out weak_pos);
		return layout;
	}

	public static int GetCharacterCount(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_character_count(layout);
	}

	public static PangoContextHandle GetContext(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_context(layout);
	}

	public static T GetCursorPos<T>(this T layout, int index_, out PangoRectangle strong_pos, out PangoRectangle weak_pos) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_get_cursor_pos(layout, index_, out strong_pos, out weak_pos);
		return layout;
	}

	public static PangoDirection GetDirection(this PangoLayoutHandle layout, int index)
	{
		return PangoLayoutExterns.pango_layout_get_direction(layout, index);
	}

	public static PangoEllipsizeMode GetEllipsize(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_ellipsize(layout);
	}

	public static T GetExtents<T>(this T layout, out PangoRectangle ink_rect, out PangoRectangle logical_rect) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_get_extents(layout, out ink_rect, out logical_rect);
		return layout;
	}

	public static PangoFontDescriptionHandle GetFontDescription(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_font_description(layout);
	}

	public static int GetHeight(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_height(layout);
	}

	public static int GetIndent(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_indent(layout);
	}

	public static PangoLayoutIterHandle GetIter(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_iter(layout);
	}

	public static bool GetJustify(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_justify(layout);
	}

	public static bool GetJustifyLastLine(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_justify_last_line(layout);
	}

	public static PangoLayoutLineHandle GetLine(this PangoLayoutHandle layout, int line)
	{
		return PangoLayoutExterns.pango_layout_get_line(layout, line);
	}

	public static int GetLineCount(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_line_count(layout);
	}

	public static PangoLayoutLineHandle GetLineReadonly(this PangoLayoutHandle layout, int line)
	{
		return PangoLayoutExterns.pango_layout_get_line_readonly(layout, line);
	}

	public static float GetLineSpacing(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_line_spacing(layout);
	}

	public static GSListHandle GetLines(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_lines(layout);
	}

	public static GSListHandle GetLinesReadonly(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_lines_readonly(layout);
	}

	public static T GetLogAttrs<T>(this T layout, out PangoLogAttr[] attrs, out int n_attrs) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_get_log_attrs(layout, out attrs, out n_attrs);
		return layout;
	}

	public static IntPtr GetLogAttrsReadonly(this PangoLayoutHandle layout, out int n_attrs)
	{
		return PangoLayoutExterns.pango_layout_get_log_attrs_readonly(layout, out n_attrs);
	}

	public static T GetPixelExtents<T>(this T layout, out PangoRectangle ink_rect, out PangoRectangle logical_rect) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_get_pixel_extents(layout, out ink_rect, out logical_rect);
		return layout;
	}

	public static T GetPixelSize<T>(this T layout, out int width, out int height) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_get_pixel_size(layout, out width, out height);
		return layout;
	}

	public static uint GetSerial(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_serial(layout);
	}

	public static bool GetSingleParagraphMode(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_single_paragraph_mode(layout);
	}

	public static T GetSize<T>(this T layout, out int width, out int height) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_get_size(layout, out width, out height);
		return layout;
	}

	public static int GetSpacing(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_spacing(layout);
	}

	public static PangoTabArrayHandle GetTabs(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_tabs(layout);
	}

	public static string GetText(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_text(layout);
	}

	public static int GetUnknownGlyphsCount(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_unknown_glyphs_count(layout);
	}

	public static int GetWidth(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_width(layout);
	}

	public static PangoWrapMode GetWrap(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_get_wrap(layout);
	}

	public static T IndexToLineX<T>(this T layout, int index_, bool trailing, out int line, out int x_pos) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_index_to_line_x(layout, index_, trailing, out line, out x_pos);
		return layout;
	}

	public static T IndexToPos<T>(this T layout, int index_, out PangoRectangle pos) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_index_to_pos(layout, index_, out pos);
		return layout;
	}

	public static bool IsEllipsized(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_is_ellipsized(layout);
	}

	public static bool IsWrapped(this PangoLayoutHandle layout)
	{
		return PangoLayoutExterns.pango_layout_is_wrapped(layout);
	}

	public static T MoveCursorVisually<T>(this T layout, bool strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_move_cursor_visually(layout, strong, old_index, old_trailing, direction, out new_index, out new_trailing);
		return layout;
	}

	public static GBytesHandle Serialize(this PangoLayoutHandle layout, PangoLayoutSerializeFlags flags)
	{
		return PangoLayoutExterns.pango_layout_serialize(layout, flags);
	}

	public static T SetAlignment<T>(this T layout, PangoAlignment alignment) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_alignment(layout, alignment);
		return layout;
	}

	public static T SetAttributes<T>(this T layout, PangoAttrListHandle attrs) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_attributes(layout, attrs);
		return layout;
	}

	public static T SetAutoDir<T>(this T layout, bool auto_dir) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_auto_dir(layout, auto_dir);
		return layout;
	}

	public static T SetEllipsize<T>(this T layout, PangoEllipsizeMode ellipsize) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_ellipsize(layout, ellipsize);
		return layout;
	}

	public static T SetFontDescription<T>(this T layout, PangoFontDescriptionHandle desc) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_font_description(layout, desc);
		return layout;
	}

	public static T SetHeight<T>(this T layout, int height) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_height(layout, height);
		return layout;
	}

	public static T SetIndent<T>(this T layout, int indent) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_indent(layout, indent);
		return layout;
	}

	public static T SetJustify<T>(this T layout, bool justify) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_justify(layout, justify);
		return layout;
	}

	public static T SetJustifyLastLine<T>(this T layout, bool justify) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_justify_last_line(layout, justify);
		return layout;
	}

	public static T SetLineSpacing<T>(this T layout, float factor) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_line_spacing(layout, factor);
		return layout;
	}

	public static T SetMarkup<T>(this T layout, string markup, int length) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_markup(layout, markup, length);
		return layout;
	}

	public static T SetMarkupWithAccel<T>(this T layout, string markup, int length, char accel_marker, out string accel_char) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_markup_with_accel(layout, markup, length, accel_marker, out accel_char);
		return layout;
	}

	public static T SetSingleParagraphMode<T>(this T layout, bool setting) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_single_paragraph_mode(layout, setting);
		return layout;
	}

	public static T SetSpacing<T>(this T layout, int spacing) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_spacing(layout, spacing);
		return layout;
	}

	public static T SetTabs<T>(this T layout, PangoTabArrayHandle tabs) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_tabs(layout, tabs);
		return layout;
	}

	public static T SetText<T>(this T layout, string text, int length) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_text(layout, text, length);
		return layout;
	}

	public static T SetWidth<T>(this T layout, int width) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_width(layout, width);
		return layout;
	}

	public static T SetWrap<T>(this T layout, PangoWrapMode wrap) where T : PangoLayoutHandle
	{
		PangoLayoutExterns.pango_layout_set_wrap(layout, wrap);
		return layout;
	}

	public static bool WriteToFile(this PangoLayoutHandle layout, PangoLayoutSerializeFlags flags, string filename, out GErrorHandle error)
	{
		return PangoLayoutExterns.pango_layout_write_to_file(layout, flags, filename, out error);
	}

	public static bool XyToIndex(this PangoLayoutHandle layout, int x, int y, out int index_, out int trailing)
	{
		return PangoLayoutExterns.pango_layout_xy_to_index(layout, x, y, out index_, out trailing);
	}

}

internal class PangoLayoutExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutHandle pango_layout_new(PangoContextHandle context);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_context_changed(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutHandle pango_layout_copy(PangoLayoutHandle src);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAlignment pango_layout_get_alignment(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_layout_get_attributes(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_get_auto_dir(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_baseline(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_get_caret_pos(PangoLayoutHandle layout, int index_, out PangoRectangle strong_pos, out PangoRectangle weak_pos);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_character_count(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoContextHandle pango_layout_get_context(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_get_cursor_pos(PangoLayoutHandle layout, int index_, out PangoRectangle strong_pos, out PangoRectangle weak_pos);

	[DllImport(Libraries.Pango)]
	internal static extern PangoDirection pango_layout_get_direction(PangoLayoutHandle layout, int index);

	[DllImport(Libraries.Pango)]
	internal static extern PangoEllipsizeMode pango_layout_get_ellipsize(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_get_extents(PangoLayoutHandle layout, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_layout_get_font_description(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_height(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_indent(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutIterHandle pango_layout_get_iter(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_get_justify(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_get_justify_last_line(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutLineHandle pango_layout_get_line(PangoLayoutHandle layout, int line);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_line_count(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutLineHandle pango_layout_get_line_readonly(PangoLayoutHandle layout, int line);

	[DllImport(Libraries.Pango)]
	internal static extern float pango_layout_get_line_spacing(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern GSListHandle pango_layout_get_lines(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern GSListHandle pango_layout_get_lines_readonly(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_get_log_attrs(PangoLayoutHandle layout, out PangoLogAttr[] attrs, out int n_attrs);

	[DllImport(Libraries.Pango)]
	internal static extern IntPtr pango_layout_get_log_attrs_readonly(PangoLayoutHandle layout, out int n_attrs);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_get_pixel_extents(PangoLayoutHandle layout, out PangoRectangle ink_rect, out PangoRectangle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_get_pixel_size(PangoLayoutHandle layout, out int width, out int height);

	[DllImport(Libraries.Pango)]
	internal static extern uint pango_layout_get_serial(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_get_single_paragraph_mode(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_get_size(PangoLayoutHandle layout, out int width, out int height);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_spacing(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoTabArrayHandle pango_layout_get_tabs(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_layout_get_text(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_unknown_glyphs_count(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_layout_get_width(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern PangoWrapMode pango_layout_get_wrap(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_index_to_line_x(PangoLayoutHandle layout, int index_, bool trailing, out int line, out int x_pos);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_index_to_pos(PangoLayoutHandle layout, int index_, out PangoRectangle pos);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_is_ellipsized(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_is_wrapped(PangoLayoutHandle layout);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_move_cursor_visually(PangoLayoutHandle layout, bool strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing);

	[DllImport(Libraries.Pango)]
	internal static extern GBytesHandle pango_layout_serialize(PangoLayoutHandle layout, PangoLayoutSerializeFlags flags);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_alignment(PangoLayoutHandle layout, PangoAlignment alignment);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_attributes(PangoLayoutHandle layout, PangoAttrListHandle attrs);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_auto_dir(PangoLayoutHandle layout, bool auto_dir);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_ellipsize(PangoLayoutHandle layout, PangoEllipsizeMode ellipsize);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_font_description(PangoLayoutHandle layout, PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_height(PangoLayoutHandle layout, int height);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_indent(PangoLayoutHandle layout, int indent);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_justify(PangoLayoutHandle layout, bool justify);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_justify_last_line(PangoLayoutHandle layout, bool justify);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_line_spacing(PangoLayoutHandle layout, float factor);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_markup(PangoLayoutHandle layout, string markup, int length);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_markup_with_accel(PangoLayoutHandle layout, string markup, int length, char accel_marker, out string accel_char);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_single_paragraph_mode(PangoLayoutHandle layout, bool setting);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_spacing(PangoLayoutHandle layout, int spacing);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_tabs(PangoLayoutHandle layout, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_text(PangoLayoutHandle layout, string text, int length);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_width(PangoLayoutHandle layout, int width);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_layout_set_wrap(PangoLayoutHandle layout, PangoWrapMode wrap);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_write_to_file(PangoLayoutHandle layout, PangoLayoutSerializeFlags flags, string filename, out GErrorHandle error);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_layout_xy_to_index(PangoLayoutHandle layout, int x, int y, out int index_, out int trailing);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutHandle pango_layout_deserialize(PangoContextHandle context, GBytesHandle bytes, PangoLayoutDeserializeFlags flags, out GErrorHandle error);

}

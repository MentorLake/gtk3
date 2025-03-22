namespace MentorLake.Pango;

public class PangoLayoutHandle : GObjectHandle
{
	public static MentorLake.Pango.PangoLayoutHandle New(MentorLake.Pango.PangoContextHandle context)
	{
		return PangoLayoutHandleExterns.pango_layout_new(context);
	}

	public static MentorLake.Pango.PangoLayoutHandle Deserialize(MentorLake.Pango.PangoContextHandle context, MentorLake.GLib.GBytesHandle bytes, MentorLake.Pango.PangoLayoutDeserializeFlags flags)
	{
		return PangoLayoutHandleExterns.pango_layout_deserialize(context, bytes, flags);
	}

}

public static class PangoLayoutHandleExtensions
{
	public static T ContextChanged<T>(this T layout) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_context_changed(layout);
		return layout;
	}

	public static MentorLake.Pango.PangoLayoutHandle Copy(this MentorLake.Pango.PangoLayoutHandle src)
	{
		return PangoLayoutHandleExterns.pango_layout_copy(src);
	}

	public static MentorLake.Pango.PangoAlignment GetAlignment(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_alignment(layout);
	}

	public static MentorLake.Pango.PangoAttrListHandle GetAttributes(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_attributes(layout);
	}

	public static bool GetAutoDir(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_auto_dir(layout);
	}

	public static int GetBaseline(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_baseline(layout);
	}

	public static T GetCaretPos<T>(this T layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_get_caret_pos(layout, index_, out strong_pos, out weak_pos);
		return layout;
	}

	public static int GetCharacterCount(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_character_count(layout);
	}

	public static MentorLake.Pango.PangoContextHandle GetContext(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_context(layout);
	}

	public static T GetCursorPos<T>(this T layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_get_cursor_pos(layout, index_, out strong_pos, out weak_pos);
		return layout;
	}

	public static MentorLake.Pango.PangoDirection GetDirection(this MentorLake.Pango.PangoLayoutHandle layout, int index)
	{
		return PangoLayoutHandleExterns.pango_layout_get_direction(layout, index);
	}

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_ellipsize(layout);
	}

	public static T GetExtents<T>(this T layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_get_extents(layout, out ink_rect, out logical_rect);
		return layout;
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFontDescription(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_font_description(layout);
	}

	public static int GetHeight(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_height(layout);
	}

	public static int GetIndent(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_indent(layout);
	}

	public static MentorLake.Pango.PangoLayoutIterHandle GetIter(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_iter(layout);
	}

	public static bool GetJustify(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_justify(layout);
	}

	public static bool GetJustifyLastLine(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_justify_last_line(layout);
	}

	public static MentorLake.Pango.PangoLayoutLineHandle GetLine(this MentorLake.Pango.PangoLayoutHandle layout, int line)
	{
		return PangoLayoutHandleExterns.pango_layout_get_line(layout, line);
	}

	public static int GetLineCount(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_line_count(layout);
	}

	public static MentorLake.Pango.PangoLayoutLineHandle GetLineReadonly(this MentorLake.Pango.PangoLayoutHandle layout, int line)
	{
		return PangoLayoutHandleExterns.pango_layout_get_line_readonly(layout, line);
	}

	public static float GetLineSpacing(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_line_spacing(layout);
	}

	public static MentorLake.GLib.GSListHandle GetLines(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_lines(layout);
	}

	public static MentorLake.GLib.GSListHandle GetLinesReadonly(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_lines_readonly(layout);
	}

	public static T GetLogAttrs<T>(this T layout, out MentorLake.Pango.PangoLogAttr[] attrs, out int n_attrs) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_get_log_attrs(layout, out attrs, out n_attrs);
		return layout;
	}

	public static MentorLake.Pango.PangoLogAttr[] GetLogAttrsReadonly(this MentorLake.Pango.PangoLayoutHandle layout, out int n_attrs)
	{
		return PangoLayoutHandleExterns.pango_layout_get_log_attrs_readonly(layout, out n_attrs);
	}

	public static T GetPixelExtents<T>(this T layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_get_pixel_extents(layout, out ink_rect, out logical_rect);
		return layout;
	}

	public static T GetPixelSize<T>(this T layout, out int width, out int height) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_get_pixel_size(layout, out width, out height);
		return layout;
	}

	public static uint GetSerial(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_serial(layout);
	}

	public static bool GetSingleParagraphMode(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_single_paragraph_mode(layout);
	}

	public static T GetSize<T>(this T layout, out int width, out int height) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_get_size(layout, out width, out height);
		return layout;
	}

	public static int GetSpacing(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_spacing(layout);
	}

	public static MentorLake.Pango.PangoTabArrayHandle GetTabs(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_tabs(layout);
	}

	public static string GetText(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_text(layout);
	}

	public static int GetUnknownGlyphsCount(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_unknown_glyphs_count(layout);
	}

	public static int GetWidth(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_width(layout);
	}

	public static MentorLake.Pango.PangoWrapMode GetWrap(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_get_wrap(layout);
	}

	public static T IndexToLineX<T>(this T layout, int index_, bool trailing, out int line, out int x_pos) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_index_to_line_x(layout, index_, trailing, out line, out x_pos);
		return layout;
	}

	public static T IndexToPos<T>(this T layout, int index_, out MentorLake.Pango.PangoRectangle pos) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_index_to_pos(layout, index_, out pos);
		return layout;
	}

	public static bool IsEllipsized(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_is_ellipsized(layout);
	}

	public static bool IsWrapped(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		return PangoLayoutHandleExterns.pango_layout_is_wrapped(layout);
	}

	public static T MoveCursorVisually<T>(this T layout, bool strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_move_cursor_visually(layout, strong, old_index, old_trailing, direction, out new_index, out new_trailing);
		return layout;
	}

	public static MentorLake.GLib.GBytesHandle Serialize(this MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags)
	{
		return PangoLayoutHandleExterns.pango_layout_serialize(layout, flags);
	}

	public static T SetAlignment<T>(this T layout, MentorLake.Pango.PangoAlignment alignment) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_alignment(layout, alignment);
		return layout;
	}

	public static T SetAttributes<T>(this T layout, MentorLake.Pango.PangoAttrListHandle attrs) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_attributes(layout, attrs);
		return layout;
	}

	public static T SetAutoDir<T>(this T layout, bool auto_dir) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_auto_dir(layout, auto_dir);
		return layout;
	}

	public static T SetEllipsize<T>(this T layout, MentorLake.Pango.PangoEllipsizeMode ellipsize) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_ellipsize(layout, ellipsize);
		return layout;
	}

	public static T SetFontDescription<T>(this T layout, MentorLake.Pango.PangoFontDescriptionHandle desc) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_font_description(layout, desc);
		return layout;
	}

	public static T SetHeight<T>(this T layout, int height) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_height(layout, height);
		return layout;
	}

	public static T SetIndent<T>(this T layout, int indent) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_indent(layout, indent);
		return layout;
	}

	public static T SetJustify<T>(this T layout, bool justify) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_justify(layout, justify);
		return layout;
	}

	public static T SetJustifyLastLine<T>(this T layout, bool justify) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_justify_last_line(layout, justify);
		return layout;
	}

	public static T SetLineSpacing<T>(this T layout, float factor) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_line_spacing(layout, factor);
		return layout;
	}

	public static T SetMarkup<T>(this T layout, string markup, int length) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_markup(layout, markup, length);
		return layout;
	}

	public static T SetMarkupWithAccel<T>(this T layout, string markup, int length, char accel_marker, out char accel_char) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_markup_with_accel(layout, markup, length, accel_marker, out accel_char);
		return layout;
	}

	public static T SetSingleParagraphMode<T>(this T layout, bool setting) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_single_paragraph_mode(layout, setting);
		return layout;
	}

	public static T SetSpacing<T>(this T layout, int spacing) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_spacing(layout, spacing);
		return layout;
	}

	public static T SetTabs<T>(this T layout, MentorLake.Pango.PangoTabArrayHandle tabs) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_tabs(layout, tabs);
		return layout;
	}

	public static T SetText<T>(this T layout, string text, int length) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_text(layout, text, length);
		return layout;
	}

	public static T SetWidth<T>(this T layout, int width) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_width(layout, width);
		return layout;
	}

	public static T SetWrap<T>(this T layout, MentorLake.Pango.PangoWrapMode wrap) where T : PangoLayoutHandle
	{
		PangoLayoutHandleExterns.pango_layout_set_wrap(layout, wrap);
		return layout;
	}

	public static bool WriteToFile(this MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags, string filename)
	{
		return PangoLayoutHandleExterns.pango_layout_write_to_file(layout, flags, filename);
	}

	public static bool XyToIndex(this MentorLake.Pango.PangoLayoutHandle layout, int x, int y, out int index_, out int trailing)
	{
		return PangoLayoutHandleExterns.pango_layout_xy_to_index(layout, x, y, out index_, out trailing);
	}

}

internal class PangoLayoutHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_layout_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_context_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_layout_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle src);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAlignment pango_layout_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_layout_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_auto_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_caret_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_character_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoContextHandle pango_layout_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_cursor_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_layout_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode pango_layout_get_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_layout_get_font_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_indent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutIterHandle pango_layout_get_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_justify_last_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_layout_get_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int line);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_line_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_layout_get_line_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int line);

	[DllImport(PangoLibrary.Name)]
	internal static extern float pango_layout_get_line_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle pango_layout_get_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle pango_layout_get_lines_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_log_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out MentorLake.Pango.PangoLogAttr[] attrs, out int n_attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLogAttr[] pango_layout_get_log_attrs_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out int n_attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_pixel_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_pixel_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out int width, out int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_layout_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_single_paragraph_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out int width, out int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_layout_get_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_layout_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_unknown_glyphs_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoWrapMode pango_layout_get_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_index_to_line_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, bool trailing, out int line, out int x_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_index_to_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, out MentorLake.Pango.PangoRectangle pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_is_ellipsized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_is_wrapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_move_cursor_visually([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle pango_layout_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoAlignment alignment);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_auto_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool auto_dir);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoEllipsizeMode ellipsize);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_font_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_indent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int indent);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool justify);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_justify_last_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool justify);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_line_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, float factor);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, string markup, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_markup_with_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, string markup, int length, char accel_marker, out char accel_char);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_single_paragraph_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool setting);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int spacing);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tabs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, string text, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int width);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoWrapMode wrap);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_write_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags, string filename);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_xy_to_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int x, int y, out int index_, out int trailing);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_layout_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, MentorLake.Pango.PangoLayoutDeserializeFlags flags);

}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The frame widget is a bin that surrounds its child with a decorative
/// frame and an optional label. If present, the label is drawn in a gap
/// in the top side of the frame. The position of the label can be
/// controlled with gtk_frame_set_label_align().
/// </para>
/// <para>
/// # GtkFrame as GtkBuildable
/// </para>
/// <para>
/// The GtkFrame implementation of the #GtkBuildable interface supports
/// placing a child in the label position by specifying “label” as the
/// “type” attribute of a `&amp;lt;child&amp;gt;` element. A normal content child can
/// be specified without specifying a `&amp;lt;child&amp;gt;` type attribute.
/// </para>
/// <para>
/// An example of a UI definition fragment with `GtkFrame`:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkFrame&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkFrame&quot;&amp;gt;
///   &amp;lt;child type=&quot;label&quot;&amp;gt;
///     &amp;lt;object class=&quot;GtkLabel&quot; id=&quot;frame-label&quot;/&amp;gt;
///   &amp;lt;/child&amp;gt;
///   &amp;lt;child&amp;gt;
///     &amp;lt;object class=&quot;GtkEntry&quot; id=&quot;frame-content&quot;/&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// frame
/// frame
/// ├── border[.flat]
/// ├── &amp;lt;label widget&amp;gt;
/// ╰── &amp;lt;child&amp;gt;
/// </code>
/// <para>
/// GtkFrame has a main CSS node named “frame” and a subnode named “border”. The
/// “border” node is used to draw the visible border. You can set the appearance
/// of the border using CSS properties like “border-style” on the “border” node.
/// </para>
/// <para>
/// The border node can be given the style class “.flat”, which is used by themes
/// to disable drawing of the border. To do this from code, call
/// gtk_frame_set_shadow_type() with %GTK_SHADOW_NONE to add the “.flat” class or
/// any other shadow type to remove it.
/// </para>
/// </summary>

public class GtkFrameHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFrame, with optional label @label.
/// If @label is %NULL, the label is omitted.
/// </para>
/// </summary>

/// <param name="label">
/// the text to use as the label of the frame
/// </param>
/// <return>
/// a new #GtkFrame widget
/// </return>

	public static MentorLake.Gtk.GtkFrameHandle New(string label)
	{
		return GtkFrameHandleExterns.gtk_frame_new(label);
	}

}

public static class GtkFrameHandleExtensions
{
/// <summary>
/// <para>
/// If the frame’s label widget is a #GtkLabel, returns the
/// text in the label widget. (The frame will have a #GtkLabel
/// for the label widget if a non-%NULL argument was passed
/// to gtk_frame_new().)
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <return>
/// the text in the label, or %NULL if there
///               was no label widget or the lable widget was not
///               a #GtkLabel. This string is owned by GTK+ and
///               must not be modified or freed.
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkFrameHandle frame)
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		return GtkFrameHandleExterns.gtk_frame_get_label(frame);
	}

/// <summary>
/// <para>
/// Retrieves the X and Y alignment of the frame’s label. See
/// gtk_frame_set_label_align().
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <param name="xalign">
/// location to store X alignment of
///     frame’s label, or %NULL
/// </param>
/// <param name="yalign">
/// location to store X alignment of
///     frame’s label, or %NULL
/// </param>

	public static T GetLabelAlign<T>(this T frame, out float xalign, out float yalign) where T : GtkFrameHandle
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		GtkFrameHandleExterns.gtk_frame_get_label_align(frame, out xalign, out yalign);
		return frame;
	}

/// <summary>
/// <para>
/// Retrieves the label widget for the frame. See
/// gtk_frame_set_label_widget().
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <return>
/// the label widget, or %NULL if
/// there is none.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkFrameHandle frame)
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		return GtkFrameHandleExterns.gtk_frame_get_label_widget(frame);
	}

/// <summary>
/// <para>
/// Retrieves the shadow type of the frame. See
/// gtk_frame_set_shadow_type().
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <return>
/// the current shadow type of the frame.
/// </return>

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkFrameHandle frame)
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		return GtkFrameHandleExterns.gtk_frame_get_shadow_type(frame);
	}

/// <summary>
/// <para>
/// Removes the current #GtkFrame:label-widget. If @label is not %NULL, creates a
/// new #GtkLabel with that text and adds it as the #GtkFrame:label-widget.
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <param name="label">
/// the text to use as the label of the frame
/// </param>

	public static T SetLabel<T>(this T frame, string label) where T : GtkFrameHandle
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		GtkFrameHandleExterns.gtk_frame_set_label(frame, label);
		return frame;
	}

/// <summary>
/// <para>
/// Sets the alignment of the frame widget’s label. The
/// default values for a newly created frame are 0.0 and 0.5.
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <param name="xalign">
/// The position of the label along the top edge
///   of the widget. A value of 0.0 represents left alignment;
///   1.0 represents right alignment.
/// </param>
/// <param name="yalign">
/// The y alignment of the label. A value of 0.0 aligns under
///   the frame; 1.0 aligns above the frame. If the values are exactly
///   0.0 or 1.0 the gap in the frame won’t be painted because the label
///   will be completely above or below the frame.
/// </param>

	public static T SetLabelAlign<T>(this T frame, float xalign, float yalign) where T : GtkFrameHandle
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		GtkFrameHandleExterns.gtk_frame_set_label_align(frame, xalign, yalign);
		return frame;
	}

/// <summary>
/// <para>
/// Sets the #GtkFrame:label-widget for the frame. This is the widget that
/// will appear embedded in the top edge of the frame as a title.
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <param name="label_widget">
/// the new label widget
/// </param>

	public static T SetLabelWidget<T>(this T frame, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkFrameHandle
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		GtkFrameHandleExterns.gtk_frame_set_label_widget(frame, label_widget);
		return frame;
	}

/// <summary>
/// <para>
/// Sets the #GtkFrame:shadow-type for @frame, i.e. whether it is drawn without
/// (%GTK_SHADOW_NONE) or with (other values) a visible border. Values other than
/// %GTK_SHADOW_NONE are treated identically by GtkFrame. The chosen type is
/// applied by removing or adding the .flat class to the CSS node named border.
/// </para>
/// </summary>

/// <param name="frame">
/// a #GtkFrame
/// </param>
/// <param name="type">
/// the new #GtkShadowType
/// </param>

	public static T SetShadowType<T>(this T frame, MentorLake.Gtk.GtkShadowType type) where T : GtkFrameHandle
	{
		if (frame.IsInvalid) throw new Exception("Invalid handle (GtkFrameHandle)");
		GtkFrameHandleExterns.gtk_frame_set_shadow_type(frame, type);
		return frame;
	}

}

internal class GtkFrameHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))]
	internal static extern MentorLake.Gtk.GtkFrameHandle gtk_frame_new(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_frame_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_get_label_align([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, out float xalign, out float yalign);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_frame_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShadowType gtk_frame_get_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_label_align([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, float xalign, float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, MentorLake.Gtk.GtkShadowType type);

}

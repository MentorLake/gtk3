namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkArrow should be used to draw simple arrows that need to point in
/// one of the four cardinal directions (up, down, left, or right).  The
/// style of the arrow can be one of shadow in, shadow out, etched in, or
/// etched out.  Note that these directions and style types may be
/// amended in versions of GTK+ to come.
/// </para>
/// <para>
/// GtkArrow will fill any space alloted to it, but since it is inherited
/// from #GtkMisc, it can be padded and/or aligned, to fill exactly the
/// space the programmer desires.
/// </para>
/// <para>
/// Arrows are created with a call to gtk_arrow_new().  The direction or
/// style of an arrow can be changed after creation by using gtk_arrow_set().
/// </para>
/// <para>
/// GtkArrow has been deprecated; you can simply use a #GtkImage with a
/// suitable icon name, such as “pan-down-symbolic“. When replacing
/// GtkArrow by an image, pay attention to the fact that GtkArrow is
/// doing automatic flipping between #GTK_ARROW_LEFT and #GTK_ARROW_RIGHT,
/// depending on the text direction. To get the same effect with an image,
/// use the icon names “pan-start-symbolic“ and “pan-end-symbolic“, which
/// react to the text direction.
/// </para>
/// </summary>

public class GtkArrowHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkArrow widget.
/// </para>
/// </summary>

/// <param name="arrow_type">
/// a valid #GtkArrowType.
/// </param>
/// <param name="shadow_type">
/// a valid #GtkShadowType.
/// </param>
/// <return>
/// the new #GtkArrow widget.
/// </return>

	public static MentorLake.Gtk.GtkArrowHandle New(MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type)
	{
		return GtkArrowHandleExterns.gtk_arrow_new(arrow_type, shadow_type);
	}

}

public static class GtkArrowHandleExtensions
{
/// <summary>
/// <para>
/// Sets the direction and style of the #GtkArrow, @arrow.
/// </para>
/// </summary>

/// <param name="arrow">
/// a widget of type #GtkArrow.
/// </param>
/// <param name="arrow_type">
/// a valid #GtkArrowType.
/// </param>
/// <param name="shadow_type">
/// a valid #GtkShadowType.
/// </param>

	public static T Set<T>(this T arrow, MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type) where T : GtkArrowHandle
	{
		if (arrow.IsInvalid) throw new Exception("Invalid handle (GtkArrowHandle)");
		GtkArrowHandleExterns.gtk_arrow_set(arrow, arrow_type, shadow_type);
		return arrow;
	}

}

internal class GtkArrowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkArrowHandle>))]
	internal static extern MentorLake.Gtk.GtkArrowHandle gtk_arrow_new(MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_arrow_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkArrowHandle>))] MentorLake.Gtk.GtkArrowHandle arrow, MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type);

}

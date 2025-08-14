namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkHScale widget is used to allow the user to select a value using
/// a horizontal slider. To create one, use gtk_hscale_new_with_range().
/// </para>
/// <para>
/// The position to show the current value, and the number of decimal places
/// shown can be set using the parent #GtkScale class’s functions.
/// </para>
/// <para>
/// GtkHScale has been deprecated, use #GtkScale instead.
/// </para>
/// </summary>

public class GtkHScaleHandle : GtkScaleHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkHScale.
/// </para>
/// </summary>

/// <param name="adjustment">
/// the #GtkAdjustment which sets the range of
/// the scale.
/// </param>
/// <return>
/// a new #GtkHScale.
/// </return>

	public static MentorLake.Gtk.GtkHScaleHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkHScaleHandleExterns.gtk_hscale_new(adjustment);
	}

/// <summary>
/// <para>
/// Creates a new horizontal scale widget that lets the user input a
/// number between @min and @max (including @min and @max) with the
/// increment @step.  @step must be nonzero; it’s the distance the
/// slider moves when using the arrow keys to adjust the scale value.
/// </para>
/// <para>
/// Note that the way in which the precision is derived works best if @step
/// is a power of ten. If the resulting precision is not suitable for your
/// needs, use gtk_scale_set_digits() to correct it.
/// </para>
/// </summary>

/// <param name="min">
/// minimum value
/// </param>
/// <param name="max">
/// maximum value
/// </param>
/// <param name="step">
/// step increment (tick size) used with keyboard shortcuts
/// </param>
/// <return>
/// a new #GtkHScale
/// </return>

	public static MentorLake.Gtk.GtkHScaleHandle NewWithRange(double min, double max, double step)
	{
		return GtkHScaleHandleExterns.gtk_hscale_new_with_range(min, max, step);
	}

}

public static class GtkHScaleHandleExtensions
{
}

internal class GtkHScaleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkHScaleHandle gtk_hscale_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkHScaleHandle gtk_hscale_new_with_range(double min, double max, double step);

}

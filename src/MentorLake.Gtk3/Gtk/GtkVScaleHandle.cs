namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkVScale widget is used to allow the user to select a value using
/// a vertical slider. To create one, use gtk_hscale_new_with_range().
/// </para>
/// <para>
/// The position to show the current value, and the number of decimal places
/// shown can be set using the parent #GtkScale class’s functions.
/// </para>
/// <para>
/// GtkVScale has been deprecated, use #GtkScale instead.
/// </para>
/// </summary>

public class GtkVScaleHandle : GtkScaleHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkVScale.
/// </para>
/// </summary>

/// <param name="adjustment">
/// the #GtkAdjustment which sets the range of the scale.
/// </param>
/// <return>
/// a new #GtkVScale.
/// </return>

	public static MentorLake.Gtk.GtkVScaleHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkVScaleHandleExterns.gtk_vscale_new(adjustment);
	}

/// <summary>
/// <para>
/// Creates a new vertical scale widget that lets the user input a
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
/// a new #GtkVScale
/// </return>

	public static MentorLake.Gtk.GtkVScaleHandle NewWithRange(double min, double max, double step)
	{
		return GtkVScaleHandleExterns.gtk_vscale_new_with_range(min, max, step);
	}

}

public static class GtkVScaleHandleExtensions
{
}

internal class GtkVScaleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkVScaleHandle gtk_vscale_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkVScaleHandle gtk_vscale_new_with_range(double min, double max, double step);

}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkVolumeButton is a subclass of #GtkScaleButton that has
/// been tailored for use as a volume control widget with suitable
/// icons, tooltips and accessible labels.
/// </para>
/// </summary>

public class GtkVolumeButtonHandle : GtkScaleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a #GtkVolumeButton, with a range between 0.0 and 1.0, with
/// a stepping of 0.02. Volume values can be obtained and modified using
/// the functions from #GtkScaleButton.
/// </para>
/// </summary>

/// <return>
/// a new #GtkVolumeButton
/// </return>

	public static MentorLake.Gtk.GtkVolumeButtonHandle New()
	{
		return GtkVolumeButtonHandleExterns.gtk_volume_button_new();
	}

}

public static class GtkVolumeButtonHandleExtensions
{
}

internal class GtkVolumeButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVolumeButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkVolumeButtonHandle gtk_volume_button_new();

}

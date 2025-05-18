namespace MentorLake.Gtk;

public class GtkVolumeButtonHandle : GtkScaleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkOrientableHandle
{
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

namespace MentorLake.Gtk;

public class GtkVolumeButtonClassHandle : BaseSafeHandle
{
}


public static class GtkVolumeButtonClassExtensions
{

	public static GtkVolumeButtonClass Dereference(this GtkVolumeButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkVolumeButtonClass>(x.DangerousGetHandle());
}
internal class GtkVolumeButtonClassExterns
{
}

public struct GtkVolumeButtonClass
{
	public GtkScaleButtonClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

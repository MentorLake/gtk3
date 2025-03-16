namespace MentorLake.Gtk;

public class GtkLinkButtonClassHandle : BaseSafeHandle
{
}


public static class GtkLinkButtonClassExtensions
{

	public static GtkLinkButtonClass Dereference(this GtkLinkButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLinkButtonClass>(x.DangerousGetHandle());
}
internal class GtkLinkButtonClassExterns
{
}

public struct GtkLinkButtonClass
{
	public IntPtr activate_link;
	public IntPtr _gtk_padding1;
	public IntPtr _gtk_padding2;
	public IntPtr _gtk_padding3;
	public IntPtr _gtk_padding4;
}

namespace MentorLake.Gtk;


public class GtkScaleButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkScaleButtonPrivateExtensions
{

	public static GtkScaleButtonPrivate Dereference(this GtkScaleButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScaleButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkScaleButtonPrivateExterns
{
}


public struct GtkScaleButtonPrivate
{
}

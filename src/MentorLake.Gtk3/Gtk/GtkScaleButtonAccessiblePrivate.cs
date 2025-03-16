namespace MentorLake.Gtk;

public class GtkScaleButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkScaleButtonAccessiblePrivateExtensions
{

	public static GtkScaleButtonAccessiblePrivate Dereference(this GtkScaleButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScaleButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkScaleButtonAccessiblePrivateExterns
{
}

public struct GtkScaleButtonAccessiblePrivate
{
}

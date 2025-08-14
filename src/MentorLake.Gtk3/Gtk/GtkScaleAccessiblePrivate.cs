namespace MentorLake.Gtk;


public class GtkScaleAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkScaleAccessiblePrivateExtensions
{

	public static GtkScaleAccessiblePrivate Dereference(this GtkScaleAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScaleAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkScaleAccessiblePrivateExterns
{
}


public struct GtkScaleAccessiblePrivate
{
}

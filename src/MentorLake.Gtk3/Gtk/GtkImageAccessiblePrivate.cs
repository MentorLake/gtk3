namespace MentorLake.Gtk;


public class GtkImageAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkImageAccessiblePrivateExtensions
{

	public static GtkImageAccessiblePrivate Dereference(this GtkImageAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImageAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkImageAccessiblePrivateExterns
{
}


public struct GtkImageAccessiblePrivate
{
}

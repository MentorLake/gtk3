namespace MentorLake.Gtk;


public class GtkImageMenuItemPrivateHandle : BaseSafeHandle
{
}


public static class GtkImageMenuItemPrivateExtensions
{

	public static GtkImageMenuItemPrivate Dereference(this GtkImageMenuItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImageMenuItemPrivate>(x.DangerousGetHandle());
}
internal class GtkImageMenuItemPrivateExterns
{
}


public struct GtkImageMenuItemPrivate
{
}

namespace MentorLake.Gtk;


public class GtkFileChooserButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkFileChooserButtonPrivateExtensions
{

	public static GtkFileChooserButtonPrivate Dereference(this GtkFileChooserButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkFileChooserButtonPrivateExterns
{
}


public struct GtkFileChooserButtonPrivate
{
}

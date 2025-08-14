namespace MentorLake.Gtk;


public class GtkMessageDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkMessageDialogPrivateExtensions
{

	public static GtkMessageDialogPrivate Dereference(this GtkMessageDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMessageDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkMessageDialogPrivateExterns
{
}


public struct GtkMessageDialogPrivate
{
}

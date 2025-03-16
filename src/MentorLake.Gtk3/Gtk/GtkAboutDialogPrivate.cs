namespace MentorLake.Gtk;

public class GtkAboutDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkAboutDialogPrivateExtensions
{

	public static GtkAboutDialogPrivate Dereference(this GtkAboutDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAboutDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkAboutDialogPrivateExterns
{
}

public struct GtkAboutDialogPrivate
{
}

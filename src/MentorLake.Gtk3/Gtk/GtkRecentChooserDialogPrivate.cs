namespace MentorLake.Gtk;


public class GtkRecentChooserDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserDialogPrivateExtensions
{

	public static GtkRecentChooserDialogPrivate Dereference(this GtkRecentChooserDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkRecentChooserDialogPrivateExterns
{
}


public struct GtkRecentChooserDialogPrivate
{
}

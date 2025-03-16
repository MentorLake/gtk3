namespace MentorLake.Gtk;

public class GtkRecentChooserMenuPrivateHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserMenuPrivateExtensions
{

	public static GtkRecentChooserMenuPrivate Dereference(this GtkRecentChooserMenuPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserMenuPrivate>(x.DangerousGetHandle());
}
internal class GtkRecentChooserMenuPrivateExterns
{
}

public struct GtkRecentChooserMenuPrivate
{
}

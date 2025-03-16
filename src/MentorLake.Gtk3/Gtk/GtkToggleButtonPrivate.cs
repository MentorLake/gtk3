namespace MentorLake.Gtk;

public class GtkToggleButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkToggleButtonPrivateExtensions
{

	public static GtkToggleButtonPrivate Dereference(this GtkToggleButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkToggleButtonPrivateExterns
{
}

public struct GtkToggleButtonPrivate
{
}

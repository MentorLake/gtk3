namespace MentorLake.Gtk;


public class GtkSwitchAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkSwitchAccessiblePrivateExtensions
{

	public static GtkSwitchAccessiblePrivate Dereference(this GtkSwitchAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSwitchAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkSwitchAccessiblePrivateExterns
{
}


public struct GtkSwitchAccessiblePrivate
{
}

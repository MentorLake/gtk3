namespace MentorLake.Gtk;

public class GtkSwitchPrivateHandle : BaseSafeHandle
{
}


public static class GtkSwitchPrivateExtensions
{

	public static GtkSwitchPrivate Dereference(this GtkSwitchPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSwitchPrivate>(x.DangerousGetHandle());
}
internal class GtkSwitchPrivateExterns
{
}

public struct GtkSwitchPrivate
{
}

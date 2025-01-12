namespace MentorLake.Gtk3.GLib;

public class GSListHandle : BaseSafeHandle
{
}


public static class GSListHandleExtensions
{
}
internal class GSListExterns
{
}

public struct GSList
{
	public IntPtr data;
	public GSListHandle next;
}

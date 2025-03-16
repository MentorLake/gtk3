namespace MentorLake.Gtk;

public class GtkPadActionEntryHandle : BaseSafeHandle
{
}


public static class GtkPadActionEntryExtensions
{

	public static GtkPadActionEntry Dereference(this GtkPadActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPadActionEntry>(x.DangerousGetHandle());
}
internal class GtkPadActionEntryExterns
{
}

public struct GtkPadActionEntry
{
	public GtkPadActionType type;
	public int index;
	public int mode;
	public string label;
	public string action_name;
}

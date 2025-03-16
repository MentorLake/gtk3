namespace MentorLake.Gtk;

public class GtkRadioActionEntryHandle : BaseSafeHandle
{
}


public static class GtkRadioActionEntryExtensions
{

	public static GtkRadioActionEntry Dereference(this GtkRadioActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioActionEntry>(x.DangerousGetHandle());
}
internal class GtkRadioActionEntryExterns
{
}

public struct GtkRadioActionEntry
{
	public string name;
	public string stock_id;
	public string label;
	public string accelerator;
	public string tooltip;
	public int value;
}

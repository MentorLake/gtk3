namespace MentorLake.Gtk3.Gtk3;

public class GtkRcPropertyHandle : BaseSafeHandle
{
}


public static class GtkRcPropertyHandleExtensions
{
}
internal class GtkRcPropertyExterns
{
}

public struct GtkRcProperty
{
	public GQuark type_name;
	public GQuark property_name;
	public string origin;
	public GValue value;
}

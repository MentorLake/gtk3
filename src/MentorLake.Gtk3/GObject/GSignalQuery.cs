namespace MentorLake.Gtk3.GObject;

public class GSignalQueryHandle : BaseSafeHandle
{
}


public static class GSignalQueryHandleExtensions
{
}
internal class GSignalQueryExterns
{
}

public struct GSignalQuery
{
	public uint signal_id;
	public string signal_name;
	public GType itype;
	public GSignalFlags signal_flags;
	public GType return_type;
	public uint n_params;
	public GType[] param_types;
}

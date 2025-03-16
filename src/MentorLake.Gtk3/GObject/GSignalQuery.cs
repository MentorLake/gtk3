namespace MentorLake.GObject;

public class GSignalQueryHandle : BaseSafeHandle
{
}


public static class GSignalQueryExtensions
{

	public static GSignalQuery Dereference(this GSignalQueryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalQuery>(x.DangerousGetHandle());
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

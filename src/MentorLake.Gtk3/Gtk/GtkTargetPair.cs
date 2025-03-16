namespace MentorLake.Gtk;

public class GtkTargetPairHandle : BaseSafeHandle
{
}


public static class GtkTargetPairExtensions
{

	public static GtkTargetPair Dereference(this GtkTargetPairHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTargetPair>(x.DangerousGetHandle());
}
internal class GtkTargetPairExterns
{
}

public struct GtkTargetPair
{
	public GdkAtom target;
	public uint flags;
	public uint info;
}

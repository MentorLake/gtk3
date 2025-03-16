namespace MentorLake.Gtk;

public class GtkTableRowColHandle : BaseSafeHandle
{
}


public static class GtkTableRowColExtensions
{

	public static GtkTableRowCol Dereference(this GtkTableRowColHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTableRowCol>(x.DangerousGetHandle());
}
internal class GtkTableRowColExterns
{
}

public struct GtkTableRowCol
{
	public ushort requisition;
	public ushort allocation;
	public ushort spacing;
	public uint need_expand;
	public uint need_shrink;
	public uint expand;
	public uint shrink;
	public uint empty;
}

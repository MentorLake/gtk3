namespace MentorLake.Gtk;


public class GtkTableChildHandle : BaseSafeHandle
{
}


public static class GtkTableChildExtensions
{

	public static GtkTableChild Dereference(this GtkTableChildHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTableChild>(x.DangerousGetHandle());
}
internal class GtkTableChildExterns
{
}


public struct GtkTableChild
{
	
public IntPtr widget;
	
public ushort left_attach;
	
public ushort right_attach;
	
public ushort top_attach;
	
public ushort bottom_attach;
	
public ushort xpadding;
	
public ushort ypadding;
	
public uint xexpand;
	
public uint yexpand;
	
public uint xshrink;
	
public uint yshrink;
	
public uint xfill;
	
public uint yfill;
}

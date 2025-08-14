namespace MentorLake.Gtk;


public class GtkTextBTreeHandle : BaseSafeHandle
{
}


public static class GtkTextBTreeExtensions
{

	public static GtkTextBTree Dereference(this GtkTextBTreeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextBTree>(x.DangerousGetHandle());
}
internal class GtkTextBTreeExterns
{
}


public struct GtkTextBTree
{
}

namespace MentorLake.Gtk;


public struct GtkStock
{
	public string Value;
}


public class GtkStockHandle : BaseSafeHandle
{
}

public static class GtkStockHandleExtensions
{
	public static GtkStock Dereference(this GtkStockHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStock>(x.DangerousGetHandle());
	public static string DereferenceValue(this GtkStockHandle x) => x.Dereference().Value;
}

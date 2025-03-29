namespace MentorLake.Pango;

public class PangoScriptIterHandle : BaseSafeHandle
{
	public static MentorLake.Pango.PangoScriptIterHandle New(string text, int length)
	{
		return PangoScriptIterExterns.pango_script_iter_new(text, length);
	}

}


public static class PangoScriptIterExtensions
{
	public static void Free(this MentorLake.Pango.PangoScriptIterHandle iter)
	{
		if (iter.IsInvalid || iter.IsClosed) throw new Exception("Invalid or closed handle (PangoScriptIter)");
		PangoScriptIterExterns.pango_script_iter_free(iter);
	}

	public static void GetRange(this MentorLake.Pango.PangoScriptIterHandle iter, out string start, out string end, out MentorLake.Pango.PangoScript script)
	{
		if (iter.IsInvalid || iter.IsClosed) throw new Exception("Invalid or closed handle (PangoScriptIter)");
		PangoScriptIterExterns.pango_script_iter_get_range(iter, out start, out end, out script);
	}

	public static bool Next(this MentorLake.Pango.PangoScriptIterHandle iter)
	{
		if (iter.IsInvalid || iter.IsClosed) throw new Exception("Invalid or closed handle (PangoScriptIter)");
		return PangoScriptIterExterns.pango_script_iter_next(iter);
	}


	public static PangoScriptIter Dereference(this PangoScriptIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoScriptIter>(x.DangerousGetHandle());
}
internal class PangoScriptIterExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoScriptIterHandle pango_script_iter_new(string text, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_script_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoScriptIterHandle>))] MentorLake.Pango.PangoScriptIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_script_iter_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoScriptIterHandle>))] MentorLake.Pango.PangoScriptIterHandle iter, out string start, out string end, out MentorLake.Pango.PangoScript script);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_script_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoScriptIterHandle>))] MentorLake.Pango.PangoScriptIterHandle iter);

}

public struct PangoScriptIter
{
}

namespace MentorLake.GLib;

public class GTuplesHandle : BaseSafeHandle
{
}


public static class GTuplesExtensions
{
	public static void Destroy(this MentorLake.GLib.GTuplesHandle tuples)
	{
		GTuplesExterns.g_tuples_destroy(tuples);
	}

	public static IntPtr Index(this MentorLake.GLib.GTuplesHandle tuples, int index_, int field)
	{
		return GTuplesExterns.g_tuples_index(tuples, index_, field);
	}


	public static GTuples Dereference(this GTuplesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTuples>(x.DangerousGetHandle());
}
internal class GTuplesExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tuples_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTuplesHandle>))] MentorLake.GLib.GTuplesHandle tuples);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tuples_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTuplesHandle>))] MentorLake.GLib.GTuplesHandle tuples, int index_, int field);

}

public struct GTuples
{
	public uint len;
}

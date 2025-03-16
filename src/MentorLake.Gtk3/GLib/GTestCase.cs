namespace MentorLake.GLib;

public class GTestCaseHandle : BaseSafeHandle
{
}


public static class GTestCaseExtensions
{
	public static void Free(this MentorLake.GLib.GTestCaseHandle test_case)
	{
		GTestCaseExterns.g_test_case_free(test_case);
	}


	public static GTestCase Dereference(this GTestCaseHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTestCase>(x.DangerousGetHandle());
}
internal class GTestCaseExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_case_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestCaseHandle>))] MentorLake.GLib.GTestCaseHandle test_case);

}

public struct GTestCase
{
}

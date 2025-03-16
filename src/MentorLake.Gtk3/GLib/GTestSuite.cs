namespace MentorLake.GLib;

public class GTestSuiteHandle : BaseSafeHandle
{
}


public static class GTestSuiteExtensions
{
	public static void Add(this MentorLake.GLib.GTestSuiteHandle suite, MentorLake.GLib.GTestCaseHandle test_case)
	{
		GTestSuiteExterns.g_test_suite_add(suite, test_case);
	}

	public static void AddSuite(this MentorLake.GLib.GTestSuiteHandle suite, MentorLake.GLib.GTestSuiteHandle nestedsuite)
	{
		GTestSuiteExterns.g_test_suite_add_suite(suite, nestedsuite);
	}

	public static void Free(this MentorLake.GLib.GTestSuiteHandle suite)
	{
		GTestSuiteExterns.g_test_suite_free(suite);
	}


	public static GTestSuite Dereference(this GTestSuiteHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTestSuite>(x.DangerousGetHandle());
}
internal class GTestSuiteExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_suite_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))] MentorLake.GLib.GTestSuiteHandle suite, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestCaseHandle>))] MentorLake.GLib.GTestCaseHandle test_case);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_suite_add_suite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))] MentorLake.GLib.GTestSuiteHandle suite, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))] MentorLake.GLib.GTestSuiteHandle nestedsuite);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_suite_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))] MentorLake.GLib.GTestSuiteHandle suite);

}

public struct GTestSuite
{
}

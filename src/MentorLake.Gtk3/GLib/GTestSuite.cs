namespace MentorLake.GLib;

/// <summary>
/// <para>
/// An opaque structure representing a test suite.
/// </para>
/// </summary>

public class GTestSuiteHandle : BaseSafeHandle
{
}


public static class GTestSuiteExtensions
{
/// <summary>
/// <para>
/// Adds @test_case to @suite.
/// </para>
/// </summary>

/// <param name="suite">
/// a test suite
/// </param>
/// <param name="test_case">
/// a test case
/// </param>

	public static void Add(this MentorLake.GLib.GTestSuiteHandle suite, MentorLake.GLib.GTestCaseHandle test_case)
	{
		if (suite.IsInvalid) throw new Exception("Invalid handle (GTestSuite)");
		GTestSuiteExterns.g_test_suite_add(suite, test_case);
	}

/// <summary>
/// <para>
/// Adds @nestedsuite to @suite.
/// </para>
/// </summary>

/// <param name="suite">
/// a test suite
/// </param>
/// <param name="nestedsuite">
/// another test suite
/// </param>

	public static void AddSuite(this MentorLake.GLib.GTestSuiteHandle suite, MentorLake.GLib.GTestSuiteHandle nestedsuite)
	{
		if (suite.IsInvalid) throw new Exception("Invalid handle (GTestSuite)");
		GTestSuiteExterns.g_test_suite_add_suite(suite, nestedsuite);
	}

/// <summary>
/// <para>
/// Frees the @suite and all nested suites.
/// </para>
/// </summary>

/// <param name="suite">
/// a test suite
/// </param>

	public static void Free(this MentorLake.GLib.GTestSuiteHandle suite)
	{
		if (suite.IsInvalid) throw new Exception("Invalid handle (GTestSuite)");
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

/// <summary>
/// <para>
/// An opaque structure representing a test suite.
/// </para>
/// </summary>

public struct GTestSuite
{
}

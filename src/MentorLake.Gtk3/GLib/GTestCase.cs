namespace MentorLake.GLib;

/// <summary>
/// <para>
/// An opaque structure representing a test case.
/// </para>
/// </summary>

public class GTestCaseHandle : BaseSafeHandle
{
}


public static class GTestCaseExtensions
{
/// <summary>
/// <para>
/// Free the @test_case.
/// </para>
/// </summary>

/// <param name="test_case">
/// a test case
/// </param>

	public static void Free(this MentorLake.GLib.GTestCaseHandle test_case)
	{
		if (test_case.IsInvalid) throw new Exception("Invalid handle (GTestCase)");
		GTestCaseExterns.g_test_case_free(test_case);
	}


	public static GTestCase Dereference(this GTestCaseHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTestCase>(x.DangerousGetHandle());
}
internal class GTestCaseExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_case_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestCaseHandle>))] MentorLake.GLib.GTestCaseHandle test_case);

}

/// <summary>
/// <para>
/// An opaque structure representing a test case.
/// </para>
/// </summary>

public struct GTestCase
{
}

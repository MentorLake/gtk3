namespace MentorLake.Gtk3.GLib;

public class GTestSuiteHandle : BaseSafeHandle
{
}


public static class GTestSuiteHandleExtensions
{
	public static T Add<T>(this T suite, GTestCaseHandle test_case) where T : GTestSuiteHandle
	{
		GTestSuiteExterns.g_test_suite_add(suite, test_case);
		return suite;
	}

	public static T AddSuite<T>(this T suite, GTestSuiteHandle nestedsuite) where T : GTestSuiteHandle
	{
		GTestSuiteExterns.g_test_suite_add_suite(suite, nestedsuite);
		return suite;
	}

	public static T Free<T>(this T suite) where T : GTestSuiteHandle
	{
		GTestSuiteExterns.g_test_suite_free(suite);
		return suite;
	}

}
internal class GTestSuiteExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_test_suite_add(GTestSuiteHandle suite, GTestCaseHandle test_case);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_suite_add_suite(GTestSuiteHandle suite, GTestSuiteHandle nestedsuite);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_suite_free(GTestSuiteHandle suite);

}

public struct GTestSuite
{
}

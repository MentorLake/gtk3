namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type used for functions that operate on test fixtures.
/// </para>
/// <para>
/// This is used for the fixture setup and teardown functions
/// as well as for the testcases themselves.
/// </para>
/// <para>
/// @user_data is a pointer to the data that was given when
/// registering the test case.
/// </para>
/// <para>
/// @fixture will be a pointer to the area of memory allocated by the
/// test framework, of the size requested.  If the requested size was
/// zero then @fixture will be equal to @user_data.
/// </para>
/// </summary>

/// <param name="fixture">
/// the test fixture
/// </param>
/// <param name="user_data">
/// the data provided when registering the test
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTestFixtureFunc(IntPtr fixture, IntPtr user_data);

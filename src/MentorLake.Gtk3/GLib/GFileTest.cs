namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A test to perform on a file using g_file_test().
/// </para>
/// </summary>

[Flags]
public enum GFileTest : uint
{
/// <summary>
/// <para>
/// %TRUE if the file is a regular file
///     (not a directory). Note that this test will also return %TRUE
///     if the tested file is a symlink to a regular file.
/// </para>
/// </summary>

	G_FILE_TEST_IS_REGULAR = 1,
/// <summary>
/// <para>
/// %TRUE if the file is a symlink.
/// </para>
/// </summary>

	G_FILE_TEST_IS_SYMLINK = 2,
/// <summary>
/// <para>
/// %TRUE if the file is a directory.
/// </para>
/// </summary>

	G_FILE_TEST_IS_DIR = 4,
/// <summary>
/// <para>
/// %TRUE if the file is executable.
/// </para>
/// </summary>

	G_FILE_TEST_IS_EXECUTABLE = 8,
/// <summary>
/// <para>
/// %TRUE if the file exists. It may or may not
///     be a regular file.
/// </para>
/// </summary>

	G_FILE_TEST_EXISTS = 16
}

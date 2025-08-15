namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type of file to return the filename for, when used with
/// [func@GLib.test_build_filename].
/// </para>
/// <para>
/// These two options correspond rather directly to the &apos;dist&apos; and
/// &apos;built&apos; terminology that automake uses and are explicitly used to
/// distinguish between the &apos;srcdir&apos; and &apos;builddir&apos; being separate. All
/// files in your project should either be dist (in the `EXTRA_DIST` or
/// `dist_schema_DATA` sense, in which case they will always be in the
/// srcdir) or built (in the `BUILT_SOURCES` sense, in which case they
/// will always be in the builddir).
/// </para>
/// <para>
/// Note: As a general rule of automake, files that are generated only as
/// part of the build-from-git process (but then are distributed with the
/// tarball) always go in srcdir (even if doing a srcdir != builddir
/// build from git) and are considered as distributed files.
/// </para>
/// <para>
/// The same principles apply for other build systems, such as meson.
/// </para>
/// </summary>

[Flags]
public enum GTestFileType
{
/// <summary>
/// <para>
/// a file that was included in the distribution tarball
/// </para>
/// </summary>

	G_TEST_DIST = 0,
/// <summary>
/// <para>
/// a file that was built on the compiling machine
/// </para>
/// </summary>

	G_TEST_BUILT = 1
}

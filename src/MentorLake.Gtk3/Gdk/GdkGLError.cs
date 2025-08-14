namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Error enumeration for #GdkGLContext.
/// </para>
/// </summary>

[Flags]
public enum GdkGLError
{
/// <summary>
/// <para>
/// OpenGL support is not available
/// </para>
/// </summary>

	GDK_GL_ERROR_NOT_AVAILABLE = 0,
/// <summary>
/// <para>
/// The requested visual format is not supported
/// </para>
/// </summary>

	GDK_GL_ERROR_UNSUPPORTED_FORMAT = 1,
/// <summary>
/// <para>
/// The requested profile is not supported
/// </para>
/// </summary>

	GDK_GL_ERROR_UNSUPPORTED_PROFILE = 2
}

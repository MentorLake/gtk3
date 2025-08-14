namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A #GParamSpec derived structure that redirects operations to
/// other types of #GParamSpec.
/// </para>
/// <para>
/// All operations other than getting or setting the value are redirected,
/// including accessing the nick and blurb, validating a value, and so
/// forth.
/// </para>
/// <para>
/// See g_param_spec_get_redirect_target() for retrieving the overridden
/// property. #GParamSpecOverride is used in implementing
/// g_object_class_override_property(), and will not be directly useful
/// unless you are implementing a new base type similar to GObject.
/// </para>
/// </summary>

public class GParamSpecOverrideHandle : GParamSpecHandle
{
}

public static class GParamSpecOverrideHandleExtensions
{
}

internal class GParamSpecOverrideHandleExterns
{
}

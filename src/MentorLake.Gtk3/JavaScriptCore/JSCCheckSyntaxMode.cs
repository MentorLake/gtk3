namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Enum values to specify a mode to check for syntax errors in jsc_context_check_syntax().
/// </para>
/// </summary>

[Flags]
public enum JSCCheckSyntaxMode
{
/// <summary>
/// <para>
/// mode to check syntax of a script
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_MODE_SCRIPT = 0,
/// <summary>
/// <para>
/// mode to check syntax of a module
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_MODE_MODULE = 1
}

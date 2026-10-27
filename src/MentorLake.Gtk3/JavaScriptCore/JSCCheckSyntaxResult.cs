namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Enum values to specify the result of jsc_context_check_syntax().
/// </para>
/// </summary>

[Flags]
public enum JSCCheckSyntaxResult
{
/// <summary>
/// <para>
/// no errors
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_RESULT_SUCCESS = 0,
/// <summary>
/// <para>
/// recoverable syntax error
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_RESULT_RECOVERABLE_ERROR = 1,
/// <summary>
/// <para>
/// irrecoverable syntax error
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_RESULT_IRRECOVERABLE_ERROR = 2,
/// <summary>
/// <para>
/// unterminated literal error
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_RESULT_UNTERMINATED_LITERAL_ERROR = 3,
/// <summary>
/// <para>
/// out of memory error
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_RESULT_OUT_OF_MEMORY_ERROR = 4,
/// <summary>
/// <para>
/// stack overflow error
/// </para>
/// </summary>

	JSC_CHECK_SYNTAX_RESULT_STACK_OVERFLOW_ERROR = 5
}

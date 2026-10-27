namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Represents the parsed value of the &quot;Expect&quot; header.
/// </para>
/// </summary>

[Flags]
public enum SoupExpectation : uint
{
/// <summary>
/// <para>
/// any unrecognized expectation
/// </para>
/// </summary>

	SOUP_EXPECTATION_UNRECOGNIZED = 1,
/// <summary>
/// <para>
/// &quot;100-continue&quot;
/// </para>
/// </summary>

	SOUP_EXPECTATION_CONTINUE = 2
}

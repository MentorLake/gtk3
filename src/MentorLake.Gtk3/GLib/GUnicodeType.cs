namespace MentorLake.GLib;

/// <summary>
/// <para>
/// These are the possible character classifications from the
/// Unicode specification.
/// See [Unicode Character Database](http://www.unicode.org/reports/tr44/#General_Category_Values).
/// </para>
/// </summary>

[Flags]
public enum GUnicodeType
{
/// <summary>
/// <para>
/// General category &quot;Other, Control&quot; (Cc)
/// </para>
/// </summary>

	G_UNICODE_CONTROL = 0,
/// <summary>
/// <para>
/// General category &quot;Other, Format&quot; (Cf)
/// </para>
/// </summary>

	G_UNICODE_FORMAT = 1,
/// <summary>
/// <para>
/// General category &quot;Other, Not Assigned&quot; (Cn)
/// </para>
/// </summary>

	G_UNICODE_UNASSIGNED = 2,
/// <summary>
/// <para>
/// General category &quot;Other, Private Use&quot; (Co)
/// </para>
/// </summary>

	G_UNICODE_PRIVATE_USE = 3,
/// <summary>
/// <para>
/// General category &quot;Other, Surrogate&quot; (Cs)
/// </para>
/// </summary>

	G_UNICODE_SURROGATE = 4,
/// <summary>
/// <para>
/// General category &quot;Letter, Lowercase&quot; (Ll)
/// </para>
/// </summary>

	G_UNICODE_LOWERCASE_LETTER = 5,
/// <summary>
/// <para>
/// General category &quot;Letter, Modifier&quot; (Lm)
/// </para>
/// </summary>

	G_UNICODE_MODIFIER_LETTER = 6,
/// <summary>
/// <para>
/// General category &quot;Letter, Other&quot; (Lo)
/// </para>
/// </summary>

	G_UNICODE_OTHER_LETTER = 7,
/// <summary>
/// <para>
/// General category &quot;Letter, Titlecase&quot; (Lt)
/// </para>
/// </summary>

	G_UNICODE_TITLECASE_LETTER = 8,
/// <summary>
/// <para>
/// General category &quot;Letter, Uppercase&quot; (Lu)
/// </para>
/// </summary>

	G_UNICODE_UPPERCASE_LETTER = 9,
/// <summary>
/// <para>
/// General category &quot;Mark, Spacing&quot; (Mc)
/// </para>
/// </summary>

	G_UNICODE_SPACING_MARK = 10,
/// <summary>
/// <para>
/// General category &quot;Mark, Enclosing&quot; (Me)
/// </para>
/// </summary>

	G_UNICODE_ENCLOSING_MARK = 11,
/// <summary>
/// <para>
/// General category &quot;Mark, Nonspacing&quot; (Mn)
/// </para>
/// </summary>

	G_UNICODE_NON_SPACING_MARK = 12,
/// <summary>
/// <para>
/// General category &quot;Number, Decimal Digit&quot; (Nd)
/// </para>
/// </summary>

	G_UNICODE_DECIMAL_NUMBER = 13,
/// <summary>
/// <para>
/// General category &quot;Number, Letter&quot; (Nl)
/// </para>
/// </summary>

	G_UNICODE_LETTER_NUMBER = 14,
/// <summary>
/// <para>
/// General category &quot;Number, Other&quot; (No)
/// </para>
/// </summary>

	G_UNICODE_OTHER_NUMBER = 15,
/// <summary>
/// <para>
/// General category &quot;Punctuation, Connector&quot; (Pc)
/// </para>
/// </summary>

	G_UNICODE_CONNECT_PUNCTUATION = 16,
/// <summary>
/// <para>
/// General category &quot;Punctuation, Dash&quot; (Pd)
/// </para>
/// </summary>

	G_UNICODE_DASH_PUNCTUATION = 17,
/// <summary>
/// <para>
/// General category &quot;Punctuation, Close&quot; (Pe)
/// </para>
/// </summary>

	G_UNICODE_CLOSE_PUNCTUATION = 18,
/// <summary>
/// <para>
/// General category &quot;Punctuation, Final quote&quot; (Pf)
/// </para>
/// </summary>

	G_UNICODE_FINAL_PUNCTUATION = 19,
/// <summary>
/// <para>
/// General category &quot;Punctuation, Initial quote&quot; (Pi)
/// </para>
/// </summary>

	G_UNICODE_INITIAL_PUNCTUATION = 20,
/// <summary>
/// <para>
/// General category &quot;Punctuation, Other&quot; (Po)
/// </para>
/// </summary>

	G_UNICODE_OTHER_PUNCTUATION = 21,
/// <summary>
/// <para>
/// General category &quot;Punctuation, Open&quot; (Ps)
/// </para>
/// </summary>

	G_UNICODE_OPEN_PUNCTUATION = 22,
/// <summary>
/// <para>
/// General category &quot;Symbol, Currency&quot; (Sc)
/// </para>
/// </summary>

	G_UNICODE_CURRENCY_SYMBOL = 23,
/// <summary>
/// <para>
/// General category &quot;Symbol, Modifier&quot; (Sk)
/// </para>
/// </summary>

	G_UNICODE_MODIFIER_SYMBOL = 24,
/// <summary>
/// <para>
/// General category &quot;Symbol, Math&quot; (Sm)
/// </para>
/// </summary>

	G_UNICODE_MATH_SYMBOL = 25,
/// <summary>
/// <para>
/// General category &quot;Symbol, Other&quot; (So)
/// </para>
/// </summary>

	G_UNICODE_OTHER_SYMBOL = 26,
/// <summary>
/// <para>
/// General category &quot;Separator, Line&quot; (Zl)
/// </para>
/// </summary>

	G_UNICODE_LINE_SEPARATOR = 27,
/// <summary>
/// <para>
/// General category &quot;Separator, Paragraph&quot; (Zp)
/// </para>
/// </summary>

	G_UNICODE_PARAGRAPH_SEPARATOR = 28,
/// <summary>
/// <para>
/// General category &quot;Separator, Space&quot; (Zs)
/// </para>
/// </summary>

	G_UNICODE_SPACE_SEPARATOR = 29
}

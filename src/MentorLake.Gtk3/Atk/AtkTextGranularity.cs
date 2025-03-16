namespace MentorLake.Atk;

[Flags]
public enum AtkTextGranularity
{
	ATK_TEXT_GRANULARITY_CHAR = 0,
	ATK_TEXT_GRANULARITY_WORD = 1,
	ATK_TEXT_GRANULARITY_SENTENCE = 2,
	ATK_TEXT_GRANULARITY_LINE = 3,
	ATK_TEXT_GRANULARITY_PARAGRAPH = 4
}

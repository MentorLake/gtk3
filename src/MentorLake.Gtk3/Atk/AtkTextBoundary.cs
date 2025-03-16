namespace MentorLake.Atk;

[Flags]
public enum AtkTextBoundary
{
	ATK_TEXT_BOUNDARY_CHAR = 0,
	ATK_TEXT_BOUNDARY_WORD_START = 1,
	ATK_TEXT_BOUNDARY_WORD_END = 2,
	ATK_TEXT_BOUNDARY_SENTENCE_START = 3,
	ATK_TEXT_BOUNDARY_SENTENCE_END = 4,
	ATK_TEXT_BOUNDARY_LINE_START = 5,
	ATK_TEXT_BOUNDARY_LINE_END = 6
}

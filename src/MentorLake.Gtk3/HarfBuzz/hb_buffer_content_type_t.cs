namespace MentorLake.HarfBuzz;

[Flags]
public enum hb_buffer_content_type_t
{
	HB_BUFFER_CONTENT_TYPE_INVALID = 0,
	HB_BUFFER_CONTENT_TYPE_UNICODE = 1,
	HB_BUFFER_CONTENT_TYPE_GLYPHS = 2
}

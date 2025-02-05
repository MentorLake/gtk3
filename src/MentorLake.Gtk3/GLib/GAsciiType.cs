namespace MentorLake.Gtk3.GLib;

[Flags]
public enum GAsciiType
{
	G_ASCII_ALNUM = 0,
	G_ASCII_ALPHA = 1,
	G_ASCII_CNTRL = 2,
	G_ASCII_DIGIT = 4,
	G_ASCII_GRAPH = 8,
	G_ASCII_LOWER = 16,
	G_ASCII_PRINT = 32,
	G_ASCII_PUNCT = 64,
	G_ASCII_SPACE = 128,
	G_ASCII_UPPER = 256,
	G_ASCII_XDIGIT = 512
}

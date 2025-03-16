namespace MentorLake.Vulkan;

public class VkImageViewASTCDecodeModeEXTHandle : BaseSafeHandle
{
}


public static class VkImageViewASTCDecodeModeEXTExtensions
{

	public static VkImageViewASTCDecodeModeEXT Dereference(this VkImageViewASTCDecodeModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewASTCDecodeModeEXT>(x.DangerousGetHandle());
}
internal class VkImageViewASTCDecodeModeEXTExterns
{
}

public struct VkImageViewASTCDecodeModeEXT
{
}

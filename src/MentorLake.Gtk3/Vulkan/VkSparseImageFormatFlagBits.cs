namespace MentorLake.Vulkan;

public class VkSparseImageFormatFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSparseImageFormatFlagBitsExtensions
{

	public static VkSparseImageFormatFlagBits Dereference(this VkSparseImageFormatFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageFormatFlagBits>(x.DangerousGetHandle());
}
internal class VkSparseImageFormatFlagBitsExterns
{
}

public struct VkSparseImageFormatFlagBits
{
}

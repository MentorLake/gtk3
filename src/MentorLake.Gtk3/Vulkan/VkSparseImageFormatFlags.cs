namespace MentorLake.Vulkan;

public class VkSparseImageFormatFlagsHandle : BaseSafeHandle
{
}


public static class VkSparseImageFormatFlagsExtensions
{

	public static VkSparseImageFormatFlags Dereference(this VkSparseImageFormatFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageFormatFlags>(x.DangerousGetHandle());
}
internal class VkSparseImageFormatFlagsExterns
{
}

public struct VkSparseImageFormatFlags
{
}

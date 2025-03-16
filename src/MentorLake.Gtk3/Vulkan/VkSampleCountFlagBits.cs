namespace MentorLake.Vulkan;

public class VkSampleCountFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSampleCountFlagBitsExtensions
{

	public static VkSampleCountFlagBits Dereference(this VkSampleCountFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSampleCountFlagBits>(x.DangerousGetHandle());
}
internal class VkSampleCountFlagBitsExterns
{
}

public struct VkSampleCountFlagBits
{
}

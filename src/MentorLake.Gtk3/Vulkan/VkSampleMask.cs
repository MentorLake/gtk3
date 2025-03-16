namespace MentorLake.Vulkan;

public class VkSampleMaskHandle : BaseSafeHandle
{
}


public static class VkSampleMaskExtensions
{

	public static VkSampleMask Dereference(this VkSampleMaskHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSampleMask>(x.DangerousGetHandle());
}
internal class VkSampleMaskExterns
{
}

public struct VkSampleMask
{
}

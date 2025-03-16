namespace MentorLake.Vulkan;

public class VkSampleCountFlagsHandle : BaseSafeHandle
{
}


public static class VkSampleCountFlagsExtensions
{

	public static VkSampleCountFlags Dereference(this VkSampleCountFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSampleCountFlags>(x.DangerousGetHandle());
}
internal class VkSampleCountFlagsExterns
{
}

public struct VkSampleCountFlags
{
}

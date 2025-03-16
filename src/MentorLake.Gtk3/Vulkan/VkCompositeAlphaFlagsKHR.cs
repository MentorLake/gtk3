namespace MentorLake.Vulkan;

public class VkCompositeAlphaFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkCompositeAlphaFlagsKHRExtensions
{

	public static VkCompositeAlphaFlagsKHR Dereference(this VkCompositeAlphaFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCompositeAlphaFlagsKHR>(x.DangerousGetHandle());
}
internal class VkCompositeAlphaFlagsKHRExterns
{
}

public struct VkCompositeAlphaFlagsKHR
{
}

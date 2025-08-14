namespace MentorLake.Vulkan;


public class VkPushConstantsInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPushConstantsInfoKHRExtensions
{

	public static VkPushConstantsInfoKHR Dereference(this VkPushConstantsInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPushConstantsInfoKHR>(x.DangerousGetHandle());
}
internal class VkPushConstantsInfoKHRExterns
{
}


public struct VkPushConstantsInfoKHR
{
}

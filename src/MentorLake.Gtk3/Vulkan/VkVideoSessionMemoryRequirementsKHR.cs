namespace MentorLake.Vulkan;


public class VkVideoSessionMemoryRequirementsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionMemoryRequirementsKHRExtensions
{

	public static VkVideoSessionMemoryRequirementsKHR Dereference(this VkVideoSessionMemoryRequirementsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionMemoryRequirementsKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionMemoryRequirementsKHRExterns
{
}


public struct VkVideoSessionMemoryRequirementsKHR
{
}

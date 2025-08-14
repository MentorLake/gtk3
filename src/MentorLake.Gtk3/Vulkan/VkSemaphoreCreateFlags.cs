namespace MentorLake.Vulkan;


public class VkSemaphoreCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkSemaphoreCreateFlagsExtensions
{

	public static VkSemaphoreCreateFlags Dereference(this VkSemaphoreCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreCreateFlags>(x.DangerousGetHandle());
}
internal class VkSemaphoreCreateFlagsExterns
{
}


public struct VkSemaphoreCreateFlags
{
}

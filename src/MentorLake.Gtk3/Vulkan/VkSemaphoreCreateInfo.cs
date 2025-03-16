namespace MentorLake.Vulkan;

public class VkSemaphoreCreateInfoHandle : BaseSafeHandle
{
}


public static class VkSemaphoreCreateInfoExtensions
{

	public static VkSemaphoreCreateInfo Dereference(this VkSemaphoreCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreCreateInfo>(x.DangerousGetHandle());
}
internal class VkSemaphoreCreateInfoExterns
{
}

public struct VkSemaphoreCreateInfo
{
}

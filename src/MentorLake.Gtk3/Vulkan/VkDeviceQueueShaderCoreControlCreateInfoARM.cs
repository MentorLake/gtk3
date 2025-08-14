namespace MentorLake.Vulkan;


public class VkDeviceQueueShaderCoreControlCreateInfoARMHandle : BaseSafeHandle
{
}


public static class VkDeviceQueueShaderCoreControlCreateInfoARMExtensions
{

	public static VkDeviceQueueShaderCoreControlCreateInfoARM Dereference(this VkDeviceQueueShaderCoreControlCreateInfoARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceQueueShaderCoreControlCreateInfoARM>(x.DangerousGetHandle());
}
internal class VkDeviceQueueShaderCoreControlCreateInfoARMExterns
{
}


public struct VkDeviceQueueShaderCoreControlCreateInfoARM
{
}

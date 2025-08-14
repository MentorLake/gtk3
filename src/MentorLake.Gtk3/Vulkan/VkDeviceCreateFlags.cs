namespace MentorLake.Vulkan;


public class VkDeviceCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkDeviceCreateFlagsExtensions
{

	public static VkDeviceCreateFlags Dereference(this VkDeviceCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceCreateFlags>(x.DangerousGetHandle());
}
internal class VkDeviceCreateFlagsExterns
{
}


public struct VkDeviceCreateFlags
{
}

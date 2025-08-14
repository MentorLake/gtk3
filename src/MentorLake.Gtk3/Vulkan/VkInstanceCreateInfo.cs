namespace MentorLake.Vulkan;


public class VkInstanceCreateInfoHandle : BaseSafeHandle
{
}


public static class VkInstanceCreateInfoExtensions
{

	public static VkInstanceCreateInfo Dereference(this VkInstanceCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInstanceCreateInfo>(x.DangerousGetHandle());
}
internal class VkInstanceCreateInfoExterns
{
}


public struct VkInstanceCreateInfo
{
}

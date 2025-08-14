namespace MentorLake.Vulkan;


public class VkQueryPoolCreateInfoHandle : BaseSafeHandle
{
}


public static class VkQueryPoolCreateInfoExtensions
{

	public static VkQueryPoolCreateInfo Dereference(this VkQueryPoolCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPoolCreateInfo>(x.DangerousGetHandle());
}
internal class VkQueryPoolCreateInfoExterns
{
}


public struct VkQueryPoolCreateInfo
{
}

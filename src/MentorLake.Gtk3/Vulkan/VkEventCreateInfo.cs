namespace MentorLake.Vulkan;

public class VkEventCreateInfoHandle : BaseSafeHandle
{
}


public static class VkEventCreateInfoExtensions
{

	public static VkEventCreateInfo Dereference(this VkEventCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkEventCreateInfo>(x.DangerousGetHandle());
}
internal class VkEventCreateInfoExterns
{
}

public struct VkEventCreateInfo
{
}

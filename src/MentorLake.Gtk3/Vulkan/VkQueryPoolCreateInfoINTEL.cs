namespace MentorLake.Vulkan;


public class VkQueryPoolCreateInfoINTELHandle : BaseSafeHandle
{
}


public static class VkQueryPoolCreateInfoINTELExtensions
{

	public static VkQueryPoolCreateInfoINTEL Dereference(this VkQueryPoolCreateInfoINTELHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPoolCreateInfoINTEL>(x.DangerousGetHandle());
}
internal class VkQueryPoolCreateInfoINTELExterns
{
}


public struct VkQueryPoolCreateInfoINTEL
{
}

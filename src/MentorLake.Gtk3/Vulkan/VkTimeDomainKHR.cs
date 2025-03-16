namespace MentorLake.Vulkan;

public class VkTimeDomainKHRHandle : BaseSafeHandle
{
}


public static class VkTimeDomainKHRExtensions
{

	public static VkTimeDomainKHR Dereference(this VkTimeDomainKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTimeDomainKHR>(x.DangerousGetHandle());
}
internal class VkTimeDomainKHRExterns
{
}

public struct VkTimeDomainKHR
{
}

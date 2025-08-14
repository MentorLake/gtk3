namespace MentorLake.Vulkan;


public class VkTimeDomainEXTHandle : BaseSafeHandle
{
}


public static class VkTimeDomainEXTExtensions
{

	public static VkTimeDomainEXT Dereference(this VkTimeDomainEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTimeDomainEXT>(x.DangerousGetHandle());
}
internal class VkTimeDomainEXTExterns
{
}


public struct VkTimeDomainEXT
{
}

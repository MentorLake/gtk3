namespace MentorLake.Vulkan;


public class VkDisplayEventTypeEXTHandle : BaseSafeHandle
{
}


public static class VkDisplayEventTypeEXTExtensions
{

	public static VkDisplayEventTypeEXT Dereference(this VkDisplayEventTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayEventTypeEXT>(x.DangerousGetHandle());
}
internal class VkDisplayEventTypeEXTExterns
{
}


public struct VkDisplayEventTypeEXT
{
}

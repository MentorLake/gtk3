namespace MentorLake.Vulkan;


public class VkInstanceCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkInstanceCreateFlagBitsExtensions
{

	public static VkInstanceCreateFlagBits Dereference(this VkInstanceCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInstanceCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkInstanceCreateFlagBitsExterns
{
}


public struct VkInstanceCreateFlagBits
{
}

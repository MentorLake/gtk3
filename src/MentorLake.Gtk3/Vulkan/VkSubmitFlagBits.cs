namespace MentorLake.Vulkan;


public class VkSubmitFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSubmitFlagBitsExtensions
{

	public static VkSubmitFlagBits Dereference(this VkSubmitFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubmitFlagBits>(x.DangerousGetHandle());
}
internal class VkSubmitFlagBitsExterns
{
}


public struct VkSubmitFlagBits
{
}

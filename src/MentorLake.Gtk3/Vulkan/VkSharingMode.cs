namespace MentorLake.Vulkan;


public class VkSharingModeHandle : BaseSafeHandle
{
}


public static class VkSharingModeExtensions
{

	public static VkSharingMode Dereference(this VkSharingModeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSharingMode>(x.DangerousGetHandle());
}
internal class VkSharingModeExterns
{
}


public struct VkSharingMode
{
}

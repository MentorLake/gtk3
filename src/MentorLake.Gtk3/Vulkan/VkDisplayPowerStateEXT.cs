namespace MentorLake.Vulkan;


public class VkDisplayPowerStateEXTHandle : BaseSafeHandle
{
}


public static class VkDisplayPowerStateEXTExtensions
{

	public static VkDisplayPowerStateEXT Dereference(this VkDisplayPowerStateEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPowerStateEXT>(x.DangerousGetHandle());
}
internal class VkDisplayPowerStateEXTExterns
{
}


public struct VkDisplayPowerStateEXT
{
}

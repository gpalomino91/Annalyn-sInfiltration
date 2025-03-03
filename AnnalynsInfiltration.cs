public class QuestLogic
{
    // Task 1: Check if a fast attack can be made
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
  
    // Task 2: Check if the group can be spied upon
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    // Task 3: Check if the prisoner can be signaled
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

    // Task 4: Check if the prisoner can be freed
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake);
}

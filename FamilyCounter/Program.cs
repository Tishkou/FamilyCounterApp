using FamilyCounter;


FamilyCounterLogic.WelcomeUser();

var (familyNames, numbersFamily) = FamilyCounterLogic.GetUserInput();

FamilyCounterLogic.DisplayFamily(familyNames);

FamilyCounterLogic.DisplayCounter(numbersFamily);

